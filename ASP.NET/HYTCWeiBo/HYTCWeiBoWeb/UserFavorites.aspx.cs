using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HYTCWeiBoWeb
{
    public partial class UserFavorites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userId = Request["userId"];
                Response.Write(userId);
                Response.Write("<script>+"+
                
                
                "</script>");
            }
        }
    }
}