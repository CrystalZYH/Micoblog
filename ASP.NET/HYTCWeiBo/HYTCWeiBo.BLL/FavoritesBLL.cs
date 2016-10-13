using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
    public class FavoritesBLL
    {
        FavoritesDAL dll = new FavoritesDAL();
        //插入 收藏记录
        public bool save(Favorites f)
        {
            return dll.save(f);
        }

        //删除收藏记录(根据favoriteId)
        public bool deleteByfavoriteId(int id)
        {
            return dll.deleteByfavoriteId(id);
        }
        //删除收藏记录(根据favPersonId)--删除用户时一起操作
        public bool deleteByfavPersonId(int id)
        {
            return dll.deleteByfavPersonId(id);
        }

        //根据weiboId，favPersonId查询是否存在收藏记录
        public Favorites findFavoritesByweiboIdandfavPersonId(int wid, int fid)
        {
            return dll.findFavoritesByweiboIdandfavPersonId(wid, fid);
        }

        //根据favPersonId查询收藏记录
        public IList<Favorites>  findFavoritesByfavPersonId(int id)
        {
            return dll.findFavoritesByfavPersonId(id);
        }

        //根据favPersonId 日期查询登陆记录（time1,time2）
        public IList<Favorites> findFavoritesBetweenT1andT2(int id, DateTime t1, DateTime t2)
        {
            return dll.findFavoritesBetweenT1andT2(id, t1, t2);
        }

        //查询所有人的收藏记录(默认favPersonId 分组，Favoritesid排序)
        public IList<Favorites> findall()
        {
            return dll.findall();
        }

    }
}
