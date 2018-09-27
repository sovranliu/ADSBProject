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

namespace ADSB.MainUI.SubForm
{
    public partial class Form_alarm : Form_aTemplate
    {
        public Form_alarm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinPanel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        }

        private void Form_alarm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 43;
            dataGridView1.Rows.Add("1", "12","13","14","15");
            dataGridView1.Rows.Add("2", "12", "13", "14", "15");
            dataGridView1.Rows.Add("3", "12", "13", "14", "15");
            dataGridView1.Rows.Add("4", "12", "13", "14", "15");

        }

    }
}
