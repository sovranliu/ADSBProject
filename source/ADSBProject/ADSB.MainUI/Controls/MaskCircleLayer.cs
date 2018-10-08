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
    public partial class MaskCircleLayer : UserControl
    {
        private int alpha, transparency = 45;

        public MaskCircleLayer()
        {
            alpha = 125;
            SetStyle(System.Windows.Forms.ControlStyles.Opaque, true);
            base.CreateControl();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            alpha = 255 - (transparency * 255) / 100;
            Color color = Color.FromArgb(alpha, this.BackColor);
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillEllipse(brush, 0, 0, this.Size.Width, this.Size.Height);
            }
            if (!this.DesignMode)
            {
                using (Pen pen = new Pen(color))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
                }
            }
            else
                e.Graphics.DrawRectangle(Pens.Black, 1, 1, this.Width - 2, this.Height - 2);
            if(null != this.BackgroundImage)
            {
                e.Graphics.DrawImage(this.BackgroundImage, new PointF(0, 0));
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        public int Transparency
        {
            get
            {
                return transparency;
            }
            set
            {
                if (value < 0) transparency = 0;
                else if (value > 100) transparency = 100;
                else transparency = value;
                this.Invalidate();
            }
        }
    }
}
