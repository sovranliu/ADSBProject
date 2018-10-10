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

    public partial class Form_airPort : Form_aTemplate
    {
        public delegate void airPort(Boolean selected, int flag);
        public event airPort airPort_event;

        private GMapOverlay portSelOverlay = new GMapOverlay("portSelLayer"); //鼠标点击图层
        private GMapOverlay portOverlay = new GMapOverlay("porteLayer"); //机场已有的展示图层

        public Form_airPort()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Air_Port> airPortList = new List<Air_Port>();

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

            showAllAirPort();
            
        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            skinButton1.Text = "新增";
            skinLabel2.Text = "ID";
            skinTextBox2.Text = "";
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
            showAirPort(portSelOverlay, point.Lat, point.Lng, "选中的点", 0, 0);
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
            if (null == skinTextBox1.Text || skinTextBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入环数！");
                return;
            }
            if (null == skinTextBox5.Text || skinTextBox5.Text.Length == 0)
            {
                MessageBox.Show("请输入环距离！");
                return;
            }

            Air_Port air_Port = new Air_Port(
                0, 
                name,
                Convert.ToDouble(skinTextBox3.Text),
                Convert.ToDouble(skinTextBox4.Text),
                Convert.ToInt16(skinTextBox1.Text),
                Convert.ToDouble(skinTextBox5.Text));
            if (skinLabel2.Text.Equals("ID"))
            {
                // 插入数据库
                ProfileHelper.Instance.Update("INSERT INTO AirPort (ID, Name, Lat, Lng, Num, Length) VALUES (NULL, '" +
                    air_Port.Name + "', " + 
                    air_Port.Lat + ", " + 
                    air_Port.Lng + ", " +
                    air_Port.Num + ", " + 
                    air_Port.Length + ")");
            }
            else if (!string.IsNullOrWhiteSpace(skinLabel2.Text))
            {
                // 更新数据库
                ProfileHelper.Instance.Update(
                   "UPDATE AirPort set " +
                        " Name = '" + air_Port.Name + "', " +
                        " Lat = " + air_Port.Lat + ", " +
                        " Lng = " + air_Port.Lng  +
                        " Num = " + air_Port.Num + ", " +
                        " Length = " + air_Port.Length +
                        " where ID = '" + skinLabel2.Text + "'");
            }
            showAllAirPort();

            airPort_event(true, 2);
        }

        /*
         * 删除选中的行
         * */
        private void skinButton2_Click(object sender, EventArgs e)
        {
            String id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM AirPort WHERE ID = \"" + id + "\"");
            showAllAirPort();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//获得本行name
            double lat = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());//获得本行经度
            double lang = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());//获得本行纬度
            int num = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());//获得本行环数
            double length = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());//获得本行环距
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());//获得本行ID

            skinButton1.Text = "更新";
            showLable(id, lat, lang, name, num, length);
            showAirPort(portOverlay, lat, lang, name, num, length);
        }

        private void showLable(int id, double lat, double lang, String name, int num, double length)
        {
            skinTextBox2.Text = name;
            skinTextBox3.Text = lat.ToString();
            skinTextBox4.Text = lang.ToString();
            skinTextBox1.Text = num.ToString();
            skinTextBox5.Text = length.ToString();

            skinLabel2.Text = id.ToString();
        }

        private void showAirPort(GMapOverlay overlay, double lat, double lang, String name, int num, double length)
        {
            overlay.Markers.Clear();
            PointLatLng point1 = new PointLatLng(lat, lang);
            GMapAirPort airPort = new GMapAirPort(point1, name);

            while (num > 0)
            {
                GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point1, (int)length * num);
                overlay.Markers.Add(gMapMarkerCircle);
                num--;
            }

            overlay.Markers.Add(airPort);
            gMapControl1.Refresh();
        }

        /**
         * 从数据库里面查出所有的数据，展示。
         * */
        private void showAllAirPort()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirPort");
            airPortList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                double lat = Convert.ToDouble(dictionary["Lat"]);
                double lang = Convert.ToDouble(dictionary["Lng"]);
                int id = Convert.ToInt32(dictionary["ID"]);
                double length = Convert.ToDouble(dictionary["Length"]);
                int num = Convert.ToInt16(dictionary["Num"]);
                Air_Port air_Port = new Air_Port(id, name, lat, lang, num, length);
                airPortList.Add(air_Port);
            }

            this.dataGridView1.DataSource = null;
            if (null != airPortList && airPortList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airPortList;
            }

        }
    }



    public class Air_Port
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
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

        public Air_Port(int id, String name, double lat, double lng, int num, double length)
        {
            this.id = id;
            this.name = name;
            this.lat = lat;
            this.lng = lng;
            this.num = num;
            this.length = length;
        }
    }
}
