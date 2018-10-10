using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSB.MainUI
{
    public class AirplaneManager
    {
        private static AirplaneManager instance;
        private List<Cat021Data> airplaneList; 

        public static AirplaneManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = (new AirplaneManager()).Prepare();
                }
                return instance;
            }
        }

        private AirplaneManager Prepare()
        {
            airplaneList = new List<Cat021Data>();
            return this;
        }

        public void Destroy()
        {
            airplaneList.Clear();
            instance = null;
        }

        public List<Cat021Data> AirplaneList
        {
            get
            {
                return airplaneList;
            }
        }

        public void Clear()
        {
            airplaneList.Clear();
        }

        public bool Add(Cat021Data data)
        {
            foreach (Cat021Data item in airplaneList)
            {
                if (data.sModeAddress == item.sModeAddress)
                {
                    airplaneList.Remove(item);
                    airplaneList.Add(data);
                    return false;
                }
            }
            airplaneList.Add(data);
            return true;
        }

        public List<Cat021Data> Query(int sModeAddress, string flightNo, double airSpeedMin, double airSpeedMax, double geometricAltitudeMin, double geometricAltitudeMax)
        {
            List<Cat021Data> result = new List<Cat021Data>();
            foreach (Cat021Data item in airplaneList)
            {
                if(0 != sModeAddress && sModeAddress != item.sModeAddress)
                {
                    continue;
                }
                if (null != flightNo && !flightNo.Equals(item.flightNo))
                {
                    continue;
                }
                if(airSpeedMin > 0.001 && item.airSpeed < airSpeedMin)
                {
                    continue;
                }
                if (airSpeedMax > 0.001 && item.airSpeed > airSpeedMax)
                {
                    continue;
                }
                if (geometricAltitudeMin > 0.001 && item.geometricAltitude < geometricAltitudeMin)
                {
                    continue;
                }
                if (geometricAltitudeMax > 0.001 && item.geometricAltitude > geometricAltitudeMax)
                {
                    continue;
                }
                result.Add(item);
            }
            return result;
        }
    }
}
