using System.Collections.Generic;
using System.Configuration;

namespace ShopFloor.Data.Helpers
{
    public class DalHelper
    {
        // Default connection string. a connection named MsSql should be defined in web.config file.
        public const string CONNECTION_STRING_NAME = "MsSql";

        //This returns the connection string  
        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// Brings a SqlCommand object to be able to add some parameters in it. After you send this to Execute method.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand GetCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(sql);
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }


        public List<T> GetAll<T>()
        {
            List<T> list = new List<T>();



            return list;
        }
    }
}
