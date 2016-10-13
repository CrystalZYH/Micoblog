<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HYTCWeiBoWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta name="viewport"
		  content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"/>
	<meta name="description" content="HYTCWeiBo">
	<meta name="author" content="ZYH">
	<title>login.aspx</title>
	<link rel="shortcut icon" href="favicon.ico">
	<link rel="stylesheet" href="styles/common.css">
	<link rel="stylesheet" href="styles/login.css">
<%--	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/app.js"></script>--%>
 </head>
<body>
	
	<div class="header">
		<div id="logo"><img src="images/logo.png" alt=""></div> 
		<span>淮师校园微博</span>		
	</div>
	<div id="container">
		<div id="banner"> <img src="images/calendar.png" alt=""></div>
		<div id="content" class="clearfix">
			<div id="left">
				<img src="images/loginpic.png" alt="">
			</div>
			<form id="form1" runat="server">
			<div id="right">
				<asp:TextBox ID="txtUserName" runat="server" placeholder="用户名admin/邮箱example@.com"></asp:TextBox>
				 <asp:TextBox ID="txtUserPwd" runat="server" placeholder="密码......" 
					TextMode="Password"></asp:TextBox>
				<div class="r_pwd">
					<asp:Label ID="labInfo" runat="server" Text=""></asp:Label><a href="#"><%--忘记密码？--%></a></div> 	
			   <asp:Button ID="btnLogin" runat="server" Text="登  录" 
					CssClass="btnlarge_blue login" onclick="btnLogin_Click"/>
				<div class="title clearfix">
					<span><i>还没有账号？</i></span>
					<div class="helppic"><%--<a href="help.html">--%><img src="images/help.png" alt="帮助"><%--</a>--%> </div>      
				 </div>     
				 <asp:Button ID="btnRegister" runat="server" Text="立即注册" 
					CssClass="btnlarge_blue register" onclick="btnRegister_Click"/>
			</div>
			</form>
		</div>
		
	</div>
	<div class="footer">
		@copyright 2014 淮阴师范学院 &nbsp;计算机科学与技术学院 1003班 Crystal Zhu
	</div>

</body>
</html>
