using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.Model;
using HYTCWeiBo.DBtility;

namespace HYTCWeiBo.DAL
{
    public class FansMarksDAL
    {
        //插入 关注记录
        public bool save(FansMarks f)
        {
            string sql = "insert into t_FansMarks(onselfId,otherId,createTime) values(" + f.onselfId+ "," + f.otherId + ",'" + f.createTime + "')";
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //删除关注记录(根据markId)
        public bool deleteBymarkId(int id)
        {
            string sql = "delete t_FansMarks where markId=" + id;
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //删除关注记录(根据onselfId)--删除用户时一起操作
        public bool deleteByonselfId(int id)
        {
            string sql = "delete t_FansMarks where onselfId=" + id;
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //删除粉丝记录(根据otherId)--删除用户时一起操作
        public bool deleteByotherId(int id)
        {
            string sql = "delete t_FansMarks where otherId=" + id;
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //根据onselfId，otherId查询是否存在关注记录
        public FansMarks findFansMarksByonselfIdandotherId(int onselfid, int otherid)
        {
            string sql = "select * from t_FansMarks where onselfId=" + onselfid + " and otherId=" + otherid + "";
            IList<FansMarks> fs = GetFansMarksBySql(sql);
            if (fs.Count == 0)
            {
                return null;
            }
            else
            {
                return fs[0];
            }
        }

        //根据id=onselfId查询粉丝记录
        public IList<FansMarks> findfocusFansMarksByonselfId(int id)
        {
            string sql = "select * from t_FansMarks where onselfId=" + id + "";
            return GetFansMarksBySql(sql);
        }
        //根据id=otherId查询关注记录
        public IList<FansMarks> findfansFansMarksByotherId(int id)
        {
            string sql = "select * from t_FansMarks where otherId=" + id + "";
            return GetFansMarksBySql(sql);
        }



        //查询所有人的关注记录(默认onselfId 分组)
        public IList<FansMarks> findall()
        {
            string sql = "select * from t_FansMarks  group by onselfId ";

            return GetFansMarksBySql(sql);
        }

        //根据sql查询粉丝信息
        IList<FansMarks> GetFansMarksBySql(string sql)
        {
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            IList<FansMarks> FansMarks = new List<FansMarks>();
            try
            {
                while (reader.Read())
                {
                    FansMarks f = new FansMarks();
                    f.markId = Convert.ToInt32(reader["markId"]);
                    f.onselfId = Convert.ToInt32(reader["onselfId"]);
                    f.otherId = Convert.ToInt32(reader["otherId"]);
                    f.createTime = (DateTime)reader["createTime"];
                    FansMarks.Add(f);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return FansMarks;
        }
    }
}
