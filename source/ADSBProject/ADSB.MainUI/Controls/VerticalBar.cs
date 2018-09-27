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
    public partial class VerticalBar : UserControl
    {
        Color backgroundColor = Color.FromArgb(216, 216, 216);
        int lineWidth = 6;
        int lineLength = 149;


        public VerticalBar()
        {
            InitializeComponent();
        }

        //private void myDecorator_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = this.CreateGraphics();

        //    Pen pen = new Pen(backgroundColor, lineWidth);

        //    pen.StartCap = LineCap.Round;
        //    pen.EndCap = LineCap.Round;

        //    g.DrawLine(pen, 20, 20, 20, 20 + lineLength);
        //    //g.DrawLine(pen, 5, 10, 5 + lineLength, 10);
        //    pen.Dispose();
        //    g.Dispose();
        //}

        private void VerticalBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(backgroundColor, lineWidth);

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            g.DrawLine(pen, 2, 2, 2, 2 + lineLength);
            //g.DrawLine(pen, 5, 10, 5 + lineLength, 10);
            pen.Dispose();
            g.Dispose();
        }
    }
}
