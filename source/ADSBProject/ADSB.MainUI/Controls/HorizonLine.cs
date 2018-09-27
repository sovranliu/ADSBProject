using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ADSB.MainUI.Controls
{
    public partial class HorizonLine : UserControl
    {
        int lineWidth = 1;
        int lineLength = 217;
        int dashLength = 5;
        Color controlBackgroundColor = Color.FromArgb(216, 216, 216);
        Color dashColor = Color.FromArgb(151, 151, 151);


        public int LineWidth
        {
            get { return lineWidth; }
            set { lineWidth = value; }
        }

        public int LineLength
        {
            get { return lineLength; }
            set { lineLength = value; }
        }

        public int LineDashLength
        {
            get { return dashLength; }
            set { dashLength = value; }
        }

        public Color LineBackgroundColor
        {
            get { return controlBackgroundColor; }
            set { controlBackgroundColor = value; }
        }

        public Color LineDashColor
        {
            get { return dashColor; }
            set { dashColor = value; }
        }

        public HorizonLine()
        {
            InitializeComponent();
        }

        private void HorizonLine_Paint(object sender, PaintEventArgs e)
        {
            //初始化控件窗口
            this.Width = lineLength + 2;
            this.Height = lineWidth + 2;
            this.BackColor = controlBackgroundColor;

            Graphics g = this.CreateGraphics();

            g.Clear(Color.White);

            Pen p = new Pen(dashColor, lineWidth);

            ////设置画笔线型  
            p.DashStyle = DashStyle.Dash;

            //使用自定义线型  
            float[] dashArray = {
                                  dashLength,  //线长dashLength个像素  
                                  dashLength-2,  //间断dashLength个像素  
                                 };

            p.DashPattern = dashArray;
            g.DrawLine(p, 1, 1, 1 + lineLength, 1);

            //释放资源  
            p.Dispose();
            g.Dispose();
        }
    }
}
