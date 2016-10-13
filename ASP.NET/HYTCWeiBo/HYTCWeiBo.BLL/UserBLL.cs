using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
    public class UserBLL
    {
        UserDAL dll = new UserDAL();
        //根据loginid pwd 查询 登录
        public User Login(string userName, string pwd)
        {
            return dll.Login(userName, pwd);
        }
        //添加用户
        public bool save(User user)
        {
            return dll.save(user);
        }

        //修改用户：修改个人资料，修改密码
        public bool update(User user)
        {
            return dll.update(user);
        }

        //删除用户
        public bool delete(int id)
        {
            return dll.delete(id);
        }
        //按照用户名查找用户，检查用户名唯一性
        public User findUserByUserName(string userName)
        {
            return dll.findUserByUserName(userName);
        }
        //查询，根据用户id
        public User findUserByUserId(int userId)
        {
            return dll.findUserByUserId(userId);

        }
        //查询所有用户
        public IList<User> findall()
        {        
            return dll.findall();
        }


    }
}
