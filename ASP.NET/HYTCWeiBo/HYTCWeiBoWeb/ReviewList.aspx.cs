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
    public partial class ReviewList : System.Web.UI.Page
    {
        ReviewsBLL rebll = new ReviewsBLL();
        Reviews re = new Reviews();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int  weiboId = Convert.ToInt32(Request["weiboId"]);
                re.weiboId = weiboId;
                re.reAuthorId=Convert.ToInt32(Request["reauthorid"]);
                if (re.reAuthorId!=0)
                {
                    re.reAuthorName = Request["reauthorname"].ToString();
                    re.returnContent = Request["recontent"].ToString();
                    re.reTime = DateTime.Now;
                    if (rebll.save(re))
                    {                       

                    }
                }
                //weiboId = 200;
                gv_ReviewList.DataSource = rebll.findReviewsByweiboId(weiboId);
                gv_ReviewList.DataBind();
            }

        }
    }
}