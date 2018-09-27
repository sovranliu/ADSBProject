using ADSB.MainUI.SubForm;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ADSB.MainUI
{
    public partial class MainForm : Form
    {
        #region 飞行模式下按钮菜单
        //模式按钮

        //扩展罗盘按钮
        private void sLabel_expandCompass_Click(object sender, EventArgs e)
        {
            sPnl_Compass.Visible = false;
            Form test = new Form_status();
            test.ShowDialog();
        }

        //航迹按钮


        //防拥按钮


        //高度过滤按钮
        private void sLabelAltitude_Click(object sender, EventArgs e)
        {
            sPnl_Compass.Visible = false;
            Form test = new Form_gaodu();
            test.ShowDialog();

        }

        //距离过滤按钮
        private void sLabel_distanceFilter_Click(object sender, EventArgs e)
        {
            Form test = new Form_distanceFilter();
            test.ShowDialog();
        }

        //本机信息按钮
        private void sLabel_info_Click(object sender, EventArgs e)
        {
            sPnl_Compass.Visible = false;
            Form test = new Form_info();
            test.ShowDialog();
        }

        //功能按钮


        //量程过滤按钮
        private void sPnl_liangcheng_Click(object sender, EventArgs e)
        {
            sPnl_Compass.Visible = false;
            Form test = new Form_liangcheng();
            test.ShowDialog();
        }
        #endregion

        private void sPnl_Func_Paint(object sender, PaintEventArgs e)
        {
            //消除锯齿
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //绘制圆底盘
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.FillEllipse(brush, 0, 0, 59, 59);

            //绘制小正方形
            Pen pen = new Pen(Color.FromArgb(255, 0, 0x5D, 0xC9), 2);
            e.Graphics.DrawRectangle(pen, 19, 13, 9, 9);
            e.Graphics.DrawRectangle(pen, 31, 13, 9, 9);
            e.Graphics.DrawRectangle(pen, 31, 25, 9, 9);
            e.Graphics.DrawRectangle(pen, 19, 25, 9, 9);

            //绘制文字
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 0, 0x5D, 0xC9));
            Font textFont = new Font("微软雅黑", 32, FontStyle.Bold, GraphicsUnit.Document);
            e.Graphics.DrawString("功能", textFont, textBrush, 18, 41);

        }

        private void sPnl_Compass_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //绘制三角形指针
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 26, 191, 255));
            PointF point1 = new PointF(244, 248);
            PointF point2 = new PointF(253, 248);
            PointF point3 = new PointF(248.5f, 96);
            PointF[] curvePoints = { point1, point2, point3 };
            e.Graphics.FillPolygon(blueBrush, curvePoints);

            // e.Graphics.FillRectangle(blueBrush, 244, 96, 9,152);


            //绘制中心圆圈
            Pen pen = new Pen(Color.FromArgb(255, 252, 233, 30), 1);
            e.Graphics.DrawEllipse(pen, 208, 206, 82, 82);

            Font textFont = new Font("雅黑", 10,FontStyle.Regular);
            e.Graphics.DrawString("30", textFont, blueBrush, 238.7F,  84.5F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("33", textFont, blueBrush, 315.9F, 101.8F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("00", textFont, blueBrush, 375F,   158.4F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("03", textFont, blueBrush, 400F,   239.2F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("06", textFont, blueBrush, 375F,   316.4F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("09", textFont, blueBrush, 315.9F, 375.5F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("12", textFont, blueBrush, 239.9F, 400.5F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("15", textFont, blueBrush, 159F,   376.1F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("18", textFont, blueBrush, 101.9F, 317.5F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("21", textFont, blueBrush, 84F,    240.4F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("24", textFont, blueBrush, 101.3F, 158.4F, StringFormat.GenericTypographic);
            e.Graphics.DrawString("27", textFont, blueBrush, 158.4F, 102.1F, StringFormat.GenericTypographic);
        }

        #region 鼠标拖拽窗体移动
        private Point formerPoint;

        private void sTpFly_MouseDown(object sender, MouseEventArgs e)
        {
            formerPoint = Cursor.Position;
        }

        private void sTpFly_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - formerPoint.X;
                int py = Cursor.Position.Y - formerPoint.Y;
                this.Location = new Point(this.Location.X + px, this.Location.Y + py);
                formerPoint = Cursor.Position;
            }
        }
        #endregion

    }
}
