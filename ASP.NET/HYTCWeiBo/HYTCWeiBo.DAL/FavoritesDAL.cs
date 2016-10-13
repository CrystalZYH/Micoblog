using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.DBtility;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.DAL
{
    public class FavoritesDAL   
    {
        //插入 收藏记录
        public bool save(Favorites f)
        {
            string sql = "insert into t_Favorites(weiboId,favPersonId,createTime) values(" + f.weiboId + "," + f.favPersonId + ",'" + f.createTime+ "')";
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

        //删除收藏记录(根据favoriteId)
        public bool deleteByfavoriteId(int id)
        {
            string sql = "delete t_Favorites where favoriteId=" + id;
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
        //删除收藏记录(根据favPersonId)--删除用户时一起操作
        public bool deleteByfavPersonId(int id)
        {
            string sql = "delete t_Favorites where favPersonId=" + id;
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

        //根据weiboId，favPersonId查询是否存在收藏记录
        public Favorites findFavoritesByweiboIdandfavPersonId(int wid, int fid)
        {
            string sql = "select * from t_Favorites where weiboId=" + wid + " and favPersonId=" + fid + "";
            IList<Favorites> fs = GetFavoritesBySql(sql);
            if (fs.Count == 0)
            {
                return null;
            }
            else
            {
                return fs[0];
            }
        }

        //根据favPersonId查询收藏记录
        public IList<Favorites> findFavoritesByfavPersonId(int id)
        {
            string sql = "select * from t_Favorites where favPersonId=" + id + "";
            return GetFavoritesBySql(sql);
        }

        //根据favPersonId 日期查询登陆记录（time1,time2）
        public IList<Favorites> findFavoritesBetweenT1andT2(int id,DateTime t1, DateTime t2)
        {
            string sql = "select * from t_Favorites where favPersonId =" + id + " and createTime between '" + t1 + "' and '" + t2 + "'";
            return GetFavoritesBySql(sql);
        }

        //查询所有人的收藏记录(默认favPersonId 分组，Favoritesid排序)
        public IList<Favorites> findall()
        {
            string sql = "select * from t_Favorites  group by favPersonId order by Favoritesid ";

            return GetFavoritesBySql(sql);
        }

        //根据sql查询收藏信息
        IList<Favorites>GetFavoritesBySql(string sql)
        {
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            IList<Favorites> Favorites = new List<Favorites>();
            try
            {
                while (reader.Read())
                {
                    Favorites f = new Favorites();
                    f.favoriteId = Convert.ToInt32(reader["favoriteId"]);
                    f.weiboId = Convert.ToInt32(reader["weiboId"]);
                    f.favPersonId = Convert.ToInt32(reader["favPersonId"]);
                    Favorites.Add(f);
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
            return Favorites;
        }

    }
}
