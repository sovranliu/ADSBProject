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
    public partial class AlarmDataGrid : UserControl
    {
        public AlarmDataGrid()
        {
            InitializeComponent();
        }

        private void AlarmDataGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Green, 1);
            Pen penBorder = new Pen(Color.FromArgb(204, 204, 204), 1);
            SolidBrush brushBackground1 = new SolidBrush(Color.FromArgb(250, 250, 250));
            SolidBrush brushBackground2 = new SolidBrush(Color.FromArgb(255, 255, 255));

            SolidBrush brushString = new SolidBrush(Color.FromArgb(0, 0, 0));
            Font fo = new Font("雅黑", 9);
            StringFormat format = new StringFormat();


            g.FillRectangle(brushBackground1, 0, 0, 308, 44);
            g.FillRectangle(brushBackground2, 0, 44, 308, 43);
            g.FillRectangle(brushBackground1, 0, 87, 308, 43);
            g.FillRectangle(brushBackground2, 0, 130, 308, 43);
            g.FillRectangle(brushBackground1, 0, 173, 308, 46);

            g.DrawString("时间", fo, brushString, 26, 15, format);
            g.DrawString("对象", fo, brushString, 86, 15, format);
            g.DrawString("类型", fo, brushString, 148, 15, format);
            g.DrawString("级别", fo, brushString, 208, 15, format);
            g.DrawString("信息", fo, brushString, 264, 15, format);
            //画外框
            g.DrawRectangle(penBorder, 0, 0, 306, 219);
            //画横线
            g.DrawLine(penBorder, 0, 44, 307, 44);
            g.DrawLine(penBorder, 0, 87, 307, 87);
            g.DrawLine(penBorder, 0, 130, 307, 130);
            g.DrawLine(penBorder, 0, 173, 307, 173);
            //画竖线
            g.DrawLine(penBorder, 72, 0, 72, 219);
            g.DrawLine(penBorder, 130, 0, 130, 219);
            g.DrawLine(penBorder, 194, 0, 194, 219);
            g.DrawLine(penBorder, 252, 0, 252, 219);
        }
    }
}
