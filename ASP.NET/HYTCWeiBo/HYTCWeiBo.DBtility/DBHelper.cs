using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;//添加引用

namespace HYTCWeiBo.DBtility
{
    public class DBHelper
    {
        public static string connstr = ConfigurationManager.AppSettings["ConnectionStr"].ToString();
        private static SqlConnection conn = null;

        public static SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connstr);
                    conn.Open();
                }
                else if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                else if (conn.State == System.Data.ConnectionState.Broken)
                {
                    conn = null;
                    conn = new SqlConnection(connstr);
                    conn.Open();
                }
                else if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }


                return conn;
            }

        }



        #region 数据更新的函数
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回影响行数</returns>
        public static int ExecuteSQL(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

        }
        #endregion

        #region 绑定事务 处理多条sql语句
        /// <summary>
        /// 绑定事务 处理多条sql语句
        /// </summary>
        /// <param name="sqls">sql集合</param>
        /// <returns>影响的总行数</returns>
        public static int ExecuteSQLListTrans(List<String> sqls)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //设置事务
                SqlTransaction trans = conn.BeginTransaction();//开启事务
                cmd.Transaction = trans;
                try
                {
                    int count = 0;//影响的行数
                    for (int i = 0; i < sqls.Count; i++)
                    {
                        cmd.CommandText = sqls[i];
                        count += cmd.ExecuteNonQuery();//累加执行的行数
                    }
                    trans.Commit();//提交事务
                    return count;

                }
                catch (Exception)
                {
                    trans.Rollback();//事务回滚 断电了 谢荧屏没取到钱
                    return 0;
                }

            }

        }
        #endregion

        #region 查询
        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>sqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader reader = null;


            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {

                throw;
            }




        }

        #endregion

        #region 查询 一行一列
        public static object findOnlyOne(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
        public static void closeConn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
