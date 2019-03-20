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
        private GMapOverlay airSegmentOverlay = new GMapOverlay("airSegmentLayer"); //航段图层
        private GMapOverlay airRouteOverlay = new GMapOverlay("airRouteLayer"); //航线图层
        private GMapOverlay landCircleOverlay = new GMapOverlay("landCircleLayer"); //地面站距离环图层
        private GMapOverlay flightCircleOverlay = new GMapOverlay("flightCircleLayer"); //机场距离环图层

        // 是否是测距模式
        private bool isDistince = false;

        // 当前是否要展示飞机
        private Boolean airPlaneShow;

        // 当前的关注对象（飞行器or地面站）
        private int currentFellowId = 0;

        // private GMapAirPlane airPlane;
        // 所有飞机
        private Dictionary<int, GMapAirPlane> listAirplane;
        // 凸显分飞机列表
        private Dictionary<int, int> listAirplaneCheck = new Dictionary<int, int>();
        // 凸显分飞机--跟地面站画虚线
        private Dictionary<int, PointLatLng> pointPlaneLand = new Dictionary<int, PointLatLng>();
        // 画飞机轨迹
        private Dictionary<int, List<PointLatLng>> keyValuePairs = new Dictionary<int, List<PointLatLng>>();
        private Dictionary<int, int> showValue = new Dictionary<int, int>();
        // 展示几个轨迹
        private int showPoint;
        // 轨迹循环队列长度
        private int showPointMax = 30;

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

        // 当前是否要展示地面站距离环
        private Boolean landDistenceCircle;

        // 当前是否要展示地面站距离环
        private Boolean airPortDistenceCircle;

        // 要展示的航线
        // private List<PointLatLng> listAirRoute;
        // 当前是否要展示航线
        private Boolean airRoute;

        List<PointLatLng> distincePairs = new List<PointLatLng>();
       // private GMapAirPort airPort;
       // private GMapAirSegment airSegment;
       // private GMapAirSpace airSpace;
        private Timer flyTimer = new Timer();
        private Timer displayTimer = new Timer();
        private Timer playBackTimer = new Timer();

        public static DataSource dataSource;

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

            //this.Region = new Region(
            //             new RectangleF(
            //             this.gMapControl1.Left,
            //             this.gMapControl1.Top,
            //             this.gMapControl1.Width,
            //             this.gMapControl1.Height));

            InitializeUI();
            initListAirplaneCheck(true);

            flyTimer.Tick += new EventHandler(flyTimer_Tick);
            displayTimer.Tick += new EventHandler(displayTimer_Tick);
            playBackTimer.Tick += new EventHandler(playBackTimer_Tick);

            log = new LogRecord();
        }

        // 展示凸显飞行器、地面站
        private void initListAirplaneCheck(bool first)
        {
            if (!first)
            {
                int i = 0;
                while (i >= 0)
                {
                    i = dataGridView1.RowCount - 1;
                    if (i >= 0)
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    i--;
                }
            }
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM PlaneFollow");
            listAirplaneCheck.Clear();

            // 先展示飞行器
            foreach (Dictionary<string, object> dictionary in result)
            {
                int id = Convert.ToInt32(dictionary["ID"]);
                int type = Convert.ToInt32(dictionary["Type"]);
                int idNum = Convert.ToInt32(dictionary["IDNum"]);
                int length = Convert.ToInt32(dictionary["Length"]);
                
                if (1 == type)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[1].Value = "飞行器";
                    this.dataGridView1.Rows[index].Cells[2].Value = idNum;
                    // 去重对于飞行器idNum就是address
                    if (!listAirplaneCheck.ContainsKey(idNum))
                        listAirplaneCheck.Add(idNum, idNum);
                    this.dataGridView1.Rows[index].Cells[3].Value = length;
                    this.dataGridView1.Rows[index].Cells[5].Value = id.ToString();
                    if (currentFellowId == id)
                    {
                        this.dataGridView1.Rows[index].Cells[0].Value = true;
                    }
                }
            }

            // 再展示地面站
            foreach (Dictionary<string, object> dictionary in result)
            {
                int id = Convert.ToInt32(dictionary["ID"]);
                int type = Convert.ToInt32(dictionary["Type"]);
                int idNum = Convert.ToInt32(dictionary["IDNum"]);
                int length = Convert.ToInt32(dictionary["Length"]);

                if (1 != type)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[1].Value = "地面站";
                    // 根据id查出地面站信息
                    List<Dictionary<string, object>> stationList = ProfileHelper.Instance.Select("SELECT * FROM LandStation WHERE ID = " + idNum);
                    if (stationList.Count() > 0)
                    {
                        Dictionary<string, object> station = stationList[0];
                        String name = Convert.ToString(station["Name"]);
                        this.dataGridView1.Rows[index].Cells[2].Value = name;
                    }
                    this.dataGridView1.Rows[index].Cells[4].Value = idNum;
                    this.dataGridView1.Rows[index].Cells[3].Value = length;
                    this.dataGridView1.Rows[index].Cells[5].Value = id.ToString();
                    if (currentFellowId == id)
                    {
                        this.dataGridView1.Rows[index].Cells[0].Value = true;
                    }
                }
            }

        }

        // 区别飞行器是正常机、凸显机还是中心机；记录轨迹点
        private void flyTimer_Tick(object sender, EventArgs e)
        {
            if (dataSource.Count == 0)
                return;
            Cat021Data tmpData = dataSource.GetData();
            int isCheckedPlane = 0; // 0-普通飞行器，1-凸显飞行器，2-中心机,3-告警机器

            // 获取中心机
            String my_sAddress = ConfigHelper.Instance.GetConfig("my_sAddress");
            int iAddress = Convert.ToInt32(my_sAddress);
            if (!string.IsNullOrWhiteSpace(my_sAddress) && tmpData.sModeAddress == iAddress)
            {
                isCheckedPlane = 1;
                initCenterPlane(tmpData);
            }

            PointLatLng pointLatLng = new PointLatLng(tmpData.latitude, tmpData.longtitude);
            // 看飞机是否在凸显列表中
            if (1 != isCheckedPlane)
            {
                if (listAirplaneCheck.ContainsKey(tmpData.sModeAddress))
                {
                    isCheckedPlane = 2;
                    
                    if (pointPlaneLand.ContainsKey(tmpData.sModeAddress))
                    {
                        pointPlaneLand.Remove(tmpData.sModeAddress);
                    }
                    pointPlaneLand.Add(tmpData.sModeAddress, pointLatLng);
                }

                if (AirplaneManager.Instance.checkAlermPlane(tmpData.sModeAddress))
                {
                    isCheckedPlane = 3;
                }
            }

            GMapAirPlane tmpAirplane = new GMapAirPlane(new PointLatLng(tmpData.latitude, tmpData.longtitude), tmpData, isCheckedPlane);
            int sModeAddress = tmpData.sModeAddress;

            // 轨迹点处理
            List<PointLatLng> points;
            if (keyValuePairs.ContainsKey(sModeAddress))
            {
                points = keyValuePairs[sModeAddress];
                showValue[sModeAddress] = showValue[sModeAddress] + 1;
                if (29 == showValue[sModeAddress])
                {
                    pointMax(points);
                }
                points.Add(pointLatLng);
            }
            else
            {
                points = new List<PointLatLng>(showPointMax);
                points.Add(pointLatLng);
                keyValuePairs.Add(sModeAddress, points);
                showValue[sModeAddress] = 0;
            }

            // 同一架飞机来了新的先从list里面移除掉
            if (listAirplane.ContainsKey(sModeAddress))
            {
                listAirplane.Remove(sModeAddress);
                //showAllPalne();
                //planeOverlay.Markers.Remove(tmpAirplane);
            }
            else
            {
                listAirplane.Add(sModeAddress, tmpAirplane);
            }
            //showOnePlane(tmpAirplane);

            AirplaneManager.Instance.Add(tmpData);

            
            /*
            

            // 全部飞机展示
            if (airPlaneShow)
            {
                showAllPalne();
            }

            // 展示关注飞机与指定地面站的虚线距离
            showLandStation();

            gMapControl1.Refresh();
            */
        }

        private void pointMax(List<PointLatLng> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                points[i] = points[i + 1];
            }
        }

        private void initCenterPlane(Cat021Data tmpData)
        {
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
                    double dis = CommonHelper.Distance(pointLatLng.Lat, pointLatLng.Lng, point.Lat, point.Lng);
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

        private void sMonitorDis_MouseOn(GMapMarker item)
        {

            if (item is GMapAirPlane)
            {
                //ToolTipText = "S模式地址：" + data.sModeAddress.ToString() + "\r\n"
                //            // + "SSR: " + "0" + "\r\n"
                //            + "FID: " + data.flightNo.ToString() + "\r\n"
                //            + "经度: " + p.Lat.ToString() + "\r\n"
                //            + "纬度: " + p.Lng.ToString() + "\r\n"
                //            + "高度：" + data.geometricAltitude.ToString() + "\r\n";

                GMapAirPlane gMapAirPlane = item as GMapAirPlane;
                textBox1.Text = gMapAirPlane.AirPlaneMarkerInfo.sModeAddress.ToString();
                textBox2.Text = gMapAirPlane.AirPlaneMarkerInfo.flightNo.ToString();
                textBox3.Text = gMapAirPlane.AirPlaneMarkerInfo.latitude.ToString();
                textBox4.Text = gMapAirPlane.AirPlaneMarkerInfo.longtitude.ToString();
                textBox5.Text = gMapAirPlane.AirPlaneMarkerInfo.geometricAltitude.ToString();

                panel1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
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
                    String sModeAddress = Convert.ToString(gMapAirPlane.AirPlaneMarkerInfo.sModeAddress);

                    ProfileHelper.Instance.Update("INSERT INTO PlaneFollow (ID, Type, IDNum, Length) VALUES (NULL, 1, '" + sModeAddress + "', 0)");
                }
                else
                {
                    int sModeAddress = gMapAirPlane.AirPlaneMarkerInfo.sModeAddress;
                    Boolean isCommon = false;
                    List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM CommonPlane");
                    foreach (Dictionary<string, object> dictionary in result)
                    {
                        int sModeAddressSel = Convert.ToInt32(dictionary["SModeAddress"]);
                        if (sModeAddressSel == sModeAddress)
                        {
                            isCommon = true;
                        }
                    }

                    if (isCommon)
                    {
                        MessageBox.Show("常用飞机不可以直接在关注列表中直接删除，请去<常用飞行器>中删除！");
                        return;
                    }
                    else
                    {
                        pointPlaneLand.Remove(sModeAddress);
                        ProfileHelper.Instance.Update("Delete FROM PlaneFollow WHERE Type = 1 AND IDNum = \"" + sModeAddress + "\"");
                    }
                }
            }
            else if (item is GMapLandStation)
            {
                GMapLandStation gMapLandStation = item as GMapLandStation;
                // 根据name查出地面站信息
                List<Dictionary<string, object>> stationList = ProfileHelper.Instance.Select("SELECT * FROM LandStation WHERE Name = '" + gMapLandStation.Name + "'");
                if (stationList.Count() > 0)
                {
                    Dictionary<string, object> dictionary = stationList[0];
                    int id = Convert.ToInt32(dictionary["ID"]);
                    List<Dictionary<string, object>> result =
                        ProfileHelper.Instance.Select("SELECT * FROM PlaneFollow WHERE Type = 2 AND IDNum = " + id);
                    if (result.Count() == 0)
                    {
                        ProfileHelper.Instance.Update("INSERT INTO PlaneFollow (ID, Type, IDNum, Length) VALUES (NULL, 2, '" + id + "', 0)");
                    }
                    else
                    {
                        ProfileHelper.Instance.Update("Delete FROM PlaneFollow WHERE Type = 2 AND IDNum = \"" + id + "\"");
                    }
                }
            }
            else
            {
                panel1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
            initListAirplaneCheck(false);
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            planeOverlay.Markers.Clear();
            planeOverlay.Routes.Clear();

            // 全部飞机展示
            if (airPlaneShow)
            {
                showAllPalne();
            }
            
            // 展示关注飞机与指定地面站的虚线距离
            showLandStation();
            gMapControl1.Refresh();
        }

        // 全部飞机展示
        private void showAllPalne()
        {
            if (!airPlaneShow)
            {
                return;
            }

            foreach (GMapAirPlane eachlistAirplane in listAirplane.Values)
            {
                showOnePlane(eachlistAirplane);
            }
        }

        private void showOnePlane(GMapAirPlane eachlistAirplane)
        {
            if (!airPlaneShow)
            {
                return;
            }

            // 没有航迹圈控制，直接显示
            if (!flightCircle)
            {
                showPorintInMap(eachlistAirplane);
                return;
            }

            // 只展示航迹圈内的飞机
            if (currentFellowId <= 0)
            {
                return;
            }

            List<Dictionary<string, object>> result =
                ProfileHelper.Instance.Select("SELECT * FROM PlaneFollow WHERE ID = " + currentFellowId);
            // 没查到勾选记录
            if(null == result || result.Count() == 0)
            {
                return;
            }
                
            Dictionary<string, object> dictionary = result[0];
            int type = Convert.ToInt32(dictionary["Type"]);
            // 展示半径
            double length = Convert.ToDouble(dictionary["Length"]);
            // 查到的显示半径为0
            if (length <= 0)
            {
                return;
            }

            double lat = 0.0;
            double lang = 0.0;
            // 飞行器
            if (1 == type)
            {
                // 根据S地址查找最新的地址
                List<Cat021Data> list = AirplaneManager.Instance.Query(Convert.ToInt32(dictionary["IDNum"]), null, 0, 0, 0, 0);
                if (list.Count() > 0)
                {
                    Cat021Data data = list[0];
                    lat = data.latitude;
                    lang = data.longtitude;
                }
                else
                {
                    return;
                }
            }
            else
            {
                // 根据id查出地面站信息
                List<Dictionary<string, object>> stationList = ProfileHelper.Instance.Select(
                    "SELECT * FROM LandStation WHERE ID = " + dictionary["IDNum"]);
                if (stationList.Count() > 0)
                {
                    Dictionary<string, object> station = stationList[0];
                    lat = Convert.ToDouble(station["Lat"]);
                    lang = Convert.ToDouble(station["Lng"]);
                }
                else
                {
                    return;
                }
            }

            showFlightCircle(lat, lang, (int)length);

            // 只展示圈内的飞机
            double disPlane = CommonHelper.Distance(
                lat, 
                lang,
                eachlistAirplane.AirPlaneMarkerInfo.latitude, 
                eachlistAirplane.AirPlaneMarkerInfo.longtitude);

            if (disPlane <= length)
            {
                showPorintInMap(eachlistAirplane);
            }
        }

        // 展示航迹圈圆
        private void showFlightCircle(double lat, double lang, int length)
        {
            PointLatLng point1 = new PointLatLng(lat, lang);
            GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point1, length);
            planeOverlay.Markers.Add(gMapMarkerCircle);
        }

        private void showPorintInMap(GMapAirPlane eachlistAirplane)
        {
            // 展示飞机
            planeOverlay.Markers.Add(eachlistAirplane);
            // 展示轨迹点
            showHisPorint(eachlistAirplane.AirPlaneMarkerInfo.sModeAddress);
        }


        private void showHisPorint(int sModeAddress)
        {
            // 展示飞机时才显示轨迹
            if (airPlaneShow)
            {
                String comboBox = ConfigHelper.Instance.GetConfig("show_num");
                if (string.IsNullOrEmpty(comboBox))
                {
                    planeOverlay.Routes.Clear();
                    return;
                }
                int showNum = Convert.ToInt32(comboBox);
                if (showNum <= 0)
                {
                    planeOverlay.Routes.Clear();
                    return;
                }
                //int sModeAddress = eachlistAirplane.AirPlaneMarkerInfo.sModeAddress;
                if (keyValuePairs.ContainsKey(sModeAddress) && !pointPlaneLand.ContainsKey(sModeAddress))
                {
                    List<PointLatLng> points = keyValuePairs[sModeAddress];
                    List<PointLatLng> pointsShow = new List<PointLatLng>();
                    int begin = points.Count() - showNum - 1;
                    if (begin < 0)
                    {
                        begin = 0;
                    }
                    /*Brush brush = new SolidBrush(Color.DarkOliveGreen);
                    for (int i = begin; i < points.Count() - 1; i++)
                    {
                        GMapMarkerPoint gMapMarkerPoint = new GMapMarkerPoint(points[i], brush);
                        planeOverlay.Markers.Add(gMapMarkerPoint);
                        //pointsShow.Add(points[i]);
                    }*/
                    GMapRoute r = new GMapRoute(pointsShow, "");
                    r.Stroke = new Pen(Color.Green, 1);
                    planeOverlay.Routes.Add(r);
                    this.gMapControl1.Refresh();
                }
                
            }
        }

        // 展示关注飞机与指定地面站的虚线距离
        private void showLandStation()
        {
            // 获取地面站信息
            bool hasLandStation = false;
            String name = ConfigHelper.Instance.GetConfig("land_station_main_name");
            
            PointLatLng pointLandStation = new PointLatLng(0, 0);
            if (!string.IsNullOrWhiteSpace(name))
            {
                hasLandStation = true;
                double lat = Convert.ToDouble(ConfigHelper.Instance.GetConfig("land_station_main_lat"));
                double lang = Convert.ToDouble(ConfigHelper.Instance.GetConfig("land_station_main_log"));
                pointLandStation = new PointLatLng(lat, lang);
            }

            // 只展示主地面站与凸显飞机的距离
            if (hasLandStation)
            {
                if (landStation && pointPlaneLand.Count > 0)
                {
                    pointLandOverlay.Clear();
                    gMapControl1.Overlays.Add(pointLandOverlay);
                    foreach (KeyValuePair<int, PointLatLng> kvp in pointPlaneLand)
                    {
                        PointLatLng pointLatLngPlane = kvp.Value;
                        double dis = CommonHelper.Distance(pointLandStation.Lat, pointLandStation.Lng, pointLatLngPlane.Lat, pointLatLngPlane.Lng);
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
                    }
                }
                else
                {
                    gMapControl1.Overlays.Remove(pointLandOverlay);
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
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

            currentFellowId = Convert.ToInt32(ConfigHelper.Instance.GetConfig("currentFellowId"));
            String airPlaneShowNeedShow = ConfigHelper.Instance.GetConfig("airPlaneShowNeedShow");
            airPlaneShow = airPlaneShowNeedShow == null ? false : airPlaneShowNeedShow.Equals("1") ? true : false;
            String landStationNeedShow = ConfigHelper.Instance.GetConfig("landStationNeedShow");
            landStation = landStationNeedShow == null ? false : landStationNeedShow.Equals("1") ? true : false;
            String airPortNeedShow = ConfigHelper.Instance.GetConfig("airPortNeedShow");
            airPort = airPortNeedShow == null ? false : airPortNeedShow.Equals("1") ? true : false;
            String wayPointNeedShow = ConfigHelper.Instance.GetConfig("wayPointNeedShow");
            wayPoint = wayPointNeedShow == null ? false : wayPointNeedShow.Equals("1") ? true : false;
            String airSegmentNeedShow = ConfigHelper.Instance.GetConfig("airSegmentNeedShow");
            airSegment = airSegmentNeedShow == null ? false : airSegmentNeedShow.Equals("1") ? true : false;
            String airSpaceNeedShow = ConfigHelper.Instance.GetConfig("airSpaceNeedShow");
            airSpace = airSpaceNeedShow == null ? false : airSpaceNeedShow.Equals("1") ? true : false;
            String flightCircleNeedShow = ConfigHelper.Instance.GetConfig("flightCircleNeedShow");
            flightCircle = flightCircleNeedShow == null ? false : flightCircleNeedShow.Equals("1") ? true : false;
            String landDistenceCircleNeedShow = ConfigHelper.Instance.GetConfig("landDistenceCircleNeedShow");
            landDistenceCircle = landDistenceCircleNeedShow == null ? false : landDistenceCircleNeedShow.Equals("1") ? true : false;
            String airPortDistenceCircleNeedShow = ConfigHelper.Instance.GetConfig("airPortDistenceCircleNeedShow");
            airPortDistenceCircle = airPortDistenceCircleNeedShow == null ? false : airPortDistenceCircleNeedShow.Equals("1") ? true : false;
            String airRouteNeedShow = ConfigHelper.Instance.GetConfig("airRouteNeedShow");
            airRoute = airRouteNeedShow == null ? false : airRouteNeedShow.Equals("1") ? true : false;
        }

        //飞行模式按钮
        private void sPnl_Fly_Click(object sender, EventArgs e)
        {
            //显示飞行模式界面
            //flyTimer.Stop();
            //CommSocketManager.Stop();
            //this.sTabControl.SelectedIndex = 0;
        }

        //飞行监控按钮
        private void sPanelMonitor_Click(object sender, EventArgs e)
        {
            //显示飞行监控界面
           // this.sTabControl.SelectedIndex = 1;
            //CommSocketManager.Start();
            //flyTimer.Interval = 1000;
            //flyTimer.Start();
        }

        #region GMap控件相关操作
        //private GMapOverlay planeOverlay = new GMapOverlay("planeLayer"); //放置marker的图层
        private void InitializeGMap()
        {
            this.gMapControl1.CacheLocation = System.Windows.Forms.Application.StartupPath;    //缓冲区路径
            // this.gMapControl1.MapProvider = GMapProviders.GoogleChinaMap;                      //谷歌中国区地图加载
            // this.gMapControl1.Manager.Mode = AccessMode.ServerAndCache;                        //服务+缓冲
            this.gMapControl1.MapProvider = AMapProvider.Instance;                             //高德地图加载
            this.gMapControl1.Manager.Mode = AccessMode.ServerAndCache;                        //地图缓冲
            //Environment.CurrentDirectory
            String mapPath = Environment.CurrentDirectory + "\\MapDownloader\\bin\\Release\\MapCache\\TileDBv5\\en\\Data.gmdb";
            GMap.NET.GMaps.Instance.ImportFromGMDB(mapPath);
            this.gMapControl1.MinZoom = 1;                                                     //最小比例
            this.gMapControl1.MaxZoom = 23;                                                    //最大比例
            this.gMapControl1.Zoom = 10;                                                       //当前比例
            this.gMapControl1.ShowCenter = false;                                              //不显示中心十字点
            this.gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;             //左键拖拽地图
            this.gMapControl1.Position = new PointLatLng(23.16, 113.27);                       //初始化地址 广州(23.16, 113.27) 北京(39.3, 116.5)
            
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
            AirplaneManager.Instance.Clear();
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
                airRoute.airRoute_event += new Form_airRoute.airRoute(frm_changebox12_event);

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

        /**
         * 告警
         * */
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

        /**
         * 常用飞行器
         * */
        private void skinLabel34_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_setup setup = new Form_setup();
                setup.commonPlane_event += new Form_setup.commonPlane(common_Plane_event);
                setup.ShowDialog();
                mapmask.Visible = false;
            }
        }

        void common_Plane_event(Boolean selected)
        {
            initListAirplaneCheck(false);
        }

        // 关注的目标单元格点击事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected)
            {
                if (null != dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    string cell = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    ProfileHelper.Instance.Update("UPDATE PlaneFollow SET Length = " + cell + " WHERE ID = " + id);
                }
            }
        }

        // 关注的目标单元格点击事件
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0)
            {
                return;
            }
            int index = dataGridView1.CurrentRow.Index;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            if (!Convert.ToBoolean(dataGridView1.Rows[index].Cells[0].Value))
            {
                dataGridView1.Rows[index].Cells[0].Value = true;
                currentFellowId = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                ConfigHelper.Instance.SetConfig("currentFellowId", currentFellowId.ToString());
                //其他的都是false
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i != index)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }
            }
            else
            {
                dataGridView1.Rows[index].Cells[0].Value = false;
            }
        }

        private void spMax_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void spMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void spClose_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //skinEngine1.SkinFile = Application.StartupPath + @"\DeepCyan.ssk";
        }

        private void skinLabel14_Click(object sender, EventArgs e)
        {
            string path1 = Environment.CurrentDirectory + "\\MapDownloader\\bin\\Release\\MapDownloader.exe";  //打开D盘下的log.txt文件
            System.Diagnostics.Process.Start(path1);
        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {
            
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_status statusForm = new Form_status();
                statusForm.ShowDialog();
                mapmask.Visible = false;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            skinPanel15.Left = this.Width - 50 - skinPanel15.Width;
            skinPanel3.Left = skinPanel15.Left - skinPanel3.Width + skinPanel15.Width;
            button1.Left = skinPanel15.Left;
            button2.Left = skinPanel15.Left;

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

public class Common_Plane
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
    private String sModeAddress;
    public String SModeAddress
    {
        get { return sModeAddress; }
        set { sModeAddress = value; }
    }

    public Common_Plane(int id, String name, String sModeAddress)
    {
        this.id = id;
        this.name = name;
        this.sModeAddress = sModeAddress;
    }
}