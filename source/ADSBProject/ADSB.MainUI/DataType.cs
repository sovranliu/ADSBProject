using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSB.MainUI
{
    public struct AirplaneInfo
    {
        public AirplaneInfo(string _fid, string _gv, string _height, string _speed, String _sModeAddress)
        {
            fid = _fid;
            gv = _gv;
            height = _height;
            speed = _speed;
            sModeAddress = _sModeAddress;
        }
        // flightNo
        public string fid;
        // aircraftAngle
        public string gv;
        // geometricAltitude-几何高度
        public string height;
        // airSpeed-空速
        public string speed;
        public string sModeAddress;
    }

    public struct AirPortInfo
    {
        public AirPortInfo(string _fid, string _gv, string _height, string _speed)
        {
            fid = _fid;
            gv = _gv;
            height = _height;
            speed = _speed;
        }
        public string fid;
        public string gv;
        public string height;
        public string speed;
    }

    public struct ErrorInfo
    {
        public ErrorInfo(string _time, string _obj, string _type, string _level, string _info)
        {
            time = _time;
            obj = _obj;
            type = _type;
            level = _level;
            info = _info;
        }
        public readonly string time;
        public readonly string obj;
        public readonly string type;
        public readonly string level;
        public readonly string info;
    }
}
