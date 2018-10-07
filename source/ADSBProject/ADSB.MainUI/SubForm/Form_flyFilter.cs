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
        private Dictionary<String, GMapAirPlane> listAirplane;
        public Form_flyFilter()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

        }

        public class FlyChangedEventArgs : EventArgs // 事件参数类
        {
            private Dictionary<String, GMapAirPlane> listAirplane;
            public Dictionary<String, GMapAirPlane> ListAirplane
            {
                get { return listAirplane; }
                set { listAirplane = value; }
            }
        }
        // 声明委托
        public delegate void FlyChangedEventHandler(object sender, FlyChangedEventArgs e);
        // 定义事件
        public event FlyChangedEventHandler FlyChanged;

        // 触发事件的方法
        protected virtual void OnFlyChanged(FlyChangedEventArgs e)
        {
            if (FlyChanged != null)
                FlyChanged(this, e);

            foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
            {
                AirplaneInfo airPlaneInfo = eachlistAirplane.AirPlaneMarkerInfo;
                dGridFlyFilter.Rows.Add(airPlaneInfo.fid, airPlaneInfo.gv, airPlaneInfo.height, airPlaneInfo.speed);
            }
            this.skinLabel2.Text = "飞行器：" + listAirplane.Count.ToString();
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
            //dGridFlyFilter.Rows.Add("71bf95", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("780b7d", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("78048b", "0", " ", " ");
            //dGridFlyFilter.Rows.Add("780939", "0", " ", " ");
        }
    }
}
