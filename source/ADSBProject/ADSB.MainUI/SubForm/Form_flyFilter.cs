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
    public partial class Form_flyFilter : Form_aTemplate
    {
        private Timer flyFilterTimer = new Timer();
        public Form_flyFilter()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            initPlaneFollow();
            flyFilterTimer.Tick += new EventHandler(flyFilterTimer_Tick);
        }

        private String queryPre = "";
        private void flyFilterTimer_Tick(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM Plane");
            if (this.skinTextBox1.Text.Equals(""))
            {
                foreach (Dictionary<string, object> dictionary in result)
                {
                    String flightNo = Convert.ToString(dictionary["FlightNo"]);
                    String flightPlan = Convert.ToString(dictionary["FlightPlan"]);
                    String sModeAddress = Convert.ToString(dictionary["SModeAddress"]);
                    Plane_Follow plane_Follow = new Plane_Follow(flightNo, flightPlan, sModeAddress);
                    IEnumerable<DataGridViewRow> enumerableList = this.dGridFlyFilter.Rows.Cast<DataGridViewRow>();
                    List<DataGridViewRow> list = (from item in enumerableList
                                                  where item.Cells[0].Value.ToString().IndexOf(plane_Follow.FlightNo) >= 0
                                                  select item).ToList();
                    if (list.Count <= 0)
                    {
                        dGridFlyFilter.Rows.Add(plane_Follow.FlightNo, "0", plane_Follow.SModeAddress, " ");
                    }
                }
            }
            else
            {
                String queryNow = this.skinTextBox1.Text.Trim();
                if (queryPre.Equals(queryNow))
                {
                    return;
                }
                queryPre = queryNow;
                int i = 0;
                while (i >= 0)
                {
                    i = dGridFlyFilter.RowCount - 1;
                    dGridFlyFilter.Rows.Remove(dGridFlyFilter.Rows[i]);
                    i--;
                }

                List<Dictionary<string, object>> resultSel = ProfileHelper.Instance.Select
                ("SELECT * FROM Plane WHERE FlightNo like '%" + queryNow + "%' " +
                "or FlightPlan like '%" + queryNow + "%' or SModeAddress like '%" + queryNow + "%'");

                foreach (Dictionary<string, object> dictionary in resultSel)
                {
                    String flightNo = Convert.ToString(dictionary["FlightNo"]);
                    String flightPlan = Convert.ToString(dictionary["FlightPlan"]);
                    String sModeAddress = Convert.ToString(dictionary["SModeAddress"]);
                    Plane_Follow plane_Follow = new Plane_Follow(flightNo, flightPlan, sModeAddress);

                    IEnumerable<DataGridViewRow> enumerableList = this.dGridFlyFilter.Rows.Cast<DataGridViewRow>();
                    List<DataGridViewRow> list = (from item in enumerableList
                                                  where item.Cells[0].Value.ToString().IndexOf(plane_Follow.FlightNo) >= 0
                                                  select item).ToList();
                    if (list.Count <= 0)
                    {
                        dGridFlyFilter.Rows.Add(plane_Follow.FlightNo, "0", plane_Follow.SModeAddress, " ");
                    }
                }
            }
            this.skinLabel2.Text = "飞行器" + result.Count().ToString();
            
        }

        /**
            * 从数据库中获取保存历史
            * */
        private void initPlaneFollow()
        {
            
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

        private void Form_flyFilter_Load(object sender, EventArgs e)
        {
            this.dGridFlyFilter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dGridFlyFilter.RowTemplate.Height = 43;
            flyFilterTimer.Interval = 2;
            flyFilterTimer.Start();
            //dGridFlyFilter.Rows.Add("71bf95", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("780b7d", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("78048b", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("780939", "0", " ", " ");
        }

        public class Plane_Follow
        {
            private String flightNo;
            public String FlightNo
            {
                get { return flightNo; }
                set { flightNo = value; }
            }

            private String flightPlan;
            public String FlightPlan
            {
                get { return flightPlan; }
                set { flightPlan = value; }
            }

            private String sModeAddress;
            public String SModeAddress
            {
                get { return sModeAddress; }
                set { sModeAddress = value; }
            }

            public Plane_Follow(String flightNo, String flightPlan, String sModeAddress)
            {
                this.flightNo = flightNo;
                this.flightPlan = flightPlan;
                this.sModeAddress = sModeAddress;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private int beforeMatchedRowIndex = 0;

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (this.skinTextBox1.Text.Equals(""))
        //    {
        //        return;
        //    }

        //    // Linq模糊查询
        //    IEnumerable<DataGridViewRow> enumerableList = this.dGridFlyFilter.Rows.Cast<DataGridViewRow>();
        //    List<DataGridViewRow> list = (from item in enumerableList
        //                                  where item.Cells[0].Value.ToString().IndexOf(this.skinTextBox1.Text) >= 0
        //                                  select item).ToList();

        //    // 恢复之前行的背景颜色为默认的白色背景
        //    this.dGridFlyFilter.Rows[beforeMatchedRowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White;

        //    if (list.Count > 0)
        //    {
        //        // 查找匹配行高亮显示
        //        int matchedRowIndex = list[0].Index;
        //        this.dGridFlyFilter.Rows[matchedRowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
        //        this.beforeMatchedRowIndex = matchedRowIndex;
        //    }
        //}
    }
}
