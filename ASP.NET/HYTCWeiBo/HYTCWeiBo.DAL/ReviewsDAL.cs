using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.DBtility;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.DAL
{
    public class ReviewsDAL
    {
        //插入 评论记录
        public bool save(Reviews re)
        {
            string sql = "insert into t_Reviews(weiboId,reAuthorId,reAuthorName,returnContent,reTime) values("+ re.weiboId+","+
                re.reAuthorId + ",'"+ re.reAuthorName  + "','" +re.returnContent+ "','" + re.reTime + "')";
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

        //删除评论记录(根据weiboId)--删除微博时一起操作
        public bool deleteByreweiboId(int id)
        {
            string sql = "delete t_Reviews where weiboId=" + id;
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

        //删除评论记录(根据reauthorId)--删除用户时一起操作
        public bool deleteByreauthorId(int id)
        {
            string sql = "delete t_Reviews where reauthorId=" + id;
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

        //根据weiboId查询评论记录
        public IList<Reviews> findReviewsByweiboId(int weiboId)
        {
            string sql = "select * from t_Reviews where weiboId=" + weiboId + "";
           return GetReviewsBySql(sql); 
        }

        //根据reauthorId查询评论记录
        public IList<Reviews> findReviewsByreauthorId(int reauthorId)
        {
            string sql = "select * from t_Reviews where reauthorId=" + reauthorId + "";
            return GetReviewsBySql(sql);
        }

        //查询所有人的评论记录(默认时间排序)
        public IList<Reviews> findall()
        {
            string sql = "select * from t_Reviews group by weiboId order by reTime DESC";

            return GetReviewsBySql(sql);
        }
        //根据sql查询评论信息
        IList<Reviews> GetReviewsBySql(string sql)
        {
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            IList<Reviews> Reviews = new List<Reviews>();
            try
            {
                while (reader.Read())
                {
                    Reviews re = new Reviews();
                    re.reviewId = Convert.ToInt32(reader["reviewId"]);
                    re.weiboId = Convert.ToInt32(reader["weiboId"]);
                    re.reAuthorId = Convert.ToInt32(reader["reAuthorId"]);
                    re.reAuthorName = reader["reAuthorName"].ToString();
                    re.returnContent = reader["returnContent"].ToString();
                    re.reTime = (DateTime)reader["reTime"];
                    Reviews.Add(re);
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
            return Reviews;
        }
    }
}
