using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSB.MainUI.Controls
{
    public partial class FlyFilterDataGrid : UserControl
    {
        public FlyFilterDataGrid()
        {
            InitializeComponent();
        }

        private void FlyFilterDataGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Green, 1);
            Pen penBorder = new Pen(Color.FromArgb(204, 204, 204), 1);
            SolidBrush brushBackground1 = new SolidBrush(Color.FromArgb(250, 250, 250));
            SolidBrush brushBackground2 = new SolidBrush(Color.FromArgb(255, 255, 255));

            SolidBrush brushStringTitle = new SolidBrush(Color.FromArgb(74, 74, 103));
            Font fo = new Font("雅黑", 9);
            StringFormat format = new StringFormat();


            g.FillRectangle(brushBackground1, 0, 0, 308, 44);
            g.FillRectangle(brushBackground2, 0, 44, 308, 43);
            g.FillRectangle(brushBackground1, 0, 87, 308, 43);
            g.FillRectangle(brushBackground2, 0, 130, 308, 43);
            g.FillRectangle(brushBackground1, 0, 173, 308, 46);

            g.DrawString("飞机编号", fo, brushStringTitle, 9, 15, format);
            g.DrawString("飞行计划", fo, brushStringTitle, 85, 15, format);
            g.DrawString("FID", fo, brushStringTitle, 173, 15, format);
            g.DrawString("告警信息", fo, brushStringTitle, 234, 15, format);

            g.DrawRectangle(penBorder, 0, 0, 306, 219);

            g.DrawLine(penBorder, 0, 44, 307, 44);
            g.DrawLine(penBorder, 0, 87, 307, 87);
            g.DrawLine(penBorder, 0, 130, 307, 130);
            g.DrawLine(penBorder, 0, 173, 307, 173);

            g.DrawLine(penBorder, 71, 0, 71, 219);
            g.DrawLine(penBorder, 149, 0, 149, 219);
            g.DrawLine(penBorder, 215, 0, 215, 219);

            SolidBrush brushStringFlyNo = new SolidBrush(Color.FromArgb(29, 104, 190));
            SolidBrush brushStringContent = new SolidBrush(Color.FromArgb(74, 74, 103));
            //Font fotext = new Font("雅黑", 9);
            //StringFormat formattext = new StringFormat();

            g.DrawString("71bf95", fo, brushStringFlyNo, 15, 59, format); g.DrawString("0", fo, brushStringContent, 104, 59, format);
            g.DrawString("780b7d", fo, brushStringFlyNo, 12, 102, format); g.DrawString("0", fo, brushStringContent, 104, 102, format);
            g.DrawString("78048b", fo, brushStringFlyNo, 12, 145, format); g.DrawString("0", fo, brushStringContent, 104, 145, format);
            g.DrawString("780939", fo, brushStringFlyNo, 12, 188, format); g.DrawString("0", fo, brushStringContent, 104, 188, format);

        }
    }
}
