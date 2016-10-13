using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
    public class LoginMarksBLL
    {
        LoginMarksDAL dll = new LoginMarksDAL();
        //插入 登录记录
        public bool save(LoginMarks lm)
        {
            return dll.save(lm);
        }

        //删除登录记录(根据markId)
        public bool deleteBymarkId(int id)
        {
            return dll.deleteBymarkId(id);
        }
        //删除登录记录(根据userId)--删除用户时一起操作
        public bool deleteByuserId(int id)
        {
            return dll.deleteByuserId(id);
        }

        //根据userName查询登录记录
        public IList<LoginMarks> findLoginMarksByUserName(string userName)
        {
            return dll.findLoginMarksByUserName(userName);
        }

        //根据userId查询登录记录
        public IList<LoginMarks> findLoginMarksByUserId(int userId)
        {
            return dll.findLoginMarksByUserId(userId);
        }
        //根据日期查询登陆记录（time1,time2）
        public IList<LoginMarks> findLoginMarksBetweenT1andT2(DateTime t1, DateTime t2)
        {
            return dll.findLoginMarksBetweenT1andT2(t1, t2);
        }
        //查询所有人的登录记录(默认时间排序)
        public IList<LoginMarks> findall()
        {
            return dll.findall();
        }
    }
}
