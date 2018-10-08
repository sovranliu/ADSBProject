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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace ADSB.MainUI.SubForm
{

    public partial class Form_landStation : Form_aTemplate
    {
        public delegate void landStation(Boolean selected, int flag);
        public event landStation landStation_event;

        private GMapOverlay portSelOverlay = new GMapOverlay("portSelLayer"); //鼠标点击图层
        private GMapOverlay portOverlay = new GMapOverlay("porteLayer"); //机场已有的展示图层

        public Form_landStation()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Land_Station> landStationList = new List<Land_Station>();

        private void InitializeGMap()
        {
            this.gMapControl1.CacheLocation = System.Windows.Forms.Application.StartupPath;    //缓冲区路径
            this.gMapControl1.MapProvider = GMapProviders.GoogleChinaMap;                      //谷歌中国区地图加载
            this.gMapControl1.Manager.Mode = AccessMode.ServerAndCache;                        //地图模式
            this.gMapControl1.MinZoom = 1;                                                     //最小比例
            this.gMapControl1.MaxZoom = 23;                                                    //最大比例
            this.gMapControl1.Zoom = 10;                                                       //当前比例
            this.gMapControl1.ShowCenter = false;                                              //不显示中心十字点
            this.gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;             //左键拖拽地图
            this.gMapControl1.Position = new PointLatLng(23.16, 113.27);                     //初始化地址 广州(23.16, 113.27) 北京(39.3, 116.5)
            this.gMapControl1.MouseDown += new MouseEventHandler(mapControl_MouseDown);
            this.gMapControl1.Overlays.Add(portOverlay);
            this.gMapControl1.Overlays.Add(portSelOverlay);

            showAllLandStation();
            
        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
            showLandStation(portSelOverlay, point.Lat, point.Lng, "选中的点", 0, 1);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String name = skinTextBox2.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请输入机场名称！");
                return;
            }
            if (null == skinTextBox1.Text || skinTextBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入IP！");
                return;
            }
            if (null == skinTextBox3.Text || skinTextBox3.Text.Length == 0)
            {
                MessageBox.Show("请输入经纬度！");
                return;
            }
            if (null == skinTextBox4.Text || skinTextBox4.Text.Length == 0)
            {
                MessageBox.Show("请输入经纬度！");
                return;
            }
            if (null == skinTextBox5.Text || skinTextBox5.Text.Length == 0)
            {
                MessageBox.Show("请输入环数！");
                return;
            }
            if (null == skinTextBox6.Text || skinTextBox6.Text.Length == 0)
            {
                MessageBox.Show("请输入环距离！");
                return;
            }

            Land_Station land_Station = new Land_Station(
                name,
                Convert.ToString(skinTextBox1.Text),
                Convert.ToDouble(skinTextBox3.Text),
                Convert.ToDouble(skinTextBox4.Text),
                Convert.ToDouble(skinTextBox6.Text),
                Convert.ToInt16(skinTextBox5.Text));
            // 插入数据库
            ProfileHelper.Instance.Update(
                "INSERT INTO LandStation (Name, IP, Lat, Lng, Num, Length) VALUES ('" + 
                land_Station.Name + "', '" + land_Station.IP + "', " + 
                land_Station.Lat + ", " + land_Station.Lng + ", " +
                land_Station.Num + ", " + land_Station.Length +
                ")");
            showAllLandStation();

            landStation_event(true, 2);
        }

        /*
         * 删除选中的行
         * */
        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = this.dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM LandStation WHERE Name = \"" + name + "\"");
            showAllLandStation();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获得本行name
            double lat = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());//获得本行经度
            double lang = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());//获得本行纬度
            int num = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());//获得本行环数
            double length = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());//获得本行环距
            showLandStation(portOverlay, lat, lang, name, num, length);
        }

        private void showLandStation(GMapOverlay overlay, double lat, double lang, String name, int num, double length)
        {
            overlay.Markers.Clear();
            PointLatLng point1 = new PointLatLng(lat, lang);
            GMapLandStation landSatsion = new GMapLandStation(point1, name);
            overlay.Markers.Add(landSatsion);

            while (num > 0)
            {
                GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point1, (int)length * num);
                overlay.Markers.Add(gMapMarkerCircle);
                num--;
            }

            gMapControl1.Refresh();
        }

        /**
         * 从数据库里面查出所有的数据，展示。
         * */
        private void showAllLandStation()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM LandStation");
            landStationList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                String ip = Convert.ToString(dictionary["IP"]);
                double lat = Convert.ToDouble(dictionary["Lat"]);
                double lang = Convert.ToDouble(dictionary["Lng"]);
                double length = Convert.ToDouble(dictionary["Length"]);
                int num = Convert.ToInt16(dictionary["Num"]);
                Land_Station land_Station = new Land_Station(name, ip, lat, lang, length, num);
                landStationList.Add(land_Station);
            }

            this.dataGridView1.DataSource = null;
            if (null != landStationList && landStationList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.landStationList;
            }

        }
    }



    public class Land_Station
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String ip;
        public String IP
        {
            get { return ip; }
            set { ip = value; }
        }

        private double lat;
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        private double lng;
        public double Lng
        {
            get { return lng; }
            set { lng = value; }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public Land_Station(String name, String ip, double lat, double lng, double length, int num)
        {
            this.name = name;
            this.ip = ip;
            this.lat = lat;
            this.lng = lng;
            this.length = length;
            this.num = num;
        }
    }
}
