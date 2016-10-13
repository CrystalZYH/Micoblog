using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using HYTCWeiBo.BLL;
using HYTCWeiBo.Model;

namespace HYTCWeiBoWeb
{
	public partial class MainForm : System.Web.UI.Page
	{
		User u = null;
		IList<WeiBo> wblist = null;
		IList<FansMarks> fmlist = null;
		FansMarksBLL fmbll = new FansMarksBLL();
		WeiBoBLL wbbll = new WeiBoBLL();
		UserBLL userbll = new UserBLL();
		bool Isown = true;
		int guestid, masterid;
		protected void Page_Load(object sender, EventArgs e)
		{
			//加载动画
			if (!IsPostBack)
			{
				 masterid = Convert.ToInt32(Request["masterid"]);
				 guestid = Convert.ToInt32(Request["guestid"]);
				 //Response.Write(guestid);
				if (masterid != 0&&guestid!=0)
				{        //别人访问           
					loadfirst(masterid,guestid);				
				}
				else
				{
					//登录页面加载
					object obj = Session["user"];
					if (obj == null)
					{
						Response.Redirect("~/Login.aspx");
					}
					else
					{
						u = (User)obj;
						masterid = u.userId;
						loadfirst(masterid, masterid);						
						//guestid = u.userId;//后台向前端输出值  此时master=guest
					}
				}

				if (Isown)
				{
					btnEdit.Visible = true;
					btnAddFocus.Visible = false;
					publish.Visible = true;
				}
				else
				{
					btnEdit.Visible = false;
					btnAddFocus.Visible = true;
					publish.Visible = false;
				}

			}


		   


		}


		protected void loadfirst(int masterid,int guestid)
		{
			u = userbll.findUserByUserId(masterid);
			btnmasterName.Value = u.userName;          
			User u2 = userbll.findUserByUserName(u.userName);
			btnmasterId.Value = u2.userId.ToString();//操作时取值     
			btnguestId.Value = guestid.ToString();
			User u3 = userbll.findUserByUserId(guestid);
			btnguestName.Value = u3.userName;
			labuserId.Value = u3.userName;//显示当前用户名
			labpWords.Text = u2.personalwords;
			if (labpWords.Text == "")
			{
				labpWords.Text = "个性签名";
			}
			labsex.Text = u2.sex;
			labcolloge.Text = u2.colloge;
			if (labcolloge.Text == "")
			{
				labcolloge.Text = "未知学院";
			}
			labweiboNo.Text = "0";
			labfansNo.Text = "0";
			labfocusNo.Text = "0";  //  函数计算
			if (masterid==guestid)
			{
				Isown = true;
			}
			else
			{
				Isown = false;
			}

			wblist = wbbll.findWeiboByauthorId(masterid);
			labweiboNo.Text = wblist.Count.ToString();

			fmlist = fmbll.findfocusFansMarksByonselfId(masterid);
			labfocusNo.Text = fmlist.Count.ToString();

			fmlist = fmbll.findfansFansMarksByotherId(masterid);
			labfansNo.Text = fmlist.Count.ToString();

		}



	}
}