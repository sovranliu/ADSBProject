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

    public partial class Form_wayPoint : Form_aTemplate
    {
        public delegate void wayPoint(Boolean selected, int flag);
        public event wayPoint wayPoint_event;

        private GMapOverlay portSelOverlay = new GMapOverlay("portSelLayer"); //鼠标点击图层
        private GMapOverlay portOverlay = new GMapOverlay("porteLayer"); //已有的展示图层

        public Form_wayPoint()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Way_Point> wayPointList = new List<Way_Point>();

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

            showAllWayPoint();
            
        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
            showWayPoint(portSelOverlay, point.Lat, point.Lng, "选中的点");
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String name = skinTextBox2.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请输入机场名称！");
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

            Way_Point way_Point = new Way_Point(name, Convert.ToDouble(skinTextBox3.Text), Convert.ToDouble(skinTextBox4.Text));
            // 插入数据库
            ProfileHelper.Instance.Update("INSERT INTO WayPoint (Name, Lat, Lng) VALUES ('" + way_Point.Name + "', " + way_Point.Lat + ", " + way_Point.Lng + ")");
            showAllWayPoint();

            wayPoint_event(true, 2);
        }

        /*
         * 删除选中的行
         * */
        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM WayPoint WHERE Name = \"" + name + "\"");
            showAllWayPoint();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获得本行name
            double lat = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());//获得本行经度
            double lang = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());//获得本行纬度
            showWayPoint(portOverlay, lat, lang, name);
        }

        private void showWayPoint(GMapOverlay overlay, double lat, double lang, String name)
        {
            overlay.Markers.Clear();
            PointLatLng point1 = new PointLatLng(lat, lang);
            GMapWayPoint wayPoint = new GMapWayPoint(point1, name);
            overlay.Markers.Add(wayPoint);
            gMapControl1.Refresh();
        }

        /**
         * 从数据库里面查出所有的数据，展示。
         * */
        private void showAllWayPoint()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM WayPoint");
            wayPointList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                double lat = Convert.ToDouble(dictionary["Lat"]);
                double lang = Convert.ToDouble(dictionary["Lng"]);
                Way_Point way_Point = new Way_Point(name, lat, lang);
                wayPointList.Add(way_Point);
            }

            this.dataGridView1.DataSource = null;
            if (null != wayPointList && wayPointList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.wayPointList;
            }

        }
    }

    public class Way_Point
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
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

        public Way_Point(String name, double lat, double lng)
        {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
        }
    }
}
