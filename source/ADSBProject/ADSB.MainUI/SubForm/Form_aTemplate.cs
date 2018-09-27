using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ADSB.MainUI.SubForm
{
    public partial class Form_aTemplate : Form
    {
        //绘制窗口阴影 控制参数
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        //模板绘制控制参数
        int conerRadius = 16, arcRadius = 37;
        Color winBackgroundColor = Color.FromArgb(255, 255, 255);
        Color winArcColor = Color.FromArgb(29, 104, 190);

        public Form_aTemplate()
        {
            InitializeComponent();
            // 在构造中调用此函数 绘制窗口阴影 
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }


        //重写OnPaint函数，绘制窗口模板  
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Graphics g = e.Graphics;

            //radius = 50;
            //画窗口外形
            Rectangle winRect = new Rectangle(0, 0, this.Width, this.Height);
            using (Pen br = new Pen(Color.Black,1))
            {
                DrawRound(winRect, g, br, conerRadius);
            }

            using (SolidBrush brush = new SolidBrush(winBackgroundColor))
            {
                FillRound(winRect, g, brush, conerRadius);
            }

            Rectangle winRectArc = new Rectangle(0, 0, this.Width, this.Height);
            //画右上角图标
            using (SolidBrush brush = new SolidBrush(winArcColor))
            {
                FillRoundShape(winRectArc, g, brush, conerRadius, arcRadius);
            }

            Type(this, 20, 0.1);
        }

        #region 填充带圆角的窗口边框
        /// <summary>
        /// 生成圆角矩形路径
        /// </summary>
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(x, y, 2 * radius, 2 * radius, 180, 90);
            gp.AddArc(width - 2 * radius, y, 2 * radius, 2 * radius, 270, 90);
            gp.AddArc(width - 2 * radius, height - 2 * radius, 2 * radius, 2 * radius, 0, 90);
            gp.AddArc(x, height - 2 * radius, 2 * radius, 2 * radius, 90, 90);
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

        private void FillRoundShape(Rectangle rectangle, Graphics g, Brush br, int _radius, int arcRadius)
        {
            g.FillPath(br, DrawRoundShape(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, _radius, arcRadius));

        }

        //生成右上角标志路径
        public static GraphicsPath DrawRoundShape(int x, int y, int width, int height, int conerRadius, int arcRadius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(width - 2 * conerRadius, y, 2 * conerRadius, 2 * conerRadius, 270, 90);
            gp.AddLine(new Point(width, conerRadius), new Point(width, conerRadius));
            gp.AddArc(width - arcRadius, y - arcRadius, 2 * arcRadius, 2 * arcRadius, 90, 90);
            gp.AddLine(new Point(width - arcRadius, y), new Point(width - conerRadius, y));
            gp.CloseAllFigures();
            return gp;
        }
        #endregion

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(new Point[]
                                     { new Point(0, 12),
                                       new Point(12, 0),
                                       new Point(sender.Width - 12, 0),
                                       new Point(sender.Width, 12),
                                       new Point(sender.Width, sender.Height - 20),
                                       new Point(sender.Width - 20, sender.Height),
                                       new Point(12, sender.Height),
                                       new Point(0, sender.Height - 12) },
                                       (float)p_2);
            sender.Region = new Region(oPath);
        }
    }
}
