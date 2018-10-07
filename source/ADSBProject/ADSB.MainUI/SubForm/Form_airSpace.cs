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

    public partial class Form_airSpace : Form_aTemplate
    {
        public delegate void airSpace(Boolean selected, int flag);
        public event airSpace airSpace_event;

        private GMapOverlay portSelOverlay = new GMapOverlay("portSelLayer"); //鼠标点击图层
        private GMapOverlay portOverlay = new GMapOverlay("porteLayer"); //已有的展示图层

        public Form_airSpace()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Air_Space> airSpaceList = new List<Air_Space>();

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

            showAllAirSpace();
            
        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
            showAirSpave(portSelOverlay, point.Lat, point.Lng, "选中的点");
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            // 圆形
            if (radioButton2.Checked)
            {
                doCircular();
            }
            // 多边形
            else if (radioButton1.Checked)
            {
                doPolygon();
            }
            else
            {
                MessageBox.Show("请选择空域类型！");
                return;
            }
                
        }

        private void doCircular()
        {
            String name = skinTextBox2.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请输入空域名称！");
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
            if (null == skinTextBox1.Text || skinTextBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入半径！");
                return;
            }

            Air_Space air_Spacet = new Air_Space(
                name, 
                Convert.ToDouble(skinTextBox3.Text), 
                Convert.ToDouble(skinTextBox4.Text),
                "圆形",
                0,
                Convert.ToDouble(skinTextBox1.Text));
            // 插入数据库
            ProfileHelper.Instance.Update("INSERT INTO AirSpace (Name, Lat, Lng, Type, Id, Radius) " +
                "VALUES ('" + air_Spacet.Name + "', " + air_Spacet.Lat + ", " + air_Spacet.Lng + ", 1, " + air_Spacet.Id + ", " + air_Spacet.Radius + ")");

            showAllAirSpace();
            airSpace_event(true, 2);
        }

        private int id = 1;

        private void doPolygon()
        {
            String name = skinTextBox2.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请输入空域名称！");
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
            

            Air_Space air_Spacet = new Air_Space(
                name,
                Convert.ToDouble(skinTextBox3.Text),
                Convert.ToDouble(skinTextBox4.Text),
                "多边形",
                id,
                0);
            // 插入数据库
            ProfileHelper.Instance.Update("INSERT INTO AirSpace (Name, Lat, Lng, Type, Id, Radius) " +
                "VALUES ('" + air_Spacet.Name + "', " + air_Spacet.Lat + ", " + air_Spacet.Lng + ", 0, " + air_Spacet.Id + ", " + air_Spacet.Radius + ")");

            showAllAirSpace();
            id++;
            skinTextBox1.Text = Convert.ToString(id);
            airSpace_event(true, 2);
        }

        /*
         * 删除选中的行
         * */
        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM AirSpace WHERE Name = \"" + name + "\"");
            showAllAirSpace();
            id = 1;
            skinTextBox1.Text = Convert.ToString(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获得本行name
            showAirSpave(portOverlay, 0, 0, name);
        }

        private void showAirSpave(GMapOverlay overlay, double lat, double lang, String name)
        {
            overlay.Markers.Clear();
            // 展示鼠标点击点
            if (overlay.Equals(portSelOverlay))
            {
                PointLatLng point1 = new PointLatLng(lat, lang);
                GMapAirPort airPort = new GMapAirPort(point1, name);
                overlay.Markers.Add(airPort);
                gMapControl1.Refresh();
                return;
            }
            // 根据name获取要展示的空域信息
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSpace WHERE Name = \"" + name + "\"");

            if (result.Count > 0)
            {
                overlay.Clear();
                int type = Convert.ToInt16(result[0]["Type"]);
                if (1 == type)
                {
                    // 圆形
                    double t = Convert.ToDouble(result[0]["Lat"]);
                    double g = Convert.ToDouble(result[0]["Lng"]);
                    double radius = Convert.ToDouble(result[0]["Radius"]);
                    PointLatLng point = new PointLatLng(t, g);
                    GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point, (int)radius);
                    overlay.Markers.Add(gMapMarkerCircle);
                }
                if (0 == type)
                {
                    // 多边形
                    List<PointLatLng> points = new List<PointLatLng>();
                    foreach (Dictionary<string, object> dictionary in result)
                    {
                        double t = Convert.ToDouble(dictionary["Lat"]);
                        double g = Convert.ToDouble(dictionary["Lng"]);
                        PointLatLng point = new PointLatLng(t, g);
                        points.Add(point);
                    }
                    GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
                    polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    polygon.Stroke = new Pen(Color.Red, 1);
                    overlay.Polygons.Add(polygon);
                }
            }
           
            gMapControl1.Refresh();
        }

        /**
         * 从数据库里面查出所有的数据，展示。
         * */
        private void showAllAirSpace()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSpace");
            airSpaceList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                double lat = Convert.ToDouble(dictionary["Lat"]);
                double lang = Convert.ToDouble(dictionary["Lng"]);
                int type = Convert.ToInt16(dictionary["Type"]);
                int id = Convert.ToInt16(dictionary["Id"]);
                double radius = Convert.ToDouble(dictionary["Radius"]);
                Air_Space air_Space;
                if (0 == type)
                {
                    // 多边形
                    air_Space = new Air_Space(name, lat, lang, "多边形", id, 0);
                }
                else
                {
                    // 圆形
                    air_Space = new Air_Space(name, lat, lang, "圆形", 0, radius);
                }
                 
                airSpaceList.Add(air_Space);
            }

            this.dataGridView1.DataSource = null;
            if (null != airSpaceList && airSpaceList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airSpaceList;
            }

        }
        // 圆形
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            skinButton1.Text = "新增";
            skinLabel2.Text = "半径：";
            skinButton3.Visible = false;
            skinTextBox1.Enabled = true;
        }
        // 多边形
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            skinButton1.Text = "新增点";
            skinLabel2.Text = "序号：";
            skinButton3.Visible = true;
            skinTextBox1.Enabled = false;
            skinTextBox1.Text = Convert.ToString(id);
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            id = 1;
            skinTextBox1.Text = Convert.ToString(id);
            skinTextBox2.Text = null;
        }
    }



    public class Air_Space
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

        private String type;
        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Air_Space(String name, double lat, double lng, String type, int id, double radius)
        {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
            this.type = type;
            this.id = id;
            this.radius = radius;
        }
    }
}
