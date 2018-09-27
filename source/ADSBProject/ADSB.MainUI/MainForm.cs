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
using GMap.NET.WindowsForms.Markers;

namespace ADSB.MainUI
{
    public partial class MainForm : Form
    {
        private GMapOverlay planeOverlay = new GMapOverlay("planeLayer"); //飞机图层
        private GMapOverlay distinceOverlay = new GMapOverlay("distinceLayer"); //测距图层
        private GMapOverlay landStationOverlay = new GMapOverlay("landStationLayer"); //地面站图层
        private GMapOverlay airPortOverlay = new GMapOverlay("airPortLayer"); //地面站图层
        private GMapOverlay wayPointOverlay = new GMapOverlay("wayPointLayer"); //航站点图层
        private GMapOverlay airSegmentOverlay = new GMapOverlay("airSegmentLayer"); //航线图层

        // 是否是测距模式
        private bool isDistince = false;
        // 是否是画布模式
        private bool isCanvas = false;

        private GMapMarkerImage currentMarker;

        private GMapAirPlane airPlane;
        // 所有飞机
        private Dictionary<String, GMapAirPlane> listAirplane;
        // 凸显分飞机列表
        private Dictionary<String, GMapAirPlane> listAirplaneCheck = new Dictionary<String, GMapAirPlane>();
        // 画飞机轨迹
        Dictionary<String, List<PointLatLng>> keyValuePairs = new Dictionary<String, List<PointLatLng>>();
        
        // 要展示的地面站
        private List<GMapLandStation> listLandStations;
        // 当前是否要展示地面站
        private Boolean landStation;

        // 要展示的飞机场
        private List<GMapAirPort> listAirPort;
        // 当前是否要展示飞机场
        private Boolean airPort;

        // 要展示的航站点
        private List<GMapWayPoint> listWayPoint;
        // 当前是否要展示航站点
        private Boolean wayPoint;

        // 要展示的航线
        private List<GMapAirRoute> listAirRoute;
        // 当前是否要展示航线
        private Boolean airSegment;
        
        List<PointLatLng> distincePairs = new List<PointLatLng>();
       // private GMapAirPort airPort;
       // private GMapAirSegment airSegment;
        private GMapAirSpace airSpace;
        private Timer flyTimer = new Timer();
        private Timer displayTimer = new Timer();

        bool IsPlayback = false;  //回放标志
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
            if (CommSocketManager.GetNum() == 0)
                return;
            Cat021Data tmpData = CommSocketManager.GetData();

            bool isCheckedPlane = false;
            // 看飞机是否在选中列表中
            foreach (GMapAirPlane eachlistAirplane in listAirplaneCheck.Values)
            {
                if (eachlistAirplane.AirPlaneMarkerInfo.fid.Trim() == tmpData.flightNo.Trim())
                {
                    isCheckedPlane = true;
                }
            }

