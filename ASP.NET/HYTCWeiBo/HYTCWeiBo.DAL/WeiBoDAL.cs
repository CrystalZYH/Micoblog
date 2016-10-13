using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.DBtility;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.DAL
{
    public class WeiBoDAL
    {
       // 添加微博
        public bool save(WeiBo WeiBo)
        {
            string sql = "insert into t_weibo(authorId, authorName,isOriginal,zanNumber,transmitNumber,favsNumber,reviewNumber," +
            "content,orAuthorId,orAuthorName,orContent,ortime,createTime) values(" +
                WeiBo.authorId + ",'" +
                WeiBo.authorName + "','" +
                WeiBo.isOriginal+ "'," +
                WeiBo.zanNumber+","+
                WeiBo.transmitNumber+","+
                WeiBo.favsNumber+","+
                WeiBo.reviewNumber+",'"+
                WeiBo.content + "'," + 
                WeiBo.orAuthorId+",'"+
                WeiBo.orAuthorName+ "','" +
                WeiBo.orContent+"','"+
                WeiBo.orTime + "','" +
                WeiBo.createTime + "')";
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

        //删除微博
        public bool delete(int id)
        {
            string sql = "delete t_weibo where WeiBoId=" + id;
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

        //查询所有微博
        public IList<WeiBo> findall()
        {
            string sql = "select * from t_weibo order by createTime DESC";

            return GetWeiBosBySql(sql);
        }

        //根据authorId查询微博
        public IList<WeiBo> findWeiboByauthorId(int id)
        {
            string sql = "select * from t_weibo where authorId=" + id + "order by createTime DESC";

            return GetWeiBosBySql(sql);
        }

        //根据weiboId查询微博
        public WeiBo findWeiboByweiboId(int id)
        {
            string sql = "select * from t_weibo where weiboId=" + id + "";
            IList<WeiBo> wb= GetWeiBosBySql(sql);
            if (wb.Count == 0)
            {
                return null;
            }
            else
            {
                return wb[0];
            }
        }

        //根据weiboId更新微博(ZanFavsReviewTrans)
        public bool updateZanFavsReviewTrans(WeiBo wb)
        {
            string sql = "update t_WeiBo " + 
                " set zanNumber=" + wb.zanNumber+ ","+
                "favsNumber=" + wb.favsNumber + "," +
                "reviewNumber=" + wb.reviewNumber + "," +
                "transmitNumber=" + wb.transmitNumber +
                " where weiboid=" + wb.weiboId;
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        //根据本人onselfid查询关注的人的微博
        public IList<WeiBo> findfocusWeiBosByonselfId(int id)
        {
            string sql = "select t1.weiboId,t1.authorId,t1.authorName,t1.isOriginal,t1.zanNumber,t1.transmitNumber,t1.favsNumber,t1.reviewNumber," +
            "t1.content,t1.orAuthorId,t1.orAuthorName,t1.orContent,t1.ortime,t1.createTime" +
                 " from t_WeiBo t1,t_FansMarks "+
                 "where t1.authorId=t_FansMarks.otherId and t_FansMarks.onselfId=" + id + "order by createTime DESC";
            return GetWeiBosBySql(sql);
        }

        //根据sql查询微博信息
        IList<WeiBo> GetWeiBosBySql(string sql)
        {
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            IList<WeiBo> WeiBos = new List<WeiBo>();
            try
            {
                while (reader.Read())
                {
                    WeiBo w = new WeiBo();
                    w.weiboId =(Int32) reader["weiboId"];
                    w.authorId = (Int32)reader["authorId"];
                    w.authorName = reader["authorName"].ToString();
                    w.content = reader["content"].ToString();
                    w.createTime = (DateTime)reader["createTime"];
                    w.favsNumber = (Int32)reader["favsNumber"];
                    w.reviewNumber = (Int32)reader["reviewNumber"];
                    w.transmitNumber = (Int32)reader["transmitNumber"];
                    w.zanNumber = (Int32)reader["zanNumber"];
                    w.isOriginal = reader["isOriginal"].ToString();
                    if (w.isOriginal.Trim()!="原创")
                    {
                        w.orAuthorId = (Int32)reader["orAuthorId"];
                        w.orAuthorName = reader["orAuthorName"].ToString();
                        w.orContent = reader["orContent"].ToString();
                        w.orTime = (DateTime)reader["orTime"];
                    }

                    WeiBos.Add(w);
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
            return WeiBos;
        }

        ////查询，根据微博WeiBoName
        //public WeiBo findWeiBoByWeiBoName(string WeiBoName)
        //{
        //    string sql = "select * from t_weibo where WeiBoName='" + WeiBoName + "'";
        //    IList<WeiBo> us = GetWeiBosBySql(sql);
        //    if (us.Count == 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return us[0];
        //    }

        //}

     

        

    }
}
