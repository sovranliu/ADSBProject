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
        private void sPnl_funcmore_Paint(object sender, PaintEventArgs e)
        {
            //消除锯齿
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //绘制圆底盘
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.FillEllipse(brush, 0, 0, 59, 59);

            //绘制文字
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 0, 0x5D, 0xC9));
            Font textFont = new Font("微软雅黑", 32, FontStyle.Bold, GraphicsUnit.Document);
            e.Graphics.DrawString("更多", textFont, textBrush, 18, 36);

        }

        #region 各个按钮菜单点击功能
        //模式按钮
        private void sLabel_Mode_Click(object sender, EventArgs e)
        {
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_setup2();
                test.Location = new Point(this.Location.X + 515, this.Location.Y + 160);
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //设置按钮
        private void sLabel_Set1_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"设置\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_setup1();
                test.Location = new Point(this.Location.X + 515, this.Location.Y + 160);
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //飞行器过滤按钮
        private void sLabel_flyFilter_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"飞行器过滤\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_flyFilter test = new Form_flyFilter();
                test.Location = new Point(this.Location.X + 50, this.Location.Y + 16);
                test.ShowDialog();

                mapmask.Visible = false;
            }
        }

        //报警按钮
        private void sLabel_alarm_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"告警\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_alarm();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //工具按钮
        private void sLabel_Tool_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"工具\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form_mapTool test = new Form_mapTool();

                test.changebox2_event += new Form_mapTool.changebox2(frm_changebox2_event);
                // 初始化飞机场checkbox
                if (airSpace)
                {
                    test.myCheckBox2_Selected();
                }

                test.changebox3_event += new Form_mapTool.changebox3(frm_changebox3_event);
                // 初始化航段checkbox
                if (airSegment)
                {
                    test.myCheckBox3_Selected();
                }

                test.changebox4_event += new Form_mapTool.changebox4(frm_changebox4_event);
                // 初始化飞机场checkbox
                if (airPort)
                {
                    test.myCheckBox4_Selected();
                }

                test.changebox5_event += new Form_mapTool.changebox5(frm_changebox5_event);
                // 初始化航站点checkbox
                if (wayPoint)
                {
                    test.myCheckBox5_Selected();
                }

                test.changebox7_event += new Form_mapTool.changebox7(frm_changebox7_event);
                // 初始化地面站checkbox
                if (landStation)
                {
                    test.myCheckBox7_Selected();
                }

                test.changebox9_event += new Form_mapTool.changebox9(frm_changebox9_event);
                //初始化航迹圈checkbox
                if (flightCircle)
                {
                    test.myCheckBox9_Selected();
                }

                test.changebox10_event += new Form_mapTool.changebox10(frm_changebox10_event);
                //初始化航迹圈checkbox
                if (landDistenceCircle)
                {
                    test.myCheckBox10_Selected();
                }

                test.changebox11_event += new Form_mapTool.changebox11(frm_changebox11_event);
                //初始化航迹圈checkbox
                if (airPortDistenceCircle)
                {
                    test.myCheckBox11_Selected();
                }

                test.ShowDialog();
                mapmask.Visible = false;
            }
        }

        /*
        * 空域box
        * */
        void frm_changebox2_event(Boolean selected, int flag)
        {
            if (selected || (2 == flag && airSpace == true))
            {
                airSpace = true;
                airSpaceOverlay.Clear();
                this.gMapControl1.Overlays.Add(airSpaceOverlay);

                listAirSpace = new List<String>();
                List<Dictionary<string, object>> nameResult = ProfileHelper.Instance.Select("SELECT DISTINCT Name FROM AirSpace");
                foreach (Dictionary<string, object> dictionary in nameResult)
                {
                    String name = Convert.ToString(dictionary["Name"]);
                    listAirSpace.Add(name);
                }

                foreach (String name in listAirSpace)
                {
                    List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSpace WHERE Name = \"" + name + "\"");
                    if (result.Count > 0)
                    {
                        int type = Convert.ToInt16(result[0]["Type"]);
                        if (1 == type)
                        {
                            // 圆形
                            double t = Convert.ToDouble(result[0]["Lat"]);
                            double g = Convert.ToDouble(result[0]["Lng"]);
                            double radius = Convert.ToDouble(result[0]["Radius"]);
                            PointLatLng point = new PointLatLng(t, g);
                            GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point, (int)radius);
                            airSpaceOverlay.Markers.Add(gMapMarkerCircle);
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
                            airSpaceOverlay.Polygons.Add(polygon);
                        }
                    }
                }
                
                gMapControl1.Refresh();
            }
            else
            {
                if (1 == flag)
                {
                    airSpace = false;
                    airSpaceOverlay.Clear();
                    this.gMapControl1.Overlays.Remove(airSpaceOverlay);
                    gMapControl1.Refresh();
                }
            }
        }

        /*
         * 航段box
         * */
        void frm_changebox3_event(Boolean selected, int flag)
        {
            if (selected || (2 == flag && airPort == true))
            {
                airSegment = true;
                airSegmentOverlay.Clear();
                this.gMapControl1.Overlays.Add(airSegmentOverlay);

                //获取最新的航段、航站点
                listAirSegment = new List<GMapAirSegment>();
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSegment");
                foreach (Dictionary<string, object> dictionary in result)
                {
                    String name = Convert.ToString(dictionary["Name"]);
                    String beginWayPoint = Convert.ToString(dictionary["BeginWayPoint"]);
                    GMapWayPoint begin = getGMapWayPointByName(beginWayPoint);
                    String endWayPoint = Convert.ToString(dictionary["EndWayPoint"]);
                    GMapWayPoint end = getGMapWayPointByName(endWayPoint);
                    GMapAirSegment airSegment = new GMapAirSegment(name, begin, end);
                    listAirSegment.Add(airSegment);
                }

                foreach (GMapAirSegment airSegmentl in listAirSegment)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(airSegmentl.pStart.Position);
                    points.Add(airSegmentl.pEnd.Position);
                    GMapPolygon polygon = new GMapPolygon(points, airSegmentl.name);
                    polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    polygon.Stroke = new Pen(Color.Red, 1);
                    airSegmentOverlay.Polygons.Add(polygon);
                }
                
                gMapControl1.Refresh();
            }
            else
            {
                if (1 == flag)
                {
                    airSegment = false;
                    airSegmentOverlay.Clear();
                    this.gMapControl1.Overlays.Remove(airSegmentOverlay);
                    gMapControl1.Refresh();
                }
            }
        }

        /**
         * 根据航站点名称获得航站点信息
         * */
        private GMapWayPoint getGMapWayPointByName(String name)
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM WayPoint WHERE Name = '" + name + "'");
            double lat = Convert.ToDouble(result[0]["Lat"]);
            double lang = Convert.ToDouble(result[0]["Lng"]);
            GMapWayPoint way_Point = new GMapWayPoint(new PointLatLng(lat, lang), name);
            return way_Point;
        }

        /*
         * 机场box
         * */
        void frm_changebox4_event(Boolean selected, int flag)
        {
            if (selected || (2 == flag && airPort == true))
            {
                airPort = true;
                airPortOverlay.Clear();
                this.gMapControl1.Overlays.Add(airPortOverlay);

                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirPort");
                foreach (Dictionary<string, object> dictionary in result)
                {
                    String name = Convert.ToString(dictionary["Name"]);
                    double lat = Convert.ToDouble(dictionary["Lat"]);
                    double lang = Convert.ToDouble(dictionary["Lng"]);
                    PointLatLng point = new PointLatLng(lat, lang);
                    GMapAirPort gMapAirSegment = new GMapAirPort(point, name);
                    airPortOverlay.Markers.Add(gMapAirSegment);
                }
                
                gMapControl1.Refresh();

                // 是否要显示距离环
                frm_changebox11_event(airPortDistenceCircle);
            }
            else
            {
                if (1 == flag)
                {
                    airPort = false;
                    airPortOverlay.Clear();
                    this.gMapControl1.Overlays.Remove(airPortOverlay);
                    gMapControl1.Refresh();
                }
            }
        }

        /*
        * 航站点box
        * */
        void frm_changebox5_event(Boolean selected, int flag)
        {
            if (selected || (2 == flag && wayPoint == true))
            {
                wayPoint = true;
                wayPointOverlay.Clear();
                this.gMapControl1.Overlays.Add(wayPointOverlay);

                listWayPoint = new List<GMapWayPoint>();
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM WayPoint");
                foreach (Dictionary<string, object> dictionary in result)
                {
                    String name = Convert.ToString(dictionary["Name"]);
                    double lat = Convert.ToDouble(dictionary["Lat"]);
                    double lang = Convert.ToDouble(dictionary["Lng"]);
                    PointLatLng point = new PointLatLng(lat, lang);
                    GMapWayPoint gMapWayPoint = new GMapWayPoint(point, name);
                    listWayPoint.Add(gMapWayPoint);
                }

                foreach (GMapWayPoint wayPoint in listWayPoint)
                {
                    wayPointOverlay.Markers.Add(wayPoint);
                }
                
                gMapControl1.Refresh();
            }
            else
            {
                if (1 == flag)
                {
                    wayPoint = false;
                    wayPointOverlay.Clear();
                    this.gMapControl1.Overlays.Remove(wayPointOverlay);
                    gMapControl1.Refresh();
                }
            }
        }

        /**
         * 地面站box
         * */
        void frm_changebox7_event(Boolean selected, int flag)
        {
            if (selected)
            {
                if (1 == flag || (2 == flag && landStation == true))
                {
                    landStation = true;
                    landStationOverlay.Clear();
                    this.gMapControl1.Overlays.Add(landStationOverlay);

                    List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM LandStation");
                    
                    foreach (Dictionary<string, object> dictionary in result)
                    {
                        String name = Convert.ToString(dictionary["Name"]);
                        double lat = Convert.ToDouble(dictionary["Lat"]);
                        double lang = Convert.ToDouble(dictionary["Lng"]);
                        PointLatLng point = new PointLatLng(lat, lang);
                        GMapLandStation gMapLandStation = new GMapLandStation(point, name);
                        landStationOverlay.Markers.Add(gMapLandStation);
                    }
                    
                    gMapControl1.Refresh();

                    // 是否要显示距离环
                    frm_changebox10_event(landDistenceCircle);
                }
            }
            else
            {
                if (1 == flag)
                {
                    landStation = false;
                    landStationOverlay.Clear();
                    this.gMapControl1.Overlays.Remove(landStationOverlay);
                    gMapControl1.Refresh();
                }
            }
        }

        // 航迹圈
        void frm_changebox9_event(Boolean selected)
        {
            if (selected)
            {
                flightCircle = true;
            }
            else
            {
                flightCircle = false;
            }
        }

        // 地面站距离环
        void frm_changebox10_event(Boolean selected)
        {
            if (selected)
            {
                landDistenceCircle = true;
                landCircleOverlay.Clear();
                this.gMapControl1.Overlays.Add(landCircleOverlay);
                if (landStation)
                {
                    List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM LandStation");
                    foreach (Dictionary<string, object> dictionary in result)
                    {
                        String name = Convert.ToString(dictionary["Name"]);
                        double lat = Convert.ToDouble(dictionary["Lat"]);
                        double lang = Convert.ToDouble(dictionary["Lng"]);
                        double length = Convert.ToDouble(dictionary["Length"]);
                        int num = Convert.ToInt16(dictionary["Num"]);
                        while (num > 0)
                        {
                            PointLatLng point = new PointLatLng(lat, lang);
                            GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point, (int)length * num);
                            landCircleOverlay.Markers.Add(gMapMarkerCircle);
                            num--;
                        }
                    }
                }
            }
            else
            {
                landDistenceCircle = false;
                landCircleOverlay.Clear();
                this.gMapControl1.Overlays.Remove(landCircleOverlay);
            }
            gMapControl1.Refresh();
        }

        // 机场距离环
        void frm_changebox11_event(Boolean selected)
        {
            if (selected)
            {
                airPortDistenceCircle = true;
                flightCircleOverlay.Clear();
                this.gMapControl1.Overlays.Add(flightCircleOverlay);

                if (airPort)
                {
                    List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirPort");
                    foreach (Dictionary<string, object> dictionary in result)
                    {
                        String name = Convert.ToString(dictionary["Name"]);
                        double lat = Convert.ToDouble(dictionary["Lat"]);
                        double lang = Convert.ToDouble(dictionary["Lng"]);
                        double length = Convert.ToDouble(dictionary["Length"]);
                        int num = Convert.ToInt16(dictionary["Num"]);
                        while (num > 0)
                        {
                            PointLatLng point = new PointLatLng(lat, lang);
                            GMapMarkerCircle gMapMarkerCircle = new GMapMarkerCircle(point, (int)length * num);
                            flightCircleOverlay.Markers.Add(gMapMarkerCircle);
                            num--;
                        }
                    }
                }
            }
            else
            {
                airPortDistenceCircle = false;
                flightCircleOverlay.Clear();
                this.gMapControl1.Overlays.Remove(flightCircleOverlay);
            }
            gMapControl1.Refresh();
        }

        //地面站
        private void sPnl_dimianzhan_Click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"地面站\"按钮");
            

        }

        //导航管理按钮
        private void sLabel_guideManagement_Click(object sender, EventArgs e)
        {

        }

        //飞行计划按钮
        private void sPnl_flyPlan_click(object sender, EventArgs e)
        {
            log.Writelogs("点击了\"飞行计划\"按钮");
            if (!IsPlayback)
            {
                ShowMaskLayerWindow();

                Form test = new Form_guideResourceAdd();
                test.ShowDialog();
                mapmask.Visible = false;
            }

        }

        //启动回放蒙版按钮
        private void sPnl_playback_click(object sender, EventArgs e)
        {
            //log.Writelogs("点击了\"回放\"按钮");
            if (IsPlayback)
            {
                IsPlayback = false;
                panelEx1.Visible = false;
                maskPlaybackSetup.Visible = false;
                maskPlaybackRun.Visible = false;
                skinProgressBar1.Visible = false;
                StopPlayBack();
            }
            else   //显示回放框
            {
                IsPlayback = true;
                maskPlaybackSetup.Title = "回放设置";
                panelEx1.Visible = true;
                panelEx1.BackColor = Color.FromArgb(115, 0, 0, 0);
                panelEx1.Refresh();
                maskPlaybackSetup.Visible = true;
                maskPlaybackSetup.Refresh();
                maskPlaybackRun.Visible = true;
                maskPlaybackRun.Refresh();
                skinProgressBar1.Visible = true;
            }
        }

        /** 
        //回放启动按钮
        private void maskPlaybackRun_Click(object sender, EventArgs e)
        {
            //点击了“开始回放”按钮
            //MessageBox.Show("开始回放！");
            timerSPBarPlayback.Enabled = true;
            timerSPBarPlayback.Interval = 100;
            skinProgressBar1.Value = 0;

        }

        //回放设置按钮
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
        }*/
        #endregion

        //飞行监控模式下显示弹窗蒙版
        private void ShowMaskLayerWindow()
        {
            if (!IsPlayback)
            {
                mapmask.Location = new Point(0, 0);
                mapmask.Size = new Size(1280, 752);
                mapmask.BackColor = Color.FromArgb(115, 0, 0, 0);
                mapmask.Visible = true;
            }
        }

        /*
        //绘制回放蒙版及按钮菜单
        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {
            //该处绘制不容易添加的控件

            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Font textFont = new Font("微软雅黑", 42, FontStyle.Regular, GraphicsUnit.Document);
            e.Graphics.DrawString("回放设置", textFont, textBrush, 31, 43);
        }
    */


        private void sMonitor_MouseDown(object sender, MouseEventArgs e)
        {
            // todo 这里记录下点击事件，将飞机的信息获取到之后，加入监控列表
            formerPoint = Cursor.Position;
        }
        

    }


}
