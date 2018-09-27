using ADSB.MainUI.SubForm;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ADSB.MainUI
{
    public partial class MainForm : Form
    {
        private GMapOverlay planeOverlay = new GMapOverlay("planeLayer"); //放置marker的图层
        private GMapMarkerImage currentMarker;
        private GMapAirPlane airPlane;
        private List<GMapAirPlane> listAirplane;
        private GMapAirPort airPort;
        private GMapAirSegment airSegment;
        private GMapAirSpace airSpace;
        private Timer flyTimer = new Timer();
        private Timer displayTimer = new Timer();

        private DataSource dataSource;

        bool IsPlayback=false;  //回放标志
        LogRecord log;

        //绘制窗口阴影 控制参数
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        public MainForm()
        {
            InitializeComponent();
            
            this.Region = new Region(
                         new RectangleF(
                         this.sTpFly.Left,
                         this.sTpFly.Top,
                         this.sTpFly.Width,
                         this.sTpFly.Height));

            InitializeUI();

            flyTimer.Tick += new EventHandler(flyTimer_Tick);
            displayTimer.Tick += new EventHandler(displayTimer_Tick);
            log = new LogRecord();
        }

        private void flyTimer_Tick(object sender, EventArgs e)
        {
            if (dataSource.Count == 0)
                return;
            Cat021Data tmpData = dataSource.GetData();
            GMapAirPlane tmpAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData);
            GMapAirPlane removeAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData);
            bool remove=false;
            foreach (GMapAirPlane eachlistAirplane in listAirplane)
            {
                if (eachlistAirplane.AirPlaneMarkerInfo.fid.Trim() == tmpData.flightNo.Trim())
                {
                    remove = true;
                    removeAirplane = eachlistAirplane;
                }
            }
            if (remove)
            {
                listAirplane.Remove(removeAirplane);
                
            }
            listAirplane.Add(tmpAirplane);
            remove = false;
            //planeOverlay.Markers.Add(tmpAirplane);
            //gMapControl1.Refresh();
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            planeOverlay.Markers.Clear();

            foreach (GMapAirPlane eachlistAirplane in listAirplane)
            {
              planeOverlay.Markers.Add(eachlistAirplane);
            }
            gMapControl1.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.sTabControl.SelectedIndex = 1;
            this.sTpFly.BackColor = Color.FromArgb(240,80, 80, 80);
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            InitializeGMap();

            dataSource = DataHelper.Build(DataSourceType.DATASOURCE_NAME_UDP);
            flyTimer.Interval = 1;
            flyTimer.Start();
            displayTimer.Interval = 100;
            displayTimer.Start();
        }

        //初始化界面
        private void InitializeUI()
        {
            sPnl_funcmore.Parent = gMapControl1;
            panelEx1.BackColor = Color.FromArgb(45, 0, 0, 0);
            panelEx1.Parent = gMapControl1;
            panelEx1.Visible = false;
        }

        //飞行模式按钮
        private void sPnl_Fly_Click(object sender, EventArgs e)
        {
            //显示飞行模式界面
            //flyTimer.Stop();
            //CommSocketManager.Stop();
            this.sTabControl.SelectedIndex = 0;
        }

        //飞行监控按钮
        private void sPanelMonitor_Click(object sender, EventArgs e)
        {
            //显示飞行监控界面
            this.sTabControl.SelectedIndex = 1;
            //CommSocketManager.Start();
            //flyTimer.Interval = 1000;
            //flyTimer.Start();
        }

        #region GMap控件相关操作
        //private GMapOverlay planeOverlay = new GMapOverlay("planeLayer"); //放置marker的图层
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
            //添加到图层
            this.gMapControl1.Overlays.Add(planeOverlay);

            listAirplane = new List<GMapAirPlane>();

        }
        #endregion
    }
}
