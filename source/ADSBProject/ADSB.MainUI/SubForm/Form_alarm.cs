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
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM Alarm order by Status");
            foreach (Dictionary<string, object> dictionary in result)
            {
                String flightNo = Convert.ToString(dictionary["FlightNo"]);
                int sModeAddress = Convert.ToInt32(dictionary["SModeAddress"]);
                String sModeAddressTo = Convert.ToString(dictionary["SModeAddressTo"]);
                String info = Convert.ToString(dictionary["Info"]);
                String writeTime = Convert.ToString(dictionary["WriteTime"]);
                String status = Convert.ToString(dictionary["Status"]).Equals("0") ? "告警中" : "历史告警";
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = flightNo;
                this.dataGridView1.Rows[index].Cells[1].Value = sModeAddress.ToString();
                this.dataGridView1.Rows[index].Cells[2].Value = sModeAddressTo.ToString();
                this.dataGridView1.Rows[index].Cells[3].Value = info;
                this.dataGridView1.Rows[index].Cells[4].Value = writeTime;
                this.dataGridView1.Rows[index].Cells[5].Value = status;
                //if (!"0".Equals(status))
                //{
                //    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Brown;
                //}
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
