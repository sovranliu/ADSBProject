using System;
using System.Collections.Generic;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.IO;

namespace ADSB.MainUI
{
    public class GMapMarkerCircle : GMapMarker
    {
        public int Radius;
        public PointLatLng P2;
        public bool IsMeter = true;
        public Pen Stroke = new Pen(Color.MidnightBlue, 1);

        public Brush Fill = new SolidBrush(Color.FromArgb(0, Color.AliceBlue));
        //public Brush Fill = new System.Drawing.SolidBrush(Color.AliceBlue); 
        public bool IsFilled = true;
        public GMapMarkerCircle(PointLatLng p, int radius) : base(p)
        {
            Radius = radius; // 0m
            P2 = p;
            IsHitTestVisible = false;
        }
        public override void OnRender(Graphics g)
        {
            if (!IsMeter)
                Radius = (int)Overlay.Control.MapProvider.Projection.GetDistance(Position, P2) * 1000;

            int R = (int)((Radius) / Overlay.Control.MapProvider.Projection.GetGroundResolution((int)Overlay.Control.Zoom, Position.Lat)) * 2;

            if (IsFilled)
            {
                g.FillEllipse(Fill, new System.Drawing.Rectangle(LocalPosition.X - R / 2, LocalPosition.Y - R / 2, R, R));
            }
            g.DrawEllipse(Stroke, new System.Drawing.Rectangle(LocalPosition.X - R / 2, LocalPosition.Y - R / 2, R, R));
        }
        public override void Dispose()
        {
            if (Stroke != null)
            {
                Stroke.Dispose();
                Stroke = null;
            }

            if (Fill != null)
            {
                Fill.Dispose();
                Fill = null;
            }

            base.Dispose();
        }
        public bool IsInside(PointLatLng p)
        {
            return (int)Overlay.Control.MapProvider.Projection.GetDistance(Position, p) * 1000 < Radius;
        }

    }

