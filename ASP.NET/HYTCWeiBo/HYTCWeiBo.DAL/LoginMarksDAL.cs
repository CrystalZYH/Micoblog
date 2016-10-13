using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HYTCWeiBo.DBtility;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.DAL
{
   public  class LoginMarksDAL
    {
       //插入 登录记录
       public bool save(LoginMarks lm)
       {
           string sql = "insert into t_LoginMarks(userId,userName,loginTime) values(" + lm.userId + ",'" + lm.userName + "','" + lm.loginTime +  "')";
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

       //删除登录记录(根据markId)
       public bool deleteBymarkId(int id)
       {
           string sql = "delete t_LoginMarks where markId=" + id;
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
       //删除登录记录(根据userId)--删除用户时一起操作
       public bool deleteByuserId(int id)
       {
           string sql = "delete t_LoginMarks where userId=" + id;
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
       
       //根据userName查询登录记录
       public IList<LoginMarks> findLoginMarksByUserName(string userName)
       {
           string sql = "select * from t_LoginMarks where userName='" + userName + "'";
           return GetLoginMarksBySql(sql);
       }
         
       //根据userId查询登录记录
       public IList<LoginMarks> findLoginMarksByUserId(int userId)
       {
           string sql = "select * from t_LoginMarks where userId=" + userId + "";
           return GetLoginMarksBySql(sql);
       }
       //根据日期查询登陆记录（time1,time2）
       public IList<LoginMarks> findLoginMarksBetweenT1andT2(DateTime t1,DateTime t2)
       {
           string sql = "select * from t_LoginMarks where loginTime between '"+t1+"' and '"+t2+"'";

           return GetLoginMarksBySql(sql);
       }
      //查询所有人的登录记录(默认时间排序)
       public IList<LoginMarks> findall()
       {
           string sql = "select * from t_LoginMarks order by loginTime DESC";

           return GetLoginMarksBySql(sql);
       }
       //根据sql查询登录信息
       IList<LoginMarks> GetLoginMarksBySql(string sql)
       {
           SqlDataReader reader = DBHelper.ExecuteReader(sql);
           IList<LoginMarks> LoginMarks = new List<LoginMarks>();
           try
           {
               while (reader.Read())
               {
                   LoginMarks lm = new LoginMarks();
                   lm.markId= Convert.ToInt32(reader["markId"]);
                   lm.userId = Convert.ToInt32(reader["userId "]);
                   lm.userName = reader["userName"].ToString();
                   lm.loginTime = (DateTime)reader["loginTime"];                 
                   LoginMarks.Add(lm);
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
           return LoginMarks;
       }


    }
}
