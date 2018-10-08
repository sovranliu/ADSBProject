using ADSB.MainUI.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace ADSB.MainUI
{
    [StructLayout(LayoutKind.Sequential)]
    public  struct Cat021Data
    {
        public int sModeAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string flightNo;
        public double latitude;
        public double longtitude;
        public double elapsedTime; // 从当日零时起，所消耗的时间，单位秒
        public double geometricAltitude; // 几何高度
        public double barometricAltitude; // 气压高度
        public double airSpeed; // 空速
        public Byte airSpeedUnit; // 空速单位
        public double aircraftAngle; // 飞行器航向
        public double groundSpeed; // 地速
        public Byte emitterCategory; // 飞行器类型
    }

    public static class CommWrapper
    {
        [DllImport(@"CCommLib.dll", EntryPoint = "decodeMessage", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool decodeMessage(Byte[] msg);
        [DllImport(@"CCommLib.dll", EntryPoint = "decodeCAT021V026", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr decodeCAT021V026(Byte[] msg);

        public static Cat021Data decode(Byte[] msg)
        {
            try
            {
                IntPtr ptr = CommWrapper.decodeCAT021V026(msg);
                Cat021Data outData = (Cat021Data)Marshal.PtrToStructure(ptr, typeof(Cat021Data));
                // Marshal.FreeHGlobal(ptr);
                return outData;
            }
            catch
            {
                Cat021Data exceptionData = new Cat021Data();
                exceptionData.flightNo = "CA0000";
                return (exceptionData);
            }
        }
    }

    public interface DataSource
    {
        bool Initialize();

        void Terminate();

        Cat021Data GetData();

        int Count { get; }
    }

    public class UDPDataSource : DataSource
    {
        private static Socket socket;
        private SQLiteConnection connection;
        private static Queue<Cat021Data> qData;
        private static bool isOn;
        private Thread thRec;

        public bool Initialize()
        {
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "\\data.db";
            connection = new SQLiteConnection(dbPath);
            connection.Open();
            EndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2333);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(point);
            isOn = true;
            qData = new Queue<Cat021Data>();
            thRec = new Thread(ReceiveMsg);
            thRec.Start();
            return true;
        }

        public void Terminate()
        {
            isOn = false;
            socket.Close();
            socket.Dispose();
            thRec.Join();
            thRec = null;
            if (null == connection)
            {
                return;
            }
            connection.Close();
            connection = null;
        }

        public Cat021Data GetData()
        {
            try
            {
                Cat021Data result = qData.Dequeue();
                Save(result);
                return result;
            }
            catch
            {
                Cat021Data reData = new Cat021Data();
                reData.flightNo = "CA0000";
                return reData;
            }
        }

        public int Count
        {
            get
            {
                return qData == null ? 0 : qData.Count();
            }
        }

        private static void ReceiveMsg()
        {
            while (isOn)
            {
                // 用来保存发送方的ip和端口号
                EndPoint point = new IPEndPoint(IPAddress.Any, 0);
                byte[] buffer = new byte[1024];
                // 接收数据报
                try
                {
                    int length = socket.ReceiveFrom(buffer, ref point);
                    Cat021Data outData = CommWrapper.decode(buffer);
                    qData.Enqueue(outData);
                }
                catch(Exception)
                {
                    return;
                }
            }
        }

        private void Save(Cat021Data data)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Data (sModeAddress, flightNo, latitude, longtitude, elapsedTime, geometricAltitude, barometricAltitude, airSpeed, airSpeedUnit, aircraftAngle, groundSpeed, emitterCategory, createTime) VALUES(@sModeAddress, @flightNo, @latitude, @longtitude, @elapsedTime, @geometricAltitude, @barometricAltitude, @airSpeed, @airSpeedUnit, @aircraftAngle, @groundSpeed, @emitterCategory, @createTime)";
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Int32;
                parameter.ParameterName = "sModeAddress";
                parameter.Value = data.sModeAddress;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.String;
                parameter.ParameterName = "flightNo";
                parameter.Value = data.flightNo;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "latitude";
                parameter.Value = data.latitude;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "longtitude";
                parameter.Value = data.longtitude;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "elapsedTime";
                parameter.Value = data.elapsedTime;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "geometricAltitude";
                parameter.Value = data.geometricAltitude;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "barometricAltitude";
                parameter.Value = data.barometricAltitude;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "airSpeed";
                parameter.Value = data.airSpeed;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Byte;
                parameter.ParameterName = "airSpeedUnit";
                parameter.Value = data.airSpeedUnit;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "aircraftAngle";
                parameter.Value = data.aircraftAngle;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Double;
                parameter.ParameterName = "groundSpeed";
                parameter.Value = data.groundSpeed;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Byte;
                parameter.ParameterName = "emitterCategory";
                parameter.Value = data.emitterCategory;
                cmd.Parameters.Add(parameter);
                //
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Int64;
                parameter.ParameterName = "createTime";
                parameter.Value = DateTime.Now.Ticks;
                cmd.Parameters.Add(parameter);
                //
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class DBDataSource : DataSource
    {
        private SQLiteConnection connection;
        public int MinId;
        public int MaxId;
        public int Id;


        public bool Initialize()
        {
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "\\data.db";
            connection = new SQLiteConnection(dbPath);
            connection.Open();
            Reset();
            Id = MinId - 1;
            return true;
        }

        public void Terminate()
        {
            if (null == connection)
            {
                return;
            }
            connection.Close();
            connection = null;
        }

        public void Reset()
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT MIN(ID) AS MinID, MAX(ID) AS MaxID FROM Data WHERE 1 = 1";
                if(Form_playback.sModeAddressList.Count > 0)
                {
                    String sModeAddressString = null;
                    foreach(string sModeAddress in Form_playback.sModeAddressList)
                    {
                        if(null == sModeAddressString)
                        {
                            sModeAddressString = "'" + sModeAddress + "'";
                        }
                        else
                        {
                            sModeAddressString += ", '" + sModeAddress + "'";
                        }
                    }
                    cmd.CommandText = cmd.CommandText + " AND sModeAddress IN (" + sModeAddressString + ")";
                }
                if(null != Form_playback.startTime)
                {
                    cmd.CommandText = cmd.CommandText + " AND createTime > " + Form_playback.startTime.Ticks;
                }
                if (null != Form_playback.endTime)
                {
                    cmd.CommandText = cmd.CommandText + " AND createTime < " + Form_playback.endTime.Ticks;
                }
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows[0]["MinID"].GetType() == typeof(DBNull))
                {
                    return;
                }
                MinId = (int)(long) dataSet.Tables[0].Rows[0]["MinID"];
                MaxId = (int)(long) dataSet.Tables[0].Rows[0]["MaxID"];
            }
        }

        public Cat021Data GetData()
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Data WHERE ID > @ID";
                if (Form_playback.sModeAddressList.Count > 0)
                {
                    String sModeAddressString = null;
                    foreach (string sModeAddress in Form_playback.sModeAddressList)
                    {
                        if (null == sModeAddressString)
                        {
                            sModeAddressString = "'" + sModeAddress + "'";
                        }
                        else
                        {
                            sModeAddressString += ", '" + sModeAddress + "'";
                        }
                    }
                    cmd.CommandText = cmd.CommandText + " AND sModeAddress IN (" + sModeAddressString + ")";
                }
                if (null != Form_playback.startTime)
                {
                    cmd.CommandText = cmd.CommandText + " AND createTime > " + Form_playback.startTime.Ticks;
                }
                if (null != Form_playback.endTime)
                {
                    cmd.CommandText = cmd.CommandText + " AND createTime < " + Form_playback.endTime.Ticks;
                }
                cmd.CommandText = cmd.CommandText + " ORDER BY ID ASC LIMIT 1";
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = DbType.String;
                parameter.ParameterName = "ID";
                parameter.Value = Id;
                cmd.Parameters.Add(parameter);
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataSet);
                if (0 == dataSet.Tables[0].Rows.Count)
                {
                    Cat021Data exceptionData = new Cat021Data();
                    exceptionData.flightNo = "CA0000";
                    return (exceptionData);
                }
                else
                {
                    this.Id = (int)(long)dataSet.Tables[0].Rows[0]["ID"];
                    Cat021Data data = new Cat021Data();
                    data.sModeAddress = (int)(long)dataSet.Tables[0].Rows[0]["sModeAddress"];
                    data.flightNo = (string)dataSet.Tables[0].Rows[0]["flightNo"];
                    data.latitude = (double)dataSet.Tables[0].Rows[0]["latitude"];
                    data.longtitude = (double)dataSet.Tables[0].Rows[0]["longtitude"];
                    data.elapsedTime = (double)dataSet.Tables[0].Rows[0]["elapsedTime"];
                    data.geometricAltitude = (double)dataSet.Tables[0].Rows[0]["geometricAltitude"];
                    data.barometricAltitude = (double)dataSet.Tables[0].Rows[0]["barometricAltitude"];
                    data.airSpeed = (double)dataSet.Tables[0].Rows[0]["airSpeed"];
                    data.airSpeedUnit = (byte)(long)dataSet.Tables[0].Rows[0]["airSpeedUnit"];
                    data.aircraftAngle = (double)dataSet.Tables[0].Rows[0]["aircraftAngle"];
                    data.groundSpeed = (double)dataSet.Tables[0].Rows[0]["groundSpeed"];
                    data.emitterCategory = (byte)(long)dataSet.Tables[0].Rows[0]["emitterCategory"];
                    return data;
                }
            }
        }

        public int Count
        {
            get
            {
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) AS Count FROM Data WHERE ID > @ID ORDER BY ID ASC LIMIT 1";
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.DbType = System.Data.DbType.String;
                    parameter.ParameterName = "ID";
                    parameter.Value = Id;
                    cmd.Parameters.Add(parameter);
                    DataSet dataSet = new DataSet();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dataSet);
                    if (0 == dataSet.Tables[0].Rows.Count)
                    {
                        return 0;
                    }
                    else
                    {
                        return (int) (long) dataSet.Tables[0].Rows[0]["Count"];
                    }
                }
            }
        }

        public void RemoveData()
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Data WHERE createTime < @CreateTime";
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.Int64;
                parameter.ParameterName = "CreateTime";
                parameter.Value = DateTime.Now.AddHours(-8).Ticks;
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public enum DataSourceType
    {
        DATASOURCE_NAME_UDP,
        DATASOURCE_NAME_DB,
        DATASOURCE_NAME_SERIAL
    }

    public class DataHelper
    {
        public static DataSource Build(DataSourceType type)
        {
            switch(type)
            {
                case DataSourceType.DATASOURCE_NAME_UDP:
                    UDPDataSource udpDataSource = new UDPDataSource();
                    udpDataSource.Initialize();
                    return udpDataSource;
                case DataSourceType.DATASOURCE_NAME_DB:
                    DBDataSource dbDataSource = new DBDataSource();
                    dbDataSource.Initialize();
                    return dbDataSource;
                case DataSourceType.DATASOURCE_NAME_SERIAL:
                    break;
            }
            return null;
        }
    }
}