    public class GMapMarkerImage : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size = new Size(image.Width, image.Height);
                }
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        public Pen OutPen
        {
            get;
            set;
        }

        public GMapMarkerImage(GMap.NET.PointLatLng p, Image image)
             : base(p)
        {
            Size = new System.Drawing.Size(image.Width, image.Height);
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            this.image = image;
            Pen = null;
            OutPen = null;
            //this.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            this.ToolTipText = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", "CQH8992", "GV:95°", "H:4686m", "S:748km/h");
            this.ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        }

        public override void OnRender(Graphics g)
        {
            if (image == null)
                return;

            Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawImage(image, rect);

            if (Pen != null)
            {
                g.DrawRectangle(Pen, rect);
            }

            if (OutPen != null)
            {
                g.DrawEllipse(OutPen, rect);
                int tmpX = LocalPosition.X;
                int tmpY = LocalPosition.Y;

                for (int i = 2; i < 8; i++)
                {
                    tmpX = tmpX - Size.Width / 2;
                    tmpY = tmpY - Size.Height / 2;
                    Rectangle rect1 = new Rectangle(tmpX, tmpY, Size.Width * i, Size.Height * i);
                    g.DrawEllipse(OutPen, rect1);
                }
            }
        }

        public override void Dispose()
        {
            if (Pen != null)
            {
                Pen.Dispose();
                Pen = null;
            }

            if (OutPen != null)
            {
                OutPen.Dispose();
                OutPen = null;
            }

            base.Dispose();
        }

        public void ShowCircles()
        {
            if (OutPen != null)
            {
                return;
            }
            else
            {
                OutPen = new Pen(Brushes.Red, 2);
            }
        }
    }

    /// <summary>
    /// 飞机图标
    /// </summary>
    public class GMapAirPlane : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size = new Size(image.Width, image.Height);
                }
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        public Cat021Data AirPlaneMarkerInfo
        {
            get { return airplaneInfo; }
            set { airplaneInfo = value; }
        }

        private Cat021Data airplaneInfo;
        //TODO:
        public GMapAirPlane(PointLatLng p) : base(p)
        {
            Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\飞机 copy 4.png") as Bitmap;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);

            ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ToolTipText = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", "CQH8992", "GV:95°", "H:4686m", "S:748km/h");
            ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        }

        public GMapAirPlane(PointLatLng p, Cat021Data data, int selected) : base(p)
        {
            // 中心机 监控模式下作废了
            if (1 ==selected)
            {
                Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\飞机 copy 4@3x.png") as Bitmap;
            }
            // 关注机
            else if (2 == selected)
            {
                Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\飞机 copy 4@2x.png") as Bitmap;
            }
            // 告警机
            else if (3 == selected) 
            {
                Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\飞机 告警@2x.png") as Bitmap;
            }
            // 正常机
            else
            {
                Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\飞机 copy 4.png") as Bitmap;
            }
            
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);

            airplaneInfo = data;

            //ToolTipMode = MarkerTooltipMode.OnMouseOver;
            //ToolTipText = "S模式地址：" + data.sModeAddress.ToString() + "\r\n"
            //           // + "SSR: " + "0" + "\r\n"
            //            + "FID: " + data.flightNo.ToString() + "\r\n"
            //            + "经度: " + p.Lat.ToString() + "\r\n"
            //            + "纬度: " + p.Lng.ToString() + "\r\n"
            //            + "高度：" + data.geometricAltitude.ToString() + "\r\n";

            //ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
            

        }
        public override void OnRender(Graphics g)
        {
            if (image == null)
                return;

            Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawImage(image, rect);    //绘制飞机图标

            Rectangle rectDesc = new Rectangle(LocalPosition.X + Size.Width, LocalPosition.Y, 150, 60);
            Font Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold, GraphicsUnit.Pixel);
            //Brush Fill = new SolidBrush(Color.FromArgb(255, Color.Black));
            Brush Fill = new SolidBrush(Color.Red);
            string strDesc = string.Format("{0}\r\n GV:{1}°\r\nH: {2}m\r\nS：{3}km/h", 
                airplaneInfo.flightNo, 
                airplaneInfo.aircraftAngle, 
                airplaneInfo.geometricAltitude, 
                airplaneInfo.airSpeedUnit);
            //g.DrawString(strDesc, Font, Fill, rectDesc);    //显示飞机信息
        }

        public override void Dispose()
        {
            if (Pen != null)
            {
                Pen.Dispose();
                Pen = null;
            }
            base.Dispose();
        }


    }

    /// <summary>
    /// 机场图标
    /// </summary>
    public class GMapAirPort : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size = new Size(image.Width, image.Height);
                }
            }
        }

        public Pen Pen
        {
            get;
            set;
        }


        private AirPortInfo airPortInfo;
        //TODO:
        public GMapAirPort(PointLatLng p, String name) : base(p)
        {
            Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\airport_ic.png") as Bitmap;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);

            ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ToolTipText = string.Format("{0}\r\n{1}", name, p.Lat + "-" + p.Lng);
            ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        }

        /*
        public GMapAirPort(PointLatLng p) : base(p)
        {
            Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\直升机@3x.png") as Bitmap;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);
        }
        */

        public override void OnRender(Graphics g)
        {
            if (image == null)
                return;

            Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawImage(image, rect);

            /*
            if (Pen != null)
            {
                g.DrawEllipse(Pen, rect);
                int tmpX = LocalPosition.X;
                int tmpY = LocalPosition.Y;

                for (int i = 2; i < 8; i++)
                {
                    tmpX = tmpX - Size.Width / 2;
                    tmpY = tmpY - Size.Height / 2;
                    Rectangle rect1 = new Rectangle(tmpX, tmpY, Size.Width * i, Size.Height * i);
                    g.DrawEllipse(Pen, rect1);
                }
            }*/
        }
    }

   

    /// <summary>
    /// 天气图标
    /// </summary>
    public class GMapWeatherPoint : GMapMarker
    {
        public GMapWeatherPoint(PointLatLng p) : base(p)
        {
            //TODO
        }
    }

    /// <summary>
    /// 地面站图标
    /// </summary>
    public class GMapLandStation : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size = new Size(image.Width, image.Height);
                }
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public GMapLandStation(PointLatLng p, String name) : base(p)
        {
            this.name = name;
            Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\station_ic.png") as Bitmap;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);

            ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ToolTipText = string.Format("{0}\r\n{1}", name, p.Lat + "-" + p.Lng);
            ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        }
        public override void OnRender(Graphics g)
        {
            if (image == null)
                return;

            Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawImage(image, rect);
        }
    }

    /// <summary>
    /// 空域图标
    /// </summary>
    public class GMapAirSpace : GMapMarker
    {
        public GMapAirSpace(PointLatLng p) : base(p)
        {
            //TODO
        }
    }

    /// <summary>
    /// 航线 由2个以上航站点组成
    /// </summary>
    public class GMapAirRoute
    {
        public String name
        {
            get;
            set;
        }
        public List<GMapWayPoint> wayPointList
        {
            get;
            set;
        }

        public GMapAirRoute(String name, List<GMapWayPoint> wayPointList)
        {
            this.name = name;
            this.wayPointList = wayPointList;
        }
    }

    /// <summary>
    /// 航段 由两个航站点组成
    /// </summary>
    public class GMapAirSegment
    {
        public String name
        {
            get;
            set;
        }
        public GMapWayPoint pStart
        {
            get;
            set;
        }
        public GMapWayPoint pEnd
        {
            get;
            set;
        }

        public GMapAirSegment(String name, GMapWayPoint pStart, GMapWayPoint pEnd) 
        {
            this.name = name;
            this.pStart = pStart;
            this.pEnd = pEnd;
        }

    }

    /// <summary>
    /// 航路点图标
    /// </summary>
    public class GMapWayPoint : GMapMarker
    {
        private Image image;
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                if (image != null)
                {
                    this.Size = new Size(image.Width, image.Height);
                }
            }
        }

        public Pen Pen
        {
            get;
            set;
        }

        public GMapWayPoint(PointLatLng p, String name) : base(p)
        {
            Image = Bitmap.FromFile(Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\航路点图.png") as Bitmap;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            Pen = new Pen(Brushes.Red, 2);

            ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ToolTipText = string.Format("{0}\r\n{1}", name, p.Lat + "-" + p.Lng);
            ToolTip.Fill = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        }
        public override void OnRender(Graphics g)
        {
            if (image == null)
                return;

            Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawImage(image, rect);
        }
    }


}
