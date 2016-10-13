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
    public partial class Login : System.Web.UI.Page
    {
           protected void Page_Load(object sender, EventArgs e)
        {

        }
           protected void Page_Init(object sender, EventArgs e)
           {
               //Response.Write("Loading");
           }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //验证登陆
            string txtName = txtUserName.Text;
            string txtPwd = txtUserPwd.Text;
            if (txtName == null || txtName.Trim().Equals(""))
            {
                labInfo.Text = "友情提示：用户名不能为空";
                return;
            }
            if (txtPwd == null || txtPwd.Trim().Length < 6)
            {
                labInfo.Text = "友情提示：密码长度不能小于6位";
                return;
            }

            UserBLL userbll = new UserBLL();
            User u = userbll.Login(txtName, txtPwd);

            if (u == null)
            {
                labInfo.Text = "友情提示：用户名或密码错误";
            }
            else
            {
                //Loginmark
                LoginMarksBLL lmb = new LoginMarksBLL();
                LoginMarks lm = new LoginMarks();
                lm.userId = u.userId;
                lm.userName = u.userName;
                lm.loginTime = DateTime.Now;
                if (lmb.save(lm))
                {
                    Session["user"] = u;
                     Response.Redirect("MainForm.aspx");
                }
                
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


    }
}