using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            flyFilterTimer.Tick += new EventHandler(flyFilterTimer_Tick);
        }

        private void flyFilterTimer_Tick(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM Plane");
            String querySModeAddress = this.skinTextBox1.Text.Trim();
            if (!IsNumber(querySModeAddress))
            {
                return;
            }
            String queryFlightNo = this.skinTextBox2.Text.Trim();
            String queryAirSpeedDown = this.skinTextBox3.Text.Trim();
            if (!IsNumber(queryAirSpeedDown))
            {
                return;
            }
            String queryAirSpeedUp = this.skinTextBox4.Text.Trim();
            if (!IsNumber(queryAirSpeedUp))
            {
                return;
            }
            String queryGeometricAltitudeDown = this.skinTextBox5.Text.Trim();
            if (!IsNumber(queryGeometricAltitudeDown))
            {
                return;
            }
            String queryGeometricAltitudeUp = this.skinTextBox6.Text.Trim();
            if (!IsNumber(queryGeometricAltitudeUp))
            {
                return;
            }

            String condtion = " 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(querySModeAddress))
            {
                condtion += " AND SModeAddress = " + querySModeAddress.ToString();
            }
            if (!string.IsNullOrWhiteSpace(queryFlightNo))
            {
                condtion += " AND FlightNo = '" + queryFlightNo + "'";
            }
            if (!string.IsNullOrWhiteSpace(queryAirSpeedDown))
            {
                condtion += " AND AirSpeed >= " + queryAirSpeedDown.ToString();
            }
            if (!string.IsNullOrWhiteSpace(queryAirSpeedUp))
            {
                condtion += " AND AirSpeed <= " + queryAirSpeedUp.ToString();
            }
            if (!string.IsNullOrWhiteSpace(queryGeometricAltitudeDown))
            {
                condtion += " AND GeometricAltitude >= " + queryGeometricAltitudeDown.ToString();
            }
            if (!string.IsNullOrWhiteSpace(queryGeometricAltitudeUp))
            {
                condtion += " AND GeometricAltitude <= " + queryGeometricAltitudeUp.ToString();
            }

            if (condtion.Equals(" 1 = 1 "))
            {
                showGrid(result);
            }
            else
            {
                List<Dictionary<string, object>> resultSel = ProfileHelper.Instance.Select
                ("SELECT * FROM Plane WHERE " + condtion);

                showGrid(resultSel);
            }
            this.skinLabel2.Text = "飞行器" + result.Count().ToString();
        }

        /// <summary>
        /// 判断字符串是否是数字
        /// </summary>
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;
            try
            {
                double a = Convert.ToDouble(s);//如果成功就是小数
                return true;
            }
            catch
            {
                //不成功，不是小数
                return false;
            }
        }

        private void showGrid(List<Dictionary<string, object>> resultSel)
        {
            int i = 0;
            while (i >= 0)
            {
                i = dGridFlyFilter.RowCount - 1;
                if (i >= 0)
                    dGridFlyFilter.Rows.Remove(dGridFlyFilter.Rows[i]);
                i--;
            }

            foreach (Dictionary<string, object> dictionary in resultSel)
            {
                Plane_Follow plane_Follow = getPlaneFollow(dictionary);

                IEnumerable<DataGridViewRow> enumerableList = this.dGridFlyFilter.Rows.Cast<DataGridViewRow>();
                List<DataGridViewRow> list = (from item in enumerableList
                                              where item.Cells[0].Value.ToString().IndexOf(plane_Follow.FlightNo) >= 0
                                              select item).ToList();
                if (list.Count <= 0)
                {
                    dGridFlyFilter.Rows.Add(
                        plane_Follow.SModeAddress,
                        plane_Follow.FlightNo,
                        plane_Follow.Latitude,
                        plane_Follow.Longtitude,
                        plane_Follow.ElapsedTime,
                        plane_Follow.GeometricAltitude,
                        plane_Follow.BarometricAltitude,
                        plane_Follow.AirSpeed,
                        plane_Follow.AirSpeedUnit,
                        plane_Follow.AircraftAngle,
                        plane_Follow.GroundSpeed,
                        plane_Follow.EmitterCategory);
                }
            }
        }

        private Plane_Follow getPlaneFollow(Dictionary<string, object> dictionary)
        {
            int sModeAddress = Convert.ToInt32(dictionary["SModeAddress"]);
            String flightNo = Convert.ToString(dictionary["FlightNo"]);
            double latitude = Convert.ToDouble(dictionary["Latitude"]);
            double longtitude = Convert.ToDouble(dictionary["Longtitude"]);
            double elapsedTime = Convert.ToDouble(dictionary["ElapsedTime"]);
            double geometricAltitude = Convert.ToDouble(dictionary["GeometricAltitude"]);
            double barometricAltitude = Convert.ToDouble(dictionary["BarometricAltitude"]);
            double airSpeed = Convert.ToDouble(dictionary["AirSpeed"]);
            int airSpeedUnit = Convert.ToInt16(dictionary["AirSpeedUnit"]);
            double aircraftAngle = Convert.ToDouble(dictionary["AircraftAngle"]);
            double groundSpeed = Convert.ToDouble(dictionary["GroundSpeed"]);
            int emitterCategory = Convert.ToInt16(dictionary["EmitterCategory"]);
            Plane_Follow plane_Follow = new Plane_Follow(
                sModeAddress,
                flightNo, 
                latitude, 
                longtitude,
                elapsedTime,
                geometricAltitude,
                barometricAltitude,
                airSpeed,
                airSpeedUnit,
                aircraftAngle,
                groundSpeed,
                emitterCategory
                );
            return plane_Follow;
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_flyFilter_Load(object sender, EventArgs e)
        {
            this.dGridFlyFilter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dGridFlyFilter.RowTemplate.Height = 43;
            flyFilterTimer.Interval = 1000;
            flyFilterTimer.Start();
        }

        public class Plane_Follow
        {
            private int sModeAddress;
            public int SModeAddress
            {
                get { return sModeAddress; }
                set { sModeAddress = value; }
            }
            private String flightNo;
            public String FlightNo
            {
                get { return flightNo; }
                set { flightNo = value; }
            }
            private double latitude;
            public double Latitude
            {
                get { return latitude; }
                set { latitude = value; }
            }
            private double longtitude;
            public double Longtitude
            {
                get { return longtitude; }
                set { longtitude = value; }
            }
            private double elapsedTime;
            public double ElapsedTime
            {
                get { return elapsedTime; }
                set { elapsedTime = value; }
            }
            private double geometricAltitude;
            public double GeometricAltitude
            {
                get { return geometricAltitude; }
                set { geometricAltitude = value; }
            }
            private double barometricAltitude;
            public double BarometricAltitude
            {
                get { return barometricAltitude; }
                set { barometricAltitude = value; }
            }
            private double airSpeed;
            public double AirSpeed
            {
                get { return airSpeed; }
                set { airSpeed = value; }
            }
            private int airSpeedUnit;
            public int AirSpeedUnit
            {
                get { return airSpeedUnit; }
                set { airSpeedUnit = value; }
            }
            private double aircraftAngle;
            public double AircraftAngle
            {
                get { return aircraftAngle; }
                set { aircraftAngle = value; }
            }
            private double groundSpeed;
            public double GroundSpeed
            {
                get { return groundSpeed; }
                set { groundSpeed = value; }
            }
            private int emitterCategory;
            public int EmitterCategory
            {
                get { return emitterCategory; }
                set { emitterCategory = value; }
            }

            public Plane_Follow(
                int sModeAddress,
                String flightNo,
                double latitude,
                double longtitude,
                double elapsedTime,
                double geometricAltitude,
                double barometricAltitude,
                double airSpeed,
                int airSpeedUnit,
                double aircraftAngle,
                double groundSpeed,
                int emitterCategory)
            {
                this.sModeAddress = sModeAddress;
                this.flightNo = flightNo;
                this.latitude = latitude;
                this.longtitude = longtitude;
                this.elapsedTime = elapsedTime;
                this.geometricAltitude = geometricAltitude;
                this.barometricAltitude = barometricAltitude;
                this.airSpeed = airSpeed;
                this.airSpeedUnit = airSpeedUnit;
                this.aircraftAngle = aircraftAngle;
                this.groundSpeed = groundSpeed;
                this.emitterCategory = emitterCategory;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (skinTextBox1.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(skinTextBox1.Text, out oldf);
                    b2 = float.TryParse(skinTextBox1.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
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