            GMapAirPlane tmpAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData, isCheckedPlane);
            GMapAirPlane removeAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData, false);

            bool remove = false;
            // 同一家飞机来了新的先从list里面移除掉
            foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
            {
                if (eachlistAirplane.AirPlaneMarkerInfo.fid.Trim() == tmpData.flightNo.Trim())
                {
                    remove = true;
                    removeAirplane = eachlistAirplane;
                }
            }

            if (remove)
            {
                PointLatLng pointLatLng = new PointLatLng(tmpData.latitude, tmpData.longtitude);

                List<PointLatLng> points;
                if (keyValuePairs.ContainsKey(tmpData.flightNo.ToString()))
                {
                    points = keyValuePairs[tmpData.flightNo.ToString()];
                    points.Add(pointLatLng);
                }
                else
                {
                    points = new List<PointLatLng>();
                    points.Add(pointLatLng);
                    keyValuePairs.Add(tmpData.flightNo.ToString(), points);
                }

                listAirplane.Remove(tmpData.flightNo.ToString());
            }
            listAirplane.Add(tmpData.flightNo.ToString(), tmpAirplane);
            remove = false;
            // planeOverlay.Markers.Add(tmpAirplane);
            // gMapControl1.Refresh();
        }

        private void sMonitorDis_MouseDown(object sender, MouseEventArgs e)
        {
            // 测距模式
            if (isDistince)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                // 获取上一个点
                PointLatLng pointLatLng;
                if (null != distincePairs && distincePairs.Count > 0)
                {
                    // 获取两个点的距离展示在后一个点上
                    pointLatLng = distincePairs.Last();
                    double dis = Distance(pointLatLng.Lat, pointLatLng.Lng, point.Lat, point.Lng);
                    GMapMarker m1 = new GMarkerGoogle(point, GMarkerGoogleType.green_big_go);
                    m1.ToolTipText = "距离:" + dis;
                    m1.ToolTipMode = MarkerTooltipMode.Always;
                    distinceOverlay.Markers.Add(m1);
                }
                else
                {
                    GMapMarker m1 = new GMarkerGoogle(point, GMarkerGoogleType.green_big_go);
                    m1.ToolTipText = "起点";
                    m1.ToolTipMode = MarkerTooltipMode.Always;
                    distinceOverlay.Markers.Add(m1);
                }
                
                distincePairs.Add(point);
               
                GMapRoute r = new GMapRoute(distincePairs, "");
                r.Stroke = new Pen(Color.Green, 1);
                
                distinceOverlay.Routes.Add(r);
                gMapControl1.Refresh();
            }

            if (isCanvas)
            {
                // 这里获取经纬度
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                // TODO 保存数据库
                GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point);

                distinceOverlay.Markers.Add(gMapMarkerCircle);
                gMapControl1.Refresh();
            }
        }

        private void mapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item is GMapAirPlane)
            {
                GMapAirPlane gMapAirPlane = item as GMapAirPlane;
                gMapAirPlane.Pen = new Pen(Brushes.Red, 2);
                if (!listAirplaneCheck.ContainsKey(gMapAirPlane.AirPlaneMarkerInfo.fid))
                {
                    listAirplaneCheck.Add(gMapAirPlane.AirPlaneMarkerInfo.fid, gMapAirPlane);
                }
            }
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            planeOverlay.Markers.Clear();

            foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
            {
                planeOverlay.Markers.Add(eachlistAirplane);
            }

            foreach (KeyValuePair<String, List<PointLatLng>> kvp in keyValuePairs)
            {
                List<PointLatLng> points = kvp.Value;
                GMapRoute r = new GMapRoute(points, "");
                r.Stroke = new Pen(Color.Green, 1);
                planeOverlay.Routes.Add(r);
            }
            gMapControl1.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.sTabControl.SelectedIndex = 1;
            this.sTpFly.BackColor = Color.FromArgb(240, 80, 80, 80);
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            InitializeGMap();

            CommSocketManager.Start();
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

            listAirplane = new Dictionary<String, GMapAirPlane>();

        }

        #endregion

        //来调试回放进度条
        private void timerSPBarPlayback_Tick(object sender, EventArgs e)
        {
            int temp;
            temp = skinProgressBar1.Value + 1;
            if (temp > 100) temp = 0;
            skinProgressBar1.Value = temp;

        }

        public static double HaverSin(double theta)
        {
            var v = Math.Sin(theta / 2);
            return v * v;
        }

        static double EARTH_RADIUS = 6371.0;//km 地球半径 平均值，千米

        /// <summary>
        /// 给定的经度1，纬度1；经度2，纬度2. 计算2个经纬度之间的距离。
        /// </summary>
        /// <param name="lat1">经度1</param>
        /// <param name="lon1">纬度1</param>
        /// <param name="lat2">经度2</param>
        /// <param name="lon2">纬度2</param>
        /// <returns>距离（公里、千米）</returns>
        public static double Distance(double lat1, double lon1, double lat2, double lon2)
        {
            //用haversine公式计算球面两点间的距离。
            //经纬度转换成弧度
            lat1 = ConvertDegreesToRadians(lat1);
            lon1 = ConvertDegreesToRadians(lon1);
            lat2 = ConvertDegreesToRadians(lat2);
            lon2 = ConvertDegreesToRadians(lon2);

            //差值
            var vLon = Math.Abs(lon1 - lon2);
            var vLat = Math.Abs(lat1 - lat2);

            //h is the great circle distance in radians, great circle就是一个球体上的切面，它的圆心即是球心的一个周长最大的圆。
            var h = HaverSin(vLat) + Math.Cos(lat1) * Math.Cos(lat2) * HaverSin(vLon);

            var distance = 2 * EARTH_RADIUS * Math.Asin(Math.Sqrt(h));

            return distance * 1000;
        }

        /// <summary>
        /// 将角度换算为弧度。
        /// </summary>
        /// <param name="degrees">角度</param>
        /// <returns>弧度</returns>
        public static double ConvertDegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double ConvertRadiansToDegrees(double radian)
        {
            return radian * 180.0 / Math.PI;
        }


        private void maskPlaybackRun_Click(object sender, EventArgs e)
        {
            //点击了“开始回放”按钮
            //MessageBox.Show("开始回放！");
            timerSPBarPlayback.Enabled = true;
            timerSPBarPlayback.Interval = 100;
            skinProgressBar1.Value = 0;
        }

        private void maskPlaybackSetup_Click(object sender, EventArgs e)
        {
            //显示地图蒙版
            mapmask.Location = new Point(0, 0);
            mapmask.Size = new Size(1280, 752);
            mapmask.Visible = true;

            Form test = new Form_playback();  //回放设置
            test.ShowDialog();

            //恢复回放蒙版
            mapmask.Visible = false;
            panelEx1.Location = new Point(0, 642);
            panelEx1.Size = new Size(1280, 110);
            panelEx1.Visible = true;
            panelEx1.BackColor = Color.FromArgb(115, 0, 0, 0);
        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {
            //该处绘制不容易添加的控件

            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Font textFont = new Font("微软雅黑", 42, FontStyle.Regular, GraphicsUnit.Document);
            e.Graphics.DrawString("回放设置", textFont, textBrush, 31, 43);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isDistince = true;
            this.gMapControl1.Overlays.Add(distinceOverlay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isDistince = false;
            distincePairs.Clear();
            distinceOverlay.Clear();
            this.gMapControl1.Overlays.Remove(distinceOverlay);
        }

        private void sPnl_dimianzhan_Paint(object sender, PaintEventArgs e)
        {

        }

        /**
         * 点击了地面站
         * */
        private void skinLabel27_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果地面站列表有修改
                Form_earthStation earthStation = new Form_earthStation();
                earthStation.earthStation_event += new Form_earthStation.earthStation(frm_changebox7_event);

                earthStation.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /**
         * 点击了机场
         * */
        private void skinLabel28_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果机场列表有修改
                Form_airPort airPort = new Form_airPort();
                airPort.airPort_event += new Form_airPort.airPort(frm_changebox4_event);

                airPort.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /**
         * 点击了航站点
         * */
        private void skinLabel29_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果航站点列表有修改
                Form_wayPoint wayPoint = new Form_wayPoint();
                wayPoint.wayPoint_event += new Form_wayPoint.wayPoint(frm_changebox5_event);

                wayPoint.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /**
        * 点击了航段
        **/
        private void skinLabel32_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果航线列表有修改
                Form_airSegment airSegment = new Form_airSegment();
                airSegment.airSegment_event += new Form_airSegment.airSegment(frm_changebox5_event);

                airSegment.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /**
         * 点击了航线
         * */
        private void skinLabel30_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果航线列表有修改
                Form_airRoute airRoute = new Form_airRoute();
                airRoute.airRoute_event += new Form_airRoute.airRoute(frm_changebox5_event);

                airRoute.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /**
         * 点击了空域
         * */
        private void skinLabel31_Click(object sender, EventArgs e)
        {

        }

       
    }
}
