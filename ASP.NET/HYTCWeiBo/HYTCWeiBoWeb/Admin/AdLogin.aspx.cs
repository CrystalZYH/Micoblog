using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HYTCWeiBo.BLL;
using HYTCWeiBo.Model;

namespace HYTCWeiBoWeb.Admin
{
    public partial class AdLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labInfo.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //验证登陆
            string txtid = txtLoginId.Text;
            string txtPwd = txtLoginPwd.Text;
            if (txtid == null || txtid.Trim().Equals(""))
            {
                labInfo.Text = "友情提示：用户名不能为空";
                return;
            }
            if (txtPwd == null || txtPwd.Trim().Length < 6)
            {
                labInfo.Text = "友情提示：密码长度不能小于6位";
                return;
            }

            //UserBLL userbll = new UserBLL();
            //User u = userbll.Login(txtid, txtPwd);

            //if (u == null)
            //{
            //    labInfo.Text = "友情提示：用户名或密码错误";
            //}
            //else
            //{
            //    Session["user"] = u;
            //    Response.Redirect("~/Admin/AdMainForm.aspx");
            //}
            if (txtid=="admin" &&txtPwd == "admin123")
            {
              
                Response.Redirect("~/Admin/AdMainForm.aspx");
            }
            else{
                labInfo.Text = "友情提示：用户名或密码错误";
            }


        }
    }
}