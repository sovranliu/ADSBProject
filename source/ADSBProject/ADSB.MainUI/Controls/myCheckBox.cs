using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ADSB.MainUI.Controls
{
    public partial class myCheckBox : CheckBox
    {
        private Color _baseColor = Color.FromArgb(255, 255, 255);
        private int myCheckButtonWidth = 16;

        private static readonly ContentAlignment RightAlignment =
            ContentAlignment.TopRight |
            ContentAlignment.BottomRight |
            ContentAlignment.MiddleRight;
        private static readonly ContentAlignment LeftAligbment =
            ContentAlignment.TopLeft |
            ContentAlignment.BottomLeft |
            ContentAlignment.MiddleLeft;

        public myCheckBox()
            : base()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        public int CheckButtonWidth
        {
            get { return myCheckButtonWidth; }
            set { myCheckButtonWidth = value; }
        }


        public Color BaseColor
        {
            get { return _baseColor; }
            set
            {
                _baseColor = value;
                base.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            base.OnPaintBackground(e);

            Graphics g = e.Graphics;
            Rectangle checkButtonRect;
            Rectangle textRect;

            CalculateRect(out checkButtonRect, out textRect);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = ControlPaint.Light(_baseColor);
            Color borderColor;
            Color innerBorderColor;
            Color checkColor, checkedStatecolor, uncheckedStatecolor;
            //bool hover = false;
            int radius;

            borderColor = SystemColors.ControlDark;
            innerBorderColor = SystemColors.ControlDark;
            checkColor = _baseColor;

            if (CheckState == CheckState.Checked)
            {
                //绘制勾选框及其颜色
                radius = 5;
                using (SolidBrush brush = new SolidBrush(Color.Blue))
                {
                    FillRound(checkButtonRect, g, brush, radius);
                }
                checkedStatecolor = checkColor;
                DrawCheckedFlag(g, checkButtonRect, checkedStatecolor);
            }
            else   //未被选中的话，显示未被选中状态
            {
                radius = 8;
                uncheckedStatecolor = Color.Gray;
                using (Pen pen = new Pen(uncheckedStatecolor, 2F))
                {
                    DrawRound(checkButtonRect, g, pen, radius);
                }

                DrawCheckedFlag(g, checkButtonRect, uncheckedStatecolor);
            }

            Color textColor = Enabled ? ForeColor : SystemColors.GrayText;
            TextRenderer.DrawText(g, Text, Font, textRect, textColor,
                GetTextFormatFlags(TextAlign, RightToLeft == RightToLeft.Yes));
        }

        #region 填充圆角矩形
        /// <summary>
        /// 生成圆角矩形路径
        /// </summary>
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        /// <summary>
        /// 填充圆角矩形
        /// </summary>
        private void FillRound(Rectangle rectangle, Graphics g, Brush br, int _radius)
        {
            g.FillPath(br, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, _radius));
        }

        /// <summary>
        /// 画圆角矩形边框
        /// </summary>
        /// <param name="checkButtonRect"></param>
        /// <param name="textRect"></param>
        private void DrawRound(Rectangle rectangle, Graphics g, Pen br, int _radius)
        {
            g.DrawPath(br, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, _radius));
        }
        #endregion

        private void CalculateRect(
             out Rectangle checkButtonRect, out Rectangle textRect)
        {
            checkButtonRect = new Rectangle(0, 0, myCheckButtonWidth, myCheckButtonWidth);
            textRect = Rectangle.Empty;
            bool bCheckAlignLeft = (int)(LeftAligbment & CheckAlign) != 0;
            bool bCheckAlignRight = (int)(RightAlignment & CheckAlign) != 0;
            bool bRightToLeft = RightToLeft == RightToLeft.Yes;

            if ((bCheckAlignLeft && !bRightToLeft) ||
                (bCheckAlignRight && bRightToLeft))
            {
                switch (CheckAlign)
                {
                    case ContentAlignment.TopRight:
                    case ContentAlignment.TopLeft:
                        checkButtonRect.Y = 2;
                        break;
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.MiddleLeft:
                        checkButtonRect.Y = (Height - myCheckButtonWidth) / 2;
                        break;
                    case ContentAlignment.BottomRight:
                    case ContentAlignment.BottomLeft:
                        checkButtonRect.Y = Height - myCheckButtonWidth - 2;
                        break;
                }

                checkButtonRect.X = 1;

                textRect = new Rectangle(
                    checkButtonRect.Right + 4,
                    0,
                    Width - checkButtonRect.Right - 4,
                    Height);
            }
            else if ((bCheckAlignRight && !bRightToLeft)
                || (bCheckAlignLeft && bRightToLeft))
            {
                switch (CheckAlign)
                {
                    case ContentAlignment.TopLeft:
                    case ContentAlignment.TopRight:
                        checkButtonRect.Y = 2;
                        break;
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.MiddleRight:
                        checkButtonRect.Y = (Height - myCheckButtonWidth) / 2;
                        break;
                    case ContentAlignment.BottomLeft:
                    case ContentAlignment.BottomRight:
                        checkButtonRect.Y = Height - myCheckButtonWidth - 2;
                        break;
                }

                checkButtonRect.X = Width - myCheckButtonWidth - 1;

                textRect = new Rectangle(
                    2, 0, Width - myCheckButtonWidth - 6, Height);
            }
            else
            {
                switch (CheckAlign)
                {
                    case ContentAlignment.TopCenter:
                        checkButtonRect.Y = 2;
                        textRect.Y = checkButtonRect.Bottom + 2;
                        textRect.Height = Height - myCheckButtonWidth - 6;
                        break;
                    case ContentAlignment.MiddleCenter:
                        checkButtonRect.Y = (Height - myCheckButtonWidth) / 2;
                        textRect.Y = 0;
                        textRect.Height = Height;
                        break;
                    case ContentAlignment.BottomCenter:
                        checkButtonRect.Y = Height - myCheckButtonWidth - 2;
                        textRect.Y = 0;
                        textRect.Height = Height - myCheckButtonWidth - 6;
                        break;
                }

                checkButtonRect.X = (Width - myCheckButtonWidth) / 2;

                textRect.X = 2;
                textRect.Width = Width - 4;
            }
        }

        private void DrawCheckedFlag(Graphics graphics, Rectangle rect, Color color)
        {
            PointF[] points = new PointF[3];
            points[0] = new PointF(
                rect.X + rect.Width / 5f,
                rect.Y + rect.Height / 3f);
            points[1] = new PointF(
                rect.X + rect.Width / 2.5f,
                rect.Bottom - rect.Height / 2f+2);
            points[2] = new PointF(
                rect.Right - rect.Width / 4.0f,
                rect.Y + rect.Height / 4.5f);
            using (Pen pen = new Pen(color, 2F))
            {
                graphics.DrawLines(pen, points);
            }
        }

        private Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;

            if (a + a0 > 255) { a = 255; } else { a = Math.Max(a + a0, 0); }
            if (r + r0 > 255) { r = 255; } else { r = Math.Max(r + r0, 0); }
            if (g + g0 > 255) { g = 255; } else { g = Math.Max(g + g0, 0); }
            if (b + b0 > 255) { b = 255; } else { b = Math.Max(b + b0, 0); }

            return Color.FromArgb(a, r, g, b);
        }

        internal static TextFormatFlags GetTextFormatFlags(
            ContentAlignment alignment,
            bool rightToleft)
        {
            TextFormatFlags flags = TextFormatFlags.WordBreak |
                TextFormatFlags.SingleLine;
            if (rightToleft)
            {
                flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
            }

            switch (alignment)
            {
                case ContentAlignment.BottomCenter:
                    flags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.BottomLeft:
                    flags |= TextFormatFlags.Bottom | TextFormatFlags.Left;
                    break;
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Bottom | TextFormatFlags.Right;
                    break;
                case ContentAlignment.MiddleCenter:
                    flags |= TextFormatFlags.HorizontalCenter |
                        TextFormatFlags.VerticalCenter;
                    break;
                case ContentAlignment.MiddleLeft:
                    flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                    break;
                case ContentAlignment.MiddleRight:
                    flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                    break;
                case ContentAlignment.TopCenter:
                    flags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.TopLeft:
                    flags |= TextFormatFlags.Top | TextFormatFlags.Left;
                    break;
                case ContentAlignment.TopRight:
                    flags |= TextFormatFlags.Top | TextFormatFlags.Right;
                    break;
            }
            return flags;
        }
    }
}
