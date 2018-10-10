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
        private GMapOverlay airSpaceOverlay = new GMapOverlay("airSpaceLayer"); //空域图层
        private GMapOverlay wayPointOverlay = new GMapOverlay("wayPointLayer"); //航站点图层
        private GMapOverlay pointLandOverlay = new GMapOverlay("pointLandLayer"); //航站点图层
        private GMapOverlay airSegmentOverlay = new GMapOverlay("airSegmentLayer"); //航线图层
        private GMapOverlay flightCircleOverlay = new GMapOverlay("flightCircleLayer"); //航迹圈图层

        // 是否是测距模式
        private bool isDistince = false;

        // private GMapMarkerImage currentMarker;

        // private GMapAirPlane airPlane;
        // 所有飞机
        private Dictionary<int, GMapAirPlane> listAirplane;
        // 凸显分飞机列表
        private Dictionary<int, int> listAirplaneCheck = new Dictionary<int, int>();
        // 凸显分飞机--跟地面站画虚线
        private Dictionary<int, PointLatLng> pointPlaneLand = new Dictionary<int, PointLatLng>();
        // 画飞机轨迹
        private Dictionary<int, List<PointLatLng>> keyValuePairs = new Dictionary<int, List<PointLatLng>>();

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

        // 要展示的航段
        private List<GMapAirSegment> listAirSegment;
        // 当前是否要展示航段
        private Boolean airSegment;

        // 要展示的空域
        private List<String> listAirSpace;
        // 当前是否要展示空域
        private Boolean airSpace;

        // 当前是否要展示航迹圈
        private Boolean flightCircle;

        List<PointLatLng> distincePairs = new List<PointLatLng>();
       // private GMapAirPort airPort;
       // private GMapAirSegment airSegment;
       // private GMapAirSpace airSpace;
        private Timer flyTimer = new Timer();
        private Timer displayTimer = new Timer();
        private Timer playBackTimer = new Timer();

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
            initListAirplaneCheck(true);

            flyTimer.Tick += new EventHandler(flyTimer_Tick);
            displayTimer.Tick += new EventHandler(displayTimer_Tick);
            playBackTimer.Tick += new EventHandler(playBackTimer_Tick);

            log = new LogRecord();
        }

        private void initListAirplaneCheck(bool first)
        {
            if (!first)
            {
                int i = 0;
                while (i >= 0)
                {
                    i = dataGridView1.RowCount - 2;
                    if (i >= 0)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    i--;
                }
            }
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM PlaneFollow");
            listAirplaneCheck.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                int sModeAddress = Convert.ToInt32(dictionary["SModeAddress"]);
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = sModeAddress.ToString();
                if(!listAirplaneCheck.ContainsKey(sModeAddress))
                    listAirplaneCheck.Add(sModeAddress, sModeAddress);
            }
        }

        private void flyTimer_Tick(object sender, EventArgs e)
        {
            if (dataSource.Count == 0)
                return;
            Cat021Data tmpData = dataSource.GetData();
            int isCheckedPlane = 0;

            // 获取中心机
            String my_sAddress = ConfigHelper.Instance.GetConfig("my_sAddress");
            int iAddress = Convert.ToInt32(my_sAddress);
            if (!string.IsNullOrWhiteSpace(my_sAddress) && tmpData.sModeAddress == iAddress)
            {
                isCheckedPlane = 1;

                ConfigHelper.Instance.SetConfig("my_flightNo", tmpData.flightNo.ToString().Trim());
                ConfigHelper.Instance.SetConfig("my_latitude", tmpData.latitude.ToString());
                ConfigHelper.Instance.SetConfig("my_longtitude", tmpData.longtitude.ToString());
                ConfigHelper.Instance.SetConfig("my_elapsedTime", tmpData.elapsedTime.ToString());
                ConfigHelper.Instance.SetConfig("my_geometricAltitude", tmpData.geometricAltitude.ToString());
                ConfigHelper.Instance.SetConfig("my_barometricAltitude", tmpData.barometricAltitude.ToString());
                ConfigHelper.Instance.SetConfig("my_airSpeed", tmpData.airSpeed.ToString());
                ConfigHelper.Instance.SetConfig("my_airSpeedUnit", tmpData.airSpeedUnit.ToString());
                ConfigHelper.Instance.SetConfig("my_aircraftAngle", tmpData.aircraftAngle.ToString());
                ConfigHelper.Instance.SetConfig("my_groundSpeed", tmpData.groundSpeed.ToString());
                ConfigHelper.Instance.SetConfig("my_emitterCategory", tmpData.emitterCategory.ToString());
            }

            // 看飞机是否在选中列表中
            if (listAirplaneCheck.ContainsKey(tmpData.sModeAddress))
            {
                isCheckedPlane = 2;
                PointLatLng pointLatLng = new PointLatLng(tmpData.latitude, tmpData.longtitude);
                if (pointPlaneLand.ContainsKey(tmpData.sModeAddress))
                {
                    pointPlaneLand.Remove(tmpData.sModeAddress);
                }
                pointPlaneLand.Add(tmpData.sModeAddress, pointLatLng);
            }

            GMapAirPlane tmpAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData, isCheckedPlane);
            GMapAirPlane removeAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData, 0);
            bool remove = false;
            // 同一家飞机来了新的先从list里面移除掉
            foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
            {
                if (eachlistAirplane.AirPlaneMarkerInfo.sModeAddress == tmpData.sModeAddress)
                {
                    remove = true;
                    removeAirplane = eachlistAirplane;
                    ProfileHelper.Instance.Update("Delete FROM Plane WHERE SModeAddress = \"" + tmpData.sModeAddress + "\"");
                }
            }

            if (remove)
            {
                PointLatLng pointLatLng = new PointLatLng(tmpData.latitude, tmpData.longtitude);

                List<PointLatLng> points;
                if (keyValuePairs.ContainsKey(tmpData.sModeAddress))
                {
                    points = keyValuePairs[tmpData.sModeAddress];
                    points.Add(pointLatLng);
                }
                else
                {
                    points = new List<PointLatLng>();
                    points.Add(pointLatLng);
                    keyValuePairs.Add(tmpData.sModeAddress, points);
                }
            }
            if (listAirplane.ContainsKey(tmpData.sModeAddress))
            { 
                listAirplane.Remove(tmpData.sModeAddress);
            }
            listAirplane.Add(tmpData.sModeAddress, tmpAirplane);
            // 插入数据库
            ProfileHelper.Instance.Update("Delete FROM Plane WHERE SModeAddress = \"" + tmpData.sModeAddress.ToString().Trim() + "\"");
            ProfileHelper.Instance.Update("INSERT INTO Plane (" +
                "SModeAddress, FlightNo, Latitude, " +
                "Longtitude, ElapsedTime, GeometricAltitude, " +
                "BarometricAltitude, AirSpeed, AirSpeedUnit, " +
                "AircraftAngle, GroundSpeed, EmitterCategory) VALUES ('" +
                tmpData.sModeAddress + "', '" + tmpData.flightNo.ToString().Trim() + "', " + tmpData.latitude + ", " +
                tmpData.longtitude + ", " + tmpData.elapsedTime + ", " + tmpData.geometricAltitude + ", " +
                tmpData.barometricAltitude + ", " + tmpData.airSpeed + ", " + tmpData.airSpeedUnit + ", " +
                tmpData.aircraftAngle + ", " + tmpData.groundSpeed + ", " + tmpData.emitterCategory +
                ")");
            remove = false;
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
            
        }

        private void mapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item is GMapAirPlane)
            {
                GMapAirPlane gMapAirPlane = item as GMapAirPlane;
                gMapAirPlane.Pen = new Pen(Brushes.Red, 2);
                if (!listAirplaneCheck.ContainsKey(gMapAirPlane.AirPlaneMarkerInfo.sModeAddress))
                {
                    listAirplaneCheck.Add(gMapAirPlane.AirPlaneMarkerInfo.sModeAddress, gMapAirPlane.AirPlaneMarkerInfo.sModeAddress);
                    // 插入数据库
                    String flightNo = gMapAirPlane.AirPlaneMarkerInfo.flightNo;
                    String flightPlan = "未知";
                    String sModeAddress = Convert.ToString(gMapAirPlane.AirPlaneMarkerInfo.sModeAddress);

                    ProfileHelper.Instance.Update("INSERT INTO PlaneFollow (FlightNo, FlightPlan, SModeAddress) VALUES ('"
                        + flightNo + "', '" + flightPlan + "', '" + sModeAddress + "')");
                }
                else
                {
                    int sModeAddress = gMapAirPlane.AirPlaneMarkerInfo.sModeAddress;
                    pointPlaneLand.Remove(sModeAddress);
                    ProfileHelper.Instance.Update("Delete FROM PlaneFollow WHERE SModeAddress = \"" + sModeAddress + "\"");
                }
                initListAirplaneCheck(false);
            }
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            planeOverlay.Markers.Clear();

            // 获取地面站信息
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM LandStation");
            bool hasLandStation = false;
            Dictionary<string, object> dictionary;
            String name;
            double lat;
            double lang ;
            PointLatLng pointLandStation = new PointLatLng(0, 0); 
            if (result.Count() > 0)
            {
                hasLandStation = true;
                dictionary = result[0];
                name = Convert.ToString(dictionary["Name"]);
                lat = Convert.ToDouble(dictionary["Lat"]);
                lang = Convert.ToDouble(dictionary["Lng"]);
                pointLandStation = new PointLatLng(lat, lang);
            }

            // 只展示环内的飞机
            if (landStation && flightCircle && hasLandStation)
            {
                foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
                {
                    double length = Convert.ToDouble(result[0]["Length"]);
                    int num = Convert.ToInt16(result[0]["Num"]);
                    double dis = length * num;

                    double disPlane = Distance(pointLandStation.Lat, pointLandStation.Lng, 
                        eachlistAirplane.AirPlaneMarkerInfo.latitude, eachlistAirplane.AirPlaneMarkerInfo.longtitude);

                    // 判断是否要告警
                    alarm(eachlistAirplane);

                    if (disPlane <= dis)
                    {
                        planeOverlay.Markers.Add(eachlistAirplane);
                        // 显示轨迹
                        int sma = eachlistAirplane.AirPlaneMarkerInfo.sModeAddress;
                        if (keyValuePairs.ContainsKey(sma) && !pointPlaneLand.ContainsKey(sma))
                        {
                            List<PointLatLng> points = keyValuePairs[sma];
                            GMapRoute r = new GMapRoute(points, "");
                            r.Stroke = new Pen(Color.Green, 1);
                            planeOverlay.Routes.Add(r);
                        }
                    }
                }
            }
            else
            {
                foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
                {
                    planeOverlay.Markers.Add(eachlistAirplane);

                    // 判断是否要告警
                    alarm(eachlistAirplane);

                    // 显示轨迹
                    int sModeAddress = eachlistAirplane.AirPlaneMarkerInfo.sModeAddress;
                    if (keyValuePairs.ContainsKey(sModeAddress) && !pointPlaneLand.ContainsKey(sModeAddress))
                    {
                        List<PointLatLng> points = keyValuePairs[sModeAddress];
                        GMapRoute r = new GMapRoute(points, "");
                        r.Stroke = new Pen(Color.Green, 1);
                        planeOverlay.Routes.Add(r);
                    }
                }
            }

            // 展示飞机轨迹
            //foreach (keyvaluepair<string, list<pointlatlng>> kvp in keyvaluepairs)
            //{
            //    list<pointlatlng> points = kvp.value;
            //    gmaproute r = new gmaproute(points, "");
            //    r.stroke = new pen(color.green, 1);
            //    planeoverlay.routes.add(r);
            //}

            // 只展示第一个地面站与凸显飞机的距离
            if (hasLandStation)
            {
                if (landStation && pointPlaneLand.Count > 0)
                {
                    pointLandOverlay.Clear();
                    gMapControl1.Overlays.Add(pointLandOverlay);
                    foreach (KeyValuePair<int, PointLatLng> kvp in pointPlaneLand)
                    {
                        PointLatLng pointLatLngPlane = kvp.Value;
                        double dis = Distance(pointLandStation.Lat, pointLandStation.Lng, pointLatLngPlane.Lat, pointLatLngPlane.Lng);
                        GMapMarker m1 = new GMarkerGoogle(pointLatLngPlane, GMarkerGoogleType.blue_dot);
                        m1.ToolTipText = dis.ToString();
                        m1.ToolTipMode = MarkerTooltipMode.Always;
                        pointLandOverlay.Markers.Add(m1);

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(pointLandStation);
                        points.Add(pointLatLngPlane);
                        GMapPolygon polygon = new GMapPolygon(points, dis.ToString());
                        polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                        // 虚线
                        float[] dashValues = { 2, 3 };
                        Pen pen = new Pen(Color.Blue, 1);
                        pen.DashPattern = dashValues;
                        polygon.Stroke = pen;
                        pointLandOverlay.Polygons.Add(polygon);

                        // 展示轨迹
                        int sModeAddress = kvp.Key;
                        if (keyValuePairs.ContainsKey(sModeAddress))
                        {
                            List<PointLatLng> point = keyValuePairs[sModeAddress];
                            GMapRoute r = new GMapRoute(point, "");
                            r.Stroke = new Pen(Color.Green, 1);
                            planeOverlay.Routes.Add(r);
                        }
                    }
                }
                else
                {
                    gMapControl1.Overlays.Remove(pointLandOverlay);
                }
            }  
            gMapControl1.Refresh();
        }

        /**
         * 判断是否要告警
         * */
        private void alarm(GMapAirPlane eachlistAirplane)
        {
            //获取告警直线距离
            String distance = ConfigHelper.Instance.GetConfig("alarm_distance");
            if (!string.IsNullOrWhiteSpace(distance))
            {
                double latitude = Convert.ToDouble(ConfigHelper.Instance.GetConfig("my_latitude"));
                double longtitude = Convert.ToDouble(ConfigHelper.Instance.GetConfig("my_longtitude"));

                double disPlane = Distance(latitude, longtitude,
                            eachlistAirplane.AirPlaneMarkerInfo.latitude, eachlistAirplane.AirPlaneMarkerInfo.longtitude);

                double alarm_distance = Convert.ToDouble(distance);

                if(disPlane > 0.1 && alarm_distance >= disPlane)
                {
                    String info = "距离报警！" + eachlistAirplane.AirPlaneMarkerInfo.sModeAddress.ToString() + "跟中心机距离：" + disPlane.ToString();
                    ProfileHelper.Instance.Update("INSERT INTO Alarm (" +
                        "FlightNo, SModeAddress, Info, WriteTime) VALUES ('" +
                        eachlistAirplane.AirPlaneMarkerInfo.flightNo.ToString().Trim() + "', '" + 
                        eachlistAirplane.AirPlaneMarkerInfo.sModeAddress + "', " + 
                        info + ", " + DateTime.Now.ToString() + ")");
                    MessageBox.Show(info);
                }
            }

            //String hight = ConfigHelper.Instance.GetConfig("alarm_hight");
            //if (!string.IsNullOrWhiteSpace(hight))
            //{
            //    double geometricAltitude = Convert.ToDouble(ConfigHelper.Instance.GetConfig("geometricAltitude"));
            //    double alarm_hight = Convert.ToDouble(hight);
            //    if(alarm_hight >= geometricAltitude)
            //    {
            //        MessageBox.Show("高度报警！中心机高度：" + geometricAltitude.ToString());
            //    }
            //}

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.sTabControl.SelectedIndex = 1;
            this.sTpFly.BackColor = Color.FromArgb(240, 80, 80, 80);
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            InitializeGMap();

            dataSource = DataHelper.Build(DataSourceType.DATASOURCE_NAME_UDP);
            flyTimer.Interval = 100;
            flyTimer.Start();
            displayTimer.Interval = 1000;
            displayTimer.Start();
        }

        //初始化界面
        private void InitializeUI()
        {
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

            listAirplane = new Dictionary<int, GMapAirPlane>();

        }

        #endregion

        // 来调试回放进度条
        private void playBackTimer_Tick(object sender, EventArgs e)
        {
            if (0 == ((DBDataSource)dataSource).MaxId)
            {
                skinProgressBar1.Value = 100;
                return;
            }
            System.Diagnostics.Debug.WriteLine("ID = " + (((DBDataSource)dataSource).Id + ", MinID = " + ((DBDataSource)dataSource).MinId) + ", MaxID = " + ((DBDataSource)dataSource).MaxId);
            int progress = (((DBDataSource) dataSource).Id - ((DBDataSource)dataSource).MinId) * 100 / ((DBDataSource)dataSource).MaxId;
            if(progress < 0)
            {
                progress = 0;
            }
            else if (progress > 100)
            {
                progress = 100;
            }
            skinProgressBar1.Value = progress;
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
            // 启动回放
            StartPlayBack();
        }


        public void ResetMap()
        {
            listAirplane.Clear();
        }

        public void StartPlayBack()
        {
            if (null != dataSource)
            {
                dataSource.Terminate();
                dataSource = null;
            }
            dataSource = DataHelper.Build(DataSourceType.DATASOURCE_NAME_DB);
            ResetMap();
            playBackTimer.Interval = 100;
            playBackTimer.Start();
            skinProgressBar1.Value = 0;
            skinProgressBar1.Enabled = false;
        }

        public void StopPlayBack()
        {
            playBackTimer.Stop();
            skinProgressBar1.Value = 0;
            skinProgressBar1.Enabled = false;
            if (null != dataSource)
            {
                dataSource.Terminate();
                dataSource = null;
            }
            dataSource = DataHelper.Build(DataSourceType.DATASOURCE_NAME_UDP);
            ResetMap();
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
            e.Graphics.DrawString("回放设置", textFont, textBrush, 31, 65);

            e.Graphics.DrawImage(maskPlaybackRun.BackgroundImage, new PointF(maskPlaybackRun.Left - panelEx1.Left, maskPlaybackRun.Top - panelEx1.Top));
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
                Form_landStation landStation = new Form_landStation();
                landStation.landStation_event += new Form_landStation.landStation(frm_changebox7_event);

                landStation.ShowDialog();
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
                airSegment.airSegment_event += new Form_airSegment.airSegment(frm_changebox3_event);

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
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                // 如果空域列表有修改
                Form_airSpace airSpace = new Form_airSpace();
                airSpace.airSpace_event += new Form_airSpace.airSpace(frm_changebox2_event);

                airSpace.ShowDialog();
                mapmask.Visible = false;
            }
        }


        private void skinLabel33_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_alarmSet alarmSet = new Form_alarmSet();
                alarmSet.ShowDialog();
                mapmask.Visible = false;
            }
        }

        private void skinLabel34_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_setup setup = new Form_setup();
                setup.ShowDialog();
                mapmask.Visible = false;
            }
        }

        private void sPnl_close_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }
    }
}
