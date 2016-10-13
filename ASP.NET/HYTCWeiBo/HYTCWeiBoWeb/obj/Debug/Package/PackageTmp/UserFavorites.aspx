<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserFavorites.aspx.cs" Inherits="HYTCWeiBoWeb.UserFavorites" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>收藏夹</title>
    <link rel="stylesheet" href="styles/common.css"/>
	<link rel="stylesheet" href="styles/weibo.css"/>
	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/app.js"></script>
</head>
<body>
	<form id="form1" runat="server">
	<div class="wrap">
		<div class="headerbox">
			<div class="headerfix" >
				<ul> 
					<li><div id="logo"><img src="images/color-apple.png" alt=""></div></li>
					<li><div class="logo-text">淮师校园微博</div></li>
					<li><asp:TextBox ID="txtsearchInfo"    runat="server" placeholder="search......"></asp:TextBox></li>    
					<li><asp:ImageButton  ID="ibtnSearch"  ImageUrl="images/search.png" title="搜索" runat="server"  /></li>
					<li><asp:ImageButton  ID="ibtnPhoto" CssClass="liitem" ImageUrl="images/photos.png" title=" 相册" runat="server"  /></li>     
					<li>	<asp:ImageButton  ID="ibtnMessage"  CssClass="liitem"    ImageUrl="images/e-mail.png" title=" 私信" runat="server"  /> </li>                    
					<li><asp:ImageButton  ID="ibtnTalk"  CssClass="liitem" ImageUrl="images/talk02.png" title=" 私聊" runat="server" /></li>
					<li><img  id="ibtnFavs"  class="liitem"  src="images/favsImg.png" title=" 收藏夹" alt="" ></li>
					<li><span class="userid_t">微博账号：</span>                    					
						<input type="button" name="labuserId" id="labuserId" value=" " runat="server" />                  
					</li>
					<li><asp:Button  ID="ibtnExit"   CssClass="liitem" Text="退出"  runat="server" PostBackUrl="~/Login.aspx" /></li>
				</ul> 
				<div class="flowerpic"><img src="images/flowerpic.png" alt=""></div>
			</div>
		</div>
        
		<div id="container">
        <div>我的收藏 <span>(<input type="button" name="favNumber" value=" " id="favNumber"/>)</span></div>
			<asp:GridView ID="gv_FavoritesList" runat="server">
            <Columns>
            <asp:TemplateField>
            <ItemTemplate>
                <div class="favitem">                
                    <div class="favId">收藏号<%Eval("favoritesId")%> </div>
                    <div class="createTime"><span>收藏于 </span><%Eval("createTime")%></div>
                    <div class="weiboitem"></div>
                </div>
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
			</asp:GridView>

		
	
		<div class="footer">
			@copyright 2014 淮阴师范学院 &nbsp;计算机科学与技术学院 1003班 Crystal Zhu
		</div>   
	</div>
	</div>
	</form>
</body>
</html>
