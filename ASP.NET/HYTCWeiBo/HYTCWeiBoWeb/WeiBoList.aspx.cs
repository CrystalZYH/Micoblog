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
	public partial class WeiBoList : System.Web.UI.Page
	{

		WeiBoBLL wbll = new WeiBoBLL();
		WeiBo wb = new WeiBo();
		FavoritesBLL fbll = new FavoritesBLL();
		Favorites f = new Favorites();
		FansMarksBLL fmbll = new FansMarksBLL();
		FansMarks fms = new FansMarks();
		int  userId,guestid;
		string listid, optionName;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				 optionName = Request["optionName"].ToString();
				 listid=Request["listid"].ToString();
				 userId = Convert.ToInt32(Request["userId"]);
				 guestid = Convert.ToInt32(Request["guestid"]);
				 switch (optionName)
				 {
					 case "save": wb.authorId = Convert.ToInt32(Request["authorId"]);
											wb.authorName = Request["authorName"];
											wb.content = Request["content"];
											wb.createTime = DateTime.Now;
											wb.isOriginal = Request["isOriginal"];
											wb.transmitNumber = Convert.ToInt32(Request["transmitNumber"]);
											wb.zanNumber = Convert.ToInt32(Request["zanNumber"]);
											wb.reviewNumber = Convert.ToInt32(Request["reviewNumber"]);
											wb.favsNumber = Convert.ToInt32(Request["favsNumber"]);
											wb.orTime = DateTime.Now;//为防止数据为空报错，设置的默认数据不显示不影响程序
											if (wb.content != null && wb.content != "" && wb.authorName != null && wb.authorName != "" && wb.authorId != 0)
											{
												if (wbll.save(wb))
												{

												}
											}
											break;
					 case "btnZan": wb.weiboId = Convert.ToInt32(Request["weiboId"]);
												   WeiBo wb2 = wbll.findWeiboByweiboId(wb.weiboId);
												 wb2.zanNumber = wb2.zanNumber + 1;
												 if (wbll.updateZanFavsReviewTrans(wb2))
												 {
                                                     Response.Write("<Script>alert('点赞成功')</Script>");
												 }
												 break;
					 case "btnFavs": wb.weiboId = Convert.ToInt32(Request["weiboId"]);
												if (fbll.findFavoritesByweiboIdandfavPersonId(wb.weiboId, guestid) != null)
												 {
													 Response.Write("<Script>alert('该微博已在收藏夹中')</Script>");
												 }
												 else
												 {
													 WeiBo wb3 = wbll.findWeiboByweiboId(wb.weiboId);
													 wb3.favsNumber = wb3.favsNumber + 1;
													 f.weiboId = wb.weiboId;
													 f.favPersonId = guestid;
													 f.createTime = DateTime.Now;
													 if (wbll.updateZanFavsReviewTrans(wb3) && fbll.save(f))
													 {
														 //Response.Write("<Script>alert('收藏成功')</Script>");
													 }
												 }
						 break;
					 case "review": wb.weiboId = Convert.ToInt32(Request["weiboId"]);
												WeiBo wb4= wbll.findWeiboByweiboId(wb.weiboId);
												 wb4.reviewNumber = wb4.reviewNumber+ 1;
												 if (wbll.updateZanFavsReviewTrans(wb4))
												 {
                                                     Response.Write("<Script>alert('评论成功')</Script>");
												 }
						 break;
					 case "addFocus": fms.onselfId = userId;
													 fms.otherId = Convert.ToInt32(Request["authorId"]);
													 fms.createTime = DateTime.Now;
													 if (fms.onselfId==fms.otherId)
													 {
														  Response.Write("<Script>alert('对自己加关注无效')</Script>");
													 }
													 else
													 {
														 if (fmbll.findFansMarksByonselfIdandotherId(fms.onselfId, fms.otherId) != null)
														 {
															 Response.Write("<Script>alert('已添加关注')</Script>");
														 }
														 else
														 {
															 if (fmbll.save(fms))
															 {
																 Response.Write("<Script>alert('关注成功')</Script>");
															 }
														 }
													 }
													 

						 break;
                     case "btnTrans": WeiBo wbt = wbll.findWeiboByweiboId(Convert.ToInt32(Request["weiboId"]));
                                                     wb.authorId = wbt.authorId;
                                                     wb.authorName = wbt.authorName;
                                                     wb.content = wbt.content;
                                                     wb.createTime = wb.createTime;
                                                     wb.isOriginal ="转发";
                                                     wb.transmitNumber = wbt.transmitNumber + 1;
                                                     wb.zanNumber = wbt.zanNumber;
                                                     wb.reviewNumber = wbt.reviewNumber;
                                                     wb.favsNumber = wbt.favsNumber;
                                                     wb.orTime = DateTime.Now;
                                                     wb.orAuthorId = guestid;
                                                     wb.orAuthorName = Request["guestname"].ToString();
                                                     wb.orContent = Request["transContent"].ToString();
                                                    if (wb.content != null && wb.content != "" && wb.authorName != null && wb.authorName != "" && wb.authorId != 0)
                                                    {
                                                        if (wbll.save(wb))
                                                        {

                                                        }
                                                    }
						 break;
				 }
				

				dlDataBind(userId,listid);

			}
		}

		public void dlDataBind(int id,string listid)
		{
			IList<WeiBo> listwb = null;
			switch(listid)
			{
				case "WeiBoFocus": listwb = wbll.findfocusWeiBosByonselfId(id);
					break;
				case "WeiboPersonal":  listwb = wbll.findWeiboByauthorId(id);
					break;
				case "WeiBoAll": listwb = wbll.findall();
					break;
				default: listwb = wbll.findall(); 
					break;

			}
			
			gv_WeiboList.DataSource = listwb;
			gv_WeiboList.DataBind();
		}

		//分页
		protected void gv_WeiboPersonal_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gv_WeiboList.PageIndex = e.NewPageIndex;
			//listid = "WeiBoAll";
			dlDataBind(userId,listid);
		}

		public string setForm(object t, object isOriginal)
	   {
		   if ((String)isOriginal=="原创")
		   {                           
				return "";
		   }
		   else
		   {
			   return "转发于"+t;
		   }
	   }

		public string getUserlogoURL(object id)
		{
			string URL;
			UserBLL usbll = new UserBLL();
			int userid = (Int32)id;
			User u = new User();
			u = usbll.findUserByUserId(userid);
		   if ( u.sex.Trim()=="男")
			{
			   URL = "upload/logoimg/logoimgdf1.png";
			}
		   else
		   {
			   URL = "upload/logoimg/logoimgdf2.png";
		   }
			return URL;
		}

		public string getUserlogoURL2(object id, object isOriginal)
		{
			if ((String)isOriginal == "原创")
			{
				return "";
			}
			else
			{           
			   string URL= getUserlogoURL(id);
				string imgstr="<img src="+URL+" alt='logo' width='48px' height='48px'/>";
				return imgstr;
			}
		}

		public string setCss(object isOriginal)
		{
			if ((String)isOriginal == "原创")
			{
				return "";
			}
			else
			{
				return "tr";
			}
		}

		public int getguestid(){
			return guestid;
		}
	}
}