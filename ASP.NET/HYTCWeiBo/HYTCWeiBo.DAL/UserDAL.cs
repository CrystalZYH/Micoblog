using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.DBtility;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.DAL
{
    public class UserDAL
    {
        //添加用户
        public bool save(User user)
        {
            string sql = "insert into t_user(userName,pwd,email,sex,personalwords) values('" + user.userName + "','" + user.pwd + "','" + user.email + "','" + user.sex+
                          "','" + user.personalwords+ "')";
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

        //修改用户：修改个人资料，修改密码
        public bool update(User user)
        {                
            string sql = "update t_User"+
                "  set pwd='" + user.pwd + "'," +
                "email='" + user.email + "'," +
                "sex='" + user.sex + "'," +
                "colloge='" + user.colloge + "'," +
                "inCollogeYear='" + user.inCollogeYear + "'," +
                "realName ='" + user.realName + "'," +
                "home='" + user.home + "'," +
                "birthday='" + user.birthday + "'," +
                "boodtype='" + user.boodtype + "'," +
                "personalwords='" + user.personalwords + "'," +
                "phone='" + user.phone + "'," +
                "prinmarySchool='" + user.prinmarySchool + "'," +
                "QQ='" + user.QQ + "'," +
                "MSN='" + user.MSN + "'," +
                "seccondSchool='" + user.seccondSchool + "'," +
                "hobbies='" + user.hobbies + "'," +
                "sports ='" + user.sports + "'," +
                "bestBook ='" + user.bestBook + "'," +
                "bestFilm ='" + user.bestFilm + "'," +
                "bestSong ='" + user.bestSong + "'," +
                "bestFood ='" + user.bestFood + "'," +
                "bestStars='" + user.bestStars + "'," +
                "bestGames='" + user.bestGames + "'," +
                "bestPlaces='" + user.bestPlaces + "'" +
                 " where userId=" + user.userId+"";
            int flag = DBHelper.ExecuteSQL(sql);
            if (flag >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
                // "='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+
                //"='"+user.+   
        }

        //删除用户
        public bool delete(int id)
        {
            string sql = "delete t_user where userId=" + id;
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

        //根据userId pwd 查询 登录
        public User Login(string userName, string pwd)
        {
            string sql = "select * from t_user where userName='" + userName + "' and pwd='" + pwd + "'";
            IList<User> us = GetUsersBySql(sql);
            if (us.Count == 0)
            {
                return null;
            }
            else
            {
                return us[0];
            }
        }
        //查询，根据用户userName
        public User findUserByUserName(string userName)
        {
            string sql = "select * from t_user where userName='" + userName + "'";
            IList<User> us = GetUsersBySql(sql);
            if (us.Count == 0)
            {
                return null;
            }
            else
            {
                return us[0];
            }

        }
        //查询，根据用户id
        public User findUserByUserId(int userId)
        {
            string sql = "select * from t_user where userId=" + userId + "";
            IList<User> us = GetUsersBySql(sql);
            if (us.Count == 0)
            {
                return null;
            }
            else
            {
                return us[0];
            }

        }
        //查询所有用户
        public IList<User> findall()
        {
            string sql = "select * from t_user";

            return GetUsersBySql(sql);
        }

        //根据sql查询用户信息
        IList<User> GetUsersBySql(string sql)
        {
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            IList<User> users = new List<User>();
            try
            {
                while (reader.Read())
                {
                    User u = new User();
                    u.userId = Convert.ToInt32(reader["userId"]);
                    u.userName = reader["userName"].ToString();
                    u.pwd = reader["pwd"].ToString();
                    u.email = reader["email"].ToString();
                    u.sex = reader["sex"].ToString();                  
                    u.colloge = reader["colloge"].ToString();   
                    u.inCollogeYear = reader["inCollogeYear"].ToString();
                    u.realName = reader["realName"].ToString();
                    u.home = reader["home"].ToString();
                    u.birthday = reader["birthday"].ToString();
                    u.boodtype = reader["boodtype"].ToString();
                    u.personalwords = reader["personalwords"].ToString();
                    u.phone = reader["phone"].ToString();
                    u.prinmarySchool = reader["prinmarySchool"].ToString();
                    u.QQ = reader["QQ"].ToString();
                    u.MSN = reader["MSN"].ToString();
                    u.seccondSchool = reader["seccondSchool"].ToString();
                    u.hobbies = reader["hobbies"].ToString();
                    u.sports = reader["sports"].ToString();
                    u.bestBook = reader["bestBook"].ToString();
                    u.bestFilm = reader["bestFilm"].ToString();
                    u.bestSong = reader["bestSong"].ToString();
                    u.bestFood = reader["bestFood"].ToString();
                    u.bestStars = reader["bestStars"].ToString();
                    u.bestGames = reader["bestGames"].ToString();
                    u.bestPlaces = reader["bestPlaces"].ToString();
                    users.Add(u);
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
            return users;
        }


        ////根据角色查询
        //public IList<User> findUserByRole(UserRoles role)
        //{
        //    string sql = "select * from users where userroleid=" + role.Id;

        //    return GetUsersBySql(sql);
        //}
        ////根据状态选择
        //public IList<User> findUserByState(UserState state)
        //{
        //    string sql = "select * from users where userstateid=" + state.Id;

        //    return GetUsersBySql(sql);
        //}


        //}
        ////根据姓名 手机号 邮箱 地址模糊查询
        //public IList<User> findUserByLike(string param)
        //{
        //    string sql = "select * from users where name like '%" + param + "%' or phone like '%" + param + "%' or mail like '%" + param + "%' or address like '%" + param + "%'";

        //    return GetUsersBySql(sql);
        //}

    }
}
