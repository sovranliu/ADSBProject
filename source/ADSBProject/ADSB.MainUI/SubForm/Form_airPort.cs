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

        private GMapOverlay planeOverlay = new GMapOverlay("planeLayer"); //飞机图层

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

            Air_Port air_Port = new Air_Port(name, Convert.ToDouble(skinTextBox3.Text), Convert.ToDouble(skinTextBox4.Text));
            airPortList.Add(air_Port);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.airPortList;

            // todo 保存到数据库
            ProfileHelper.Instance.Update("INSERT INTO AirPort (Name, Lat, Lng) VALUES ('" + air_Port.Name + "', " + air_Port.Lat + ", " + air_Port.Lng  + ")");

            airPort_event(true, 2);
        }

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

            // TODO 获取地面目标信息，并初始化tableLayoutPanel1
            // tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));

        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //选中的行数
                int iCount = dataGridView1.SelectedRows.Count;
                if (iCount < 1)
                {
                    MessageBox.Show("未选中任何数据!", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)  //循环遍历所有行
                    {
                        if (true == this.dataGridView1.Rows[i].Selected)//当前行处于选中状态，则将其删除   
                            this.dataGridView1.Rows.RemoveAt(i);
                    }

                    //删除任意行数据后，应该刷新dataGridView表格，使索引值从上至下按大小顺序排序                    
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            double lat = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());//获得本行经度
            double lang = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());//获得本行纬度

            planeOverlay.Markers.Clear();

            PointLatLng point1 = new PointLatLng(lat, lang);
            GMapAirPlane airPlane = new GMapAirPlane(point1);
            planeOverlay.Markers.Add(airPlane);
            this.gMapControl1.Overlays.Add(planeOverlay);
            gMapControl1.Refresh();
        }
    }



    public class Air_Port
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

        public Air_Port(String name, double lat, double lng)
        {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
        }
    }
}
