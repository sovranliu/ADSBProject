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
        private void sPnl_funcmore_Paint(object sender, PaintEventArgs e)
        {
            //消除锯齿
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //绘制圆底盘
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.FillEllipse(brush, 0, 0, 59, 59);

            //绘制文字
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 0, 0x5D, 0xC9));
            Font textFont = new Font("微软雅黑", 32, FontStyle.Bold, GraphicsUnit.Document);
            e.Graphics.DrawString("更多", textFont, textBrush, 18, 36);

        }

        #region 各个按钮菜单点击功能
        //模式按钮
        private void sLabel_Mode_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_setup2();
                test.Location = new Point(this.Location.X + 515, this.Location.Y + 160);
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //设置按钮
        private void sLabel_Set1_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"设置\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_setup1();
                test.Location = new Point(this.Location.X + 515, this.Location.Y + 160);
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //飞行器过滤按钮
        private void sLabel_flyFilter_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"飞行器过滤\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_flyFilter();
                test.Location = new Point(this.Location.X + 515, this.Location.Y + 160);
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }
        //报警按钮
        private void sLabel_alarm_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"告警\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_alarm();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //工具按钮
        private void sLabel_Tool_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"工具\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_mapTool();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //更多按钮
        private void sPnl_funcmore_click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"更多\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_earthStation();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //地面站
        private void sPnl_dimianzhan_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"地面站\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_dimianzhan();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //导航管理按钮
        private void sLabel_guideManagement_Click(object sender, EventArgs e)
        {

        }

        //飞行计划按钮
        private void sPnl_flyPlan_click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"飞行计划\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_guideResourceAdd();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //启动回放蒙版按钮
        private void sPnl_playback_click(object sender, EventArgs e)
        {
            //log.Writelogs("点击了\"回放\"按钮");
            if (IsPlayback)
            {
                IsPlayback = false;
                panelEx1.Visible = false;
                maskPlaybackSetup.Visible = false;
                maskPlaybackRun.Visible = false;
                skinProgressBar1.Visible = false;
                timerSPBarPlayback.Enabled = false;
            }
            else   //显示回放框
            {
                IsPlayback = true;
                panelEx1.Visible = true;
                panelEx1.BackColor = Color.FromArgb(115, 0, 0, 0);
                maskPlaybackSetup.Visible = true;
                maskPlaybackRun.Visible = true;
                skinProgressBar1.Visible = true;
            }
        }

        //回放启动按钮
        private void maskPlaybackRun_Click(object sender, EventArgs e)
        {
            //点击了“开始回放”按钮
            //MessageBox.Show("开始回放！");
            timerSPBarPlayback.Enabled = true;
            timerSPBarPlayback.Interval = 100;
            skinProgressBar1.Value = 0;

        }

        //回放设置按钮
        private void maskPlaybackSetup_Click(object sender, EventArgs e)
        {
            //显示地图蒙版
            mapmask.Location = new Point(0, 0);
            mapmask.Size = new Size(1280, 752);
            mapmask.Visible = true;

            Form test = new Form_playback();  //回放设置
            test.ShowDialog();

            //恢复回放蒙版
            mapmask.Visible = false;
            panelEx1.Location = new Point(0, 642);
            panelEx1.Size = new Size(1280, 110);
            panelEx1.Visible = true;
            panelEx1.BackColor = Color.FromArgb(115, 0, 0, 0);
        }
        #endregion

        //飞行监控模式下显示弹窗蒙版
        private void ShowMaskLayerWindow()
        {
            if (!IsPlayback)
            {
                mapmask.Location = new Point(0, 0);
                mapmask.Size = new Size(1280, 752);
                mapmask.BackColor = Color.FromArgb(115, 0, 0, 0);
                mapmask.Visible = true;
            }
        }

        //绘制回放蒙版及按钮菜单
        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {
            //该处绘制不容易添加的控件

            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Font textFont = new Font("微软雅黑", 42, FontStyle.Regular, GraphicsUnit.Document);
            e.Graphics.DrawString("回放设置", textFont, textBrush, 31, 43);
        }

        //来调试回放进度条
        private void timerSPBarPlayback_Tick(object sender, EventArgs e)
        {
            int temp;
            temp = skinProgressBar1.Value + 1;
            if (temp > 100) temp = 0;
            skinProgressBar1.Value = temp;

        }
    }
}
