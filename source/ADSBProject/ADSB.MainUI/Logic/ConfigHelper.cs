using System;
using System.Data;
using System.Data.SQLite;

namespace ADSB.MainUI
{
    public class ConfigHelper
    {
        private static ConfigHelper instance;

        private SQLiteConnection connection;

        public static ConfigHelper Instance
        {
            get {
                if(null == instance)
                {
                    instance = (new ConfigHelper()).Prepare();
                }
                return instance;
            }
        }

        private ConfigHelper Prepare()
        {
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "\\data.db";
            connection = new SQLiteConnection(dbPath);
            connection.Open();
            return this;
        }

        public void Destroy()
        {
            if(null == connection)
            {
                return;
            }
            connection.Close();
            connection = null;
        }

        public String GetConfig(string key)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT Value FROM Config WHERE Key = @Key";
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.String;
                parameter.ParameterName = "Key";
                parameter.Value = key;
                cmd.Parameters.Add(parameter);
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataSet);
                if(0 == dataSet.Tables[0].Rows.Count)
                {
                    return null;
                }
                return (string) dataSet.Tables[0].Rows[0]["Value"];
            }
        }

        public bool SetConfig(string key, String value)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "UPDATE Config SET Value = @Value WHERE Key = @Key";
                SQLiteParameter parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.String;
                parameter.ParameterName = "Key";
                parameter.Value = key;
                cmd.Parameters.Add(parameter);
                parameter = new SQLiteParameter();
                parameter.DbType = System.Data.DbType.String;
                parameter.ParameterName = "Value";
                parameter.Value = value;
                cmd.Parameters.Add(parameter);
                if(0 == cmd.ExecuteNonQuery())
                {
                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Config (Key, Value) Values(@Key, @Value)";
                    parameter = new SQLiteParameter();
                    parameter.DbType = System.Data.DbType.String;
                    parameter.ParameterName = "Key";
                    parameter.Value = key;
                    command.Parameters.Add(parameter);
                    parameter = new SQLiteParameter();
                    parameter.DbType = System.Data.DbType.String;
                    parameter.ParameterName = "Value";
                    parameter.Value = value;
                    command.Parameters.Add(parameter);
                    return 1 == command.ExecuteNonQuery();
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
