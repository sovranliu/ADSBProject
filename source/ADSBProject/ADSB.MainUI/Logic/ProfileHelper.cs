using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ADSB.MainUI
{
    public class ProfileHelper
    {
        private static ProfileHelper instance;

        private SQLiteConnection connection;

        public static ProfileHelper Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = (new ProfileHelper()).Prepare();
                }
                return instance;
            }
        }

        private ProfileHelper Prepare()
        {
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "\\data.db";
            connection = new SQLiteConnection(dbPath);
            connection.Open();
            return this;
        }

        public void Destroy()
        {
            if (null == connection)
            {
                return;
            }
            connection.Close();
            connection = null;
        }
        
        public List<Dictionary<string, object>> Select(string sql)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataSet);
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
                foreach (DataRow item in dataSet.Tables[0].Rows)
                {
                    Dictionary<string, object> kv = new Dictionary<string, object>();
                    foreach (string colum in dataSet.Tables[0].Columns)
                    {
                        kv[colum] = item[colum];
                    }
                    result.Add(kv);
                }
                return result;
            }
        }

        public int Update(string sql)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
