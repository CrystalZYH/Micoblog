using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
    public class ReviewsBLL
    {
        ReviewsDAL dll = new ReviewsDAL();
        //插入 评论记录
        public bool save(Reviews re)
        {
            return dll.save(re);
        }

        //删除评论记录(根据weiboId)--删除微博时一起操作
        public bool deleteByreweiboId(int id)
        {
            return dll.deleteByreweiboId(id);
        }

        //删除评论记录(根据reauthorId)--删除用户时一起操作
        public bool deleteByreauthorId(int id)
        {
            return dll.deleteByreauthorId(id);
        }
        //根据weiboId查询评论记录
        public IList<Reviews> findReviewsByweiboId(int weiboId)
        {
            return dll.findReviewsByweiboId(weiboId);
        }

        //根据reauthorId查询评论记录
        public IList<Reviews> findReviewsByreauthorId(int reauthorId)
        {
            return dll.findReviewsByreauthorId(reauthorId);
        }

        //查询所有人的评论记录(默认时间排序)
        public IList<Reviews> findall()
        {
            return dll.findall();
        }
    }
}
