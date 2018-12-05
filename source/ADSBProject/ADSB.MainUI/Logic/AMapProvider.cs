using System;
using System.Data;
using System.Data.SQLite;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.Projections;

namespace ADSB.MainUI
{
    public class AMapProvider : AMapProviderBase
    {
        private readonly string name = "AMap";
        private readonly string language = "zh_cn";
        //private readonly Guid id = new Guid("F81F5FB4-0902-4686-BF5B-B2B1E4D47922");
        private readonly Guid id = new Guid("EF3DD303-3F74-4938-BF40-232D0595EE88");
        public static readonly AMapProvider Instance;
        private Random ran = new Random();
        private static string UrlFormat = "http://webrd0{0}.is.autonavi.com/appmaptile?lang=zh_cn&size=1&style=7&x={1}&y={2}&z={3}&scale=1&ltype=3";
        public string Caption
        {
            get
            {
                return "高德地图";
            }
        }
        public override Guid Id
        {
            get { return this.id; }
        }

        public override string Name
        {
            get { return this.name; }
        }

        static AMapProvider()
        {
            Instance = new AMapProvider();
        }
        public AMapProvider()
        {

        }

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            string url = MakeTileImageUrl(pos, zoom, language);
            return GetTileImageUsingHttp(url);
        }
        //http://wprd0{0}.is.autonavi.com/appmaptile?lang=zh_cn&size=1&style=7&x={1}&y={2}&z={3}&scl=2&ltype=3
        private string MakeTileImageUrl(GPoint pos, int zoom, string language)
        {
            int serverID = ran.Next(1, 5);//1-4 
            return string.Format(UrlFormat, 4, pos.X, pos.Y, zoom);
        }
    }


    public abstract class AMapProviderBase : GMapProvider
    {
        protected GMapProvider[] overlays;
        public AMapProviderBase()
        {
            RefererUrl = "http://www.amap.com/";
            Copyright = string.Format("©{0} 高德地图 GPRS(@{0})", DateTime.Today.Year);
            MinZoom = 1;
            MaxZoom = 20;
        }

        public override GMapProvider[] Overlays
        {
            get
            {
                if (overlays == null)
                {
                    overlays = new GMapProvider[] { this };
                }
                return overlays;
            }
        }

        public override PureProjection Projection
        {
            get
            {
                return MercatorProjection.Instance;
            }
        }
    }
}
