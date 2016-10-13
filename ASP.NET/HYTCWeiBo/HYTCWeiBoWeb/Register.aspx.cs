using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HYTCWeiBo.BLL;
using HYTCWeiBo.Model;

namespace HYTCWeiBoWeb
{
    public partial class Register : System.Web.UI.Page
    {
        UserBLL userbll = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            labcheck.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //验证登陆
            string txtuserName = userName.Text;
            string txtPwd = pwd.Value;
            string txtemail = email.Value;
            string txtpwords = pwords.Value;
            string txtsex = "";
            bool flag = true;
            if (txtuserName == null || txtuserName.Trim().Equals("") || txtPwd.Trim().Length < 6 || txtPwd.Trim().Length >40)
            {
                flag = false;
                labInfo.Text = "友情提示：用户名输入不正确";
                return;
            }
            if (txtPwd == null || txtPwd.Trim().Length < 6 || txtPwd.Trim().Length >12)
            {
                flag = false;
                labInfo.Text = "友情提示：密码输入不正确";
                return;
            }
            if (!(txtPwd==pwd2.Value))
            {
                flag = false;
                labInfo.Text = "友情提示：二次密码输入不正确";
                return;
            }
            if (txtemail == null ||  txtuserName.Trim().Equals(""))
            {
                flag = false;
                labInfo.Text = "友情提示：email输入不正确";
                return;
            }
            if (radsexNv.Checked == true)
            {
                txtsex = "女";
            }
            if (radsexNan.Checked == true)
            {
                txtsex = "男";
            }
            if (txtsex=="")
            {
                flag = false;
                labInfo.Text = "友情提示：请选择性别";
            }
            if (!radRead.Checked==true)
            {
                flag = false;
                labInfo.Text = "友情提示：请阅读淮师校园微博规范";
            }
            if ( flag)
            {
                //插入一个user,返回登录页面
                userbll = new UserBLL();
                User u = new User();
                u.userName = txtuserName;
                u.pwd = txtPwd;
                u.email = txtemail;
                u.sex = txtsex;
                u.personalwords = txtpwords;
                if (userbll.save(u))
                {
                    Response.Redirect("RegisterSuccess.html");
                }
               
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //注册页面关闭
            Response.Redirect("Login.aspx");
        }

        protected void userName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    User u = userbll.findUserByUserName(userName.Text.Trim());
            //}
            //catch (Exception)
            //{
            //    labcheck.Visible = false;
            //    throw;
            //}
            //finally
            //{
            //    labcheck.Visible = true;
            //}            

            
        }

    }
}