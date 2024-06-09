using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class MysqlHelper
    {
        private string connstr;

        public MysqlHelper(string connstr) {
            this.connstr = connstr;
        }
        
        /// <summary>
        ///    執行一段SQL語句，返回受影響的行數數量
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sqlText, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sqlText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 執行SQL語句，返回查詢結果中的第一行第一列的值
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns> 
        public object ExecuteScalar(string sqlText, params MySqlParameter[] parameters)
        {

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {

                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    conn.Open();
                    cmd.CommandText = sqlText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();

                }

            }

        }

        /// <summary>
        /// 執行SQL， 返回一個DataTable
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public  DataTable ExecuteDataTable(string sqlText, params MySqlParameter[] parameters)
        {

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlText, connstr))
            {

                DataTable dt = new DataTable();
                adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
                return dt;

            }

        }

        /// <summary>
        /// 執行SQL脚本
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public  MySqlDataReader ExecuteReader(string sqlText, params MySqlParameter[] parameters)
        {

            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlText;
            cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);

        }



















    }   
}
