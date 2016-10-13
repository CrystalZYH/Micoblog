<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="HYTCWeiBoWeb.UserInfo"  ErrorPage="~/help.html" %>
<%@ PreviousPageType VirtualPath="~/MainForm.aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML .0 Transitional//EN" "http://www.w3.org/TR/xhtml/DTD/xhtml-transitional.dtd">

<html xmlns="http://www.w3.org/999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta name="viewport"
		  content="width=device-width,initial-scale=.0,minimum-scale=.0,maximum-scale=.0,user-scalable=no"/>
	<meta name="description" content="HYTCWeiBo">
	<meta name="author" content="ZYH">
	<title>Userinfo.html</title>
	<link rel="shortcut icon" href="favicon.ico">
	<link rel="stylesheet" href="styles/common.css">
	<link rel="stylesheet" href="styles/userinfo.css">
    <script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
   <script type="text/javascript" src="scripts/mainForm.js"></script>

</head>
<body>
		<div class="header">
		<div id="logo"><img src="images/logo.png" alt=""></div> 
		<span>淮师校园微博</span>		
	</div>
	<form id="form" runat="server">
	<div class="content">

		<ul>          
           <li>  <asp:Label ID="labuserId" runat="server" Text="用户号"></asp:Label>
                    <asp:Label ID="labuserId2" runat="server" Text=""></asp:Label>
           </li>    
          <li>  <asp:Label ID="labuserName" runat="server" Text="用户名"></asp:Label>
                    <asp:Label ID="labuserName2" runat="server" Text=""></asp:Label>
          </li>      
           <li>  <asp:Label ID="labpwd" runat="server" Text="密码"></asp:Label>
                      <asp:TextBox ID="tboxpwd" runat="server"  CssClass=""></asp:TextBox>
           </li>          
           <li>  <asp:Label ID="labemail" runat="server" Text="邮箱"></asp:Label>
                    <asp:TextBox ID="tboxemail" runat="server"  CssClass=""></asp:TextBox>
          </li>   
          <li>  <asp:Label ID="labsex" runat="server" Text="性别"></asp:Label>
                    <asp:TextBox ID="tboxsex" runat="server"  CssClass=""></asp:TextBox>
          </li>      
          <li>  <asp:Label ID="labcolloge" runat="server" Text="学院"></asp:Label>
                  <asp:TextBox ID="tboxcolloge" runat="server"  CssClass=""></asp:TextBox>
          </li> 
           <li>  <asp:Label ID="labinCollogeYear" runat="server" Text="入学年龄"></asp:Label>
                   <asp:TextBox ID="tboxinCollogeYear" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labrealName" runat="server" Text="真实姓名"></asp:Label>
                   <asp:TextBox ID="tboxrealName" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labhome" runat="server" Text="籍贯"></asp:Label>
                      <asp:TextBox ID="tboxhome" runat="server"  CssClass=""></asp:TextBox>
           </li>   
           <li>  <asp:Label ID="labbirthday" runat="server" Text="生日"></asp:Label>
                   <asp:TextBox ID="tboxbirthday" runat="server"  CssClass=""></asp:TextBox>
           </li>  
           <li>  <asp:Label ID="labboodtype" runat="server" Text="血型"></asp:Label>
                     <asp:TextBox ID="tboxboodtype" runat="server"  CssClass=""></asp:TextBox>
                     <%--<asp:ListBox ID="lboxboodtype" runat="server" CssClass=""       >
                         <asp:ListItem Selected="True">A型</asp:ListItem>
                         <asp:ListItem>B型</asp:ListItem>
                         <asp:ListItem>AB型</asp:ListItem>
                         <asp:ListItem>O型</asp:ListItem>
                         <asp:ListItem>其他</asp:ListItem>
               </asp:ListBox>--%>
           </li> 
            
           <li>  <asp:Label ID="labpersonalwords" runat="server" Text="个性签名"></asp:Label>
                   <asp:TextBox ID="tboxpersonalwords" runat="server"  CssClass=""></asp:TextBox>
           </li>  
            <hr />    
          <li>  <asp:Label ID="labphone" runat="server" Text="手机号"></asp:Label>
                     <asp:TextBox ID="tboxphone" runat="server"  CssClass=""></asp:TextBox>
          </li>				     
          <li>  <asp:Label ID="labQQ" runat="server" Text="QQ"></asp:Label>
                  <asp:TextBox ID="tboxQQ" runat="server"  CssClass=""></asp:TextBox>
          </li>     
           <li>  <asp:Label ID="labMSN" runat="server" Text="MSN"></asp:Label>
                     <asp:TextBox ID="tboxMSN" runat="server"  CssClass=""></asp:TextBox>
           </li>     
           <li>  <asp:Label ID="labprinmarySchool" runat="server" Text="小学"></asp:Label>
                       <asp:TextBox ID="tboxprinmarySchool" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labseccondSchool" runat="server" Text="中学"></asp:Label>
                   <asp:TextBox ID="tboxseccondSchool" runat="server"  CssClass=""></asp:TextBox>
           </li>   
           <li>  <asp:Label ID="labhobbies" runat="server" Text="爱好"></asp:Label>
                      <asp:TextBox ID="tboxhobbies" runat="server"  CssClass=""></asp:TextBox>
           </li>  
           <li>  <asp:Label ID="labsports" runat="server" Text="体育运动"></asp:Label>
                   <asp:TextBox ID="tboxsports" runat="server"  CssClass=""></asp:TextBox>
           </li>   
           <li>  <asp:Label ID="labbestBook" runat="server" Text="最喜欢的书"></asp:Label>
                   <asp:TextBox ID="tboxbestBook" runat="server"  CssClass=""></asp:TextBox>
           </li> 
          <li>  <asp:Label ID="labbestFilm" runat="server" Text="最喜欢的电影"></asp:Label>
                  <asp:TextBox ID="tboxbestFilm" runat="server"  CssClass=""></asp:TextBox>
          </li>  
           <li>  <asp:Label ID="labbestSong" runat="server" Text="最喜欢的歌曲"></asp:Label>
                    <asp:TextBox ID="tboxbestSong" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labbestFood" runat="server" Text="最喜欢的食物"></asp:Label>
                    <asp:TextBox ID="tboxbestFood" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labbestStars" runat="server" Text="最喜欢的明星"></asp:Label>
                    <asp:TextBox ID="tboxbestStars" runat="server"  CssClass=""></asp:TextBox>
           </li> 
           <li>  <asp:Label ID="labbestGames" runat="server" Text="最喜欢的游戏"></asp:Label>
                     <asp:TextBox ID="tboxbestGames" runat="server"  CssClass=""></asp:TextBox>
           </li>                          
           <li>  <asp:Label ID="labbestPlaces" runat="server" Text="最喜欢的地方"></asp:Label>
                    <asp:TextBox ID="tboxbestPlaces" runat="server"  CssClass=""></asp:TextBox>
           </li>  

		</ul>

		<asp:Button ID="btnSave" runat="server" Text="保 存" CssClass="btnlarge_blue"  
            style = "display:inline-block;" onclick="btnSave_Click"/>
		<a href="MainForm.aspx"><asp:Button ID="btnCancel" runat="server" Text="返 回" 
			CssClass="btnlarge_blue" onclick="btnCancel_Click" />
		</a>
	</div>
	</form>
</body>
</html>
