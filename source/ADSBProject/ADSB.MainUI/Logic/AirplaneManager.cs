using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ADSB.MainUI
{
    public class AirplaneManager
    {
        private static AirplaneManager instance;
        private List<Cat021Data> airplaneList;
        // 告警飞机列表
        private Dictionary<int, int> listAirplaneAlarm = new Dictionary<int, int>();

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
                    check(data);
                    return false;
                }
            }
            airplaneList.Add(data);
            check(data);
            return true;
        }

        private void check(Cat021Data data)
        {
            String distance = ConfigHelper.Instance.GetConfig("alarm_distance");
            if (!string.IsNullOrWhiteSpace(distance))
            {
                double alarm_distance = Convert.ToDouble(distance);
                List<Cat021Data> t2 = new List<Cat021Data>(airplaneList.ToArray()); // copy of airplaneList

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = Environment.CurrentDirectory + "\\UIDesign\\监控模式pc\\assets\\alarm.wav";
                player.Load(); //同步加载声音


                // 在这里做告警，最新的更新机器跟其他飞机是否低于阈值
                foreach (Cat021Data item in t2)
                {
                    double myDistance = CommonHelper.Distance(item.latitude, item.longtitude, data.latitude, data.longtitude);
                    if (myDistance > 0.01 && alarm_distance >= myDistance)
                    {
                        String info = "距离报警！" + item.sModeAddress.ToString() + "跟中心机距离：" + data.sModeAddress.ToString();
                        ProfileHelper.Instance.Update("INSERT INTO Alarm (" +
                            "FlightNo, SModeAddress, SModeAddressTo, Info, WriteTime, Status) VALUES ('" +
                            data.flightNo.ToString().Trim() + "', '" +
                            data.sModeAddress + "', '" +
                            item.sModeAddress + "', '" +
                            info + "', '" + DateTime.Now.ToString() + "', 0)");

                        addAlermList(data.sModeAddress);
                        addAlermList(item.sModeAddress);

                        if ("YES".Equals(ConfigHelper.Instance.GetConfig("alarm_type1")))
                        {
                            System.Windows.Forms.MessageBox.Show(info);
                        }
                        if ("YES".Equals(ConfigHelper.Instance.GetConfig("alarm_type2")))
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            player.Play(); //启用新线程播放
                        }
                    }
                    else
                    {
                        ProfileHelper.Instance.Update("Update Alarm Set Status = 1 WHERE SModeAddress = '" +
                           data.sModeAddress + "' AND SModeAddressTo = '" + item.sModeAddress + "'");

                        subAlermList(data.sModeAddress);
                        subAlermList(item.sModeAddress);
                    }
                }
            }
        }

        private void addAlermList(int sModeAddress)
        {
            if (listAirplaneAlarm.ContainsKey(sModeAddress))
            {
                int num = listAirplaneAlarm[sModeAddress];
                listAirplaneAlarm[sModeAddress] =  num + 1;
            }
            else
            {
                listAirplaneAlarm.Add(sModeAddress, 1);
            }
        }

        private void subAlermList(int sModeAddress)
        {
            if (listAirplaneAlarm.ContainsKey(sModeAddress))
            {
                int num = listAirplaneAlarm[sModeAddress];
                if (num > 1)
                {
                    listAirplaneAlarm[sModeAddress] = num - 1;
                }
                else
                {
                    listAirplaneAlarm.Remove(sModeAddress);
                }
            }
        }

        public Boolean checkAlermPlane(int sModeAddress)
        {
            if (listAirplaneAlarm.ContainsKey(sModeAddress))
            {
                return true;
            }
            return false;
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
