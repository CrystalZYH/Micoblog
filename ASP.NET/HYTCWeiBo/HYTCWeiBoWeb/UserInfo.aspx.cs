using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using HYTCWeiBo.BLL;
using HYTCWeiBo.Model;

namespace HYTCWeiBoWeb
{
	public partial class UserInfo : System.Web.UI.Page
	{
        User u = new User();
        UserBLL ubll = new UserBLL();
        int userid;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
                if (Request.QueryString["userid"] != null)
                {
                    userid =Convert.ToInt32( Request.QueryString["userid"]);
                    u = ubll.findUserByUserId(userid);
                    labuserId2.Text = u.userId.ToString();
                    labuserName2.Text = u.userName;
                    tboxbestBook.Text = u.bestBook;
                    tboxbestFilm.Text = u.bestFilm;
                    tboxbestFood.Text = u.bestFood;
                    tboxbestGames.Text = u.bestGames;
                    tboxbestPlaces.Text = u.bestPlaces;
                    tboxbestSong.Text = u.bestSong;
                    tboxbestStars.Text = u.bestStars;
                    tboxbirthday.Text = u.birthday;
                    tboxboodtype.Text = u.boodtype;
                    tboxcolloge.Text = u.colloge;
                    tboxemail.Text = u.email;
                    tboxhobbies.Text = u.hobbies;
                    tboxhome.Text = u.home;
                    tboxinCollogeYear.Text = u.inCollogeYear;
                    tboxMSN.Text = u.MSN;
                    tboxpersonalwords.Text = u.personalwords;
                    tboxphone.Text = u.phone;
                    tboxprinmarySchool.Text = u.prinmarySchool;
                    tboxpwd.Text = u.pwd;
                    tboxQQ.Text = u.QQ;
                    tboxrealName.Text = u.realName;
                    tboxseccondSchool.Text = u.seccondSchool;
                    tboxsex.Text = u.sex;
                    tboxsports.Text = u.sports;
                   



                }


			}
		}

		protected void btnCancel_Click(object sender, EventArgs e)
		{
            userid=Convert.ToInt32(labuserId2.Text);
			Response.Redirect("MainForm.aspx?masterid="+userid+"&guestid="+userid+"");
		}

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User u2 = new User();
            u2.userId =Convert.ToInt32( labuserId2.Text);
            u2.userName = labuserName2.Text;
            u2.bestBook =tboxbestBook.Text;
            u2.bestFilm =tboxbestFilm.Text;
            u2.bestFood =tboxbestFood.Text;
            u2.bestGames =tboxbestGames.Text;
            u2.bestPlaces =tboxbestPlaces.Text;
            u2.bestSong =tboxbestSong.Text;
            u2.bestStars =tboxbestStars.Text;
            u2.birthday =tboxbirthday.Text;
            u2.boodtype =tboxboodtype.Text;
            u2.colloge =tboxcolloge.Text;
            u2.email =tboxemail.Text;
            u2.hobbies =tboxhobbies.Text;
            u2.home =tboxhome.Text;
            u2.inCollogeYear =tboxinCollogeYear.Text;
            u2.MSN =tboxMSN.Text;
            u2.personalwords =tboxpersonalwords.Text;
            u2.phone =tboxphone.Text;
            u2.prinmarySchool =tboxprinmarySchool.Text;
            u2.pwd =tboxpwd.Text;
            u2.QQ =tboxQQ.Text;
            u2.realName =tboxrealName.Text;
            u2.seccondSchool =tboxseccondSchool.Text;
            u2.sex =tboxsex.Text;
            u2.sports =tboxsports.Text;
           if ( ubll.update(u2))
	        {
                Response.Write("<script>alert('更新成功')</script>");
	        }
        }


	}
}