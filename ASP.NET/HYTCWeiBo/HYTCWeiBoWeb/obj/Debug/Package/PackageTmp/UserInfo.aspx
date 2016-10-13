<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="HYTCWeiBoWeb.UserInfo"  ErrorPage="~/help.html" %>
<%@ PreviousPageType VirtualPath="~/MainForm.aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta name="viewport"
		  content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"/>
	<meta name="description" content="HYTCWeiBo">
	<meta name="author" content="ZYH">
	<title>Userinfo.html</title>
	<link rel="shortcut icon" href="favicon.ico">
	<link rel="stylesheet" href="styles/common.css">
	<link rel="stylesheet" href="styles/login.css">
	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/app.js"></script>
	<style type="text/css">
		.content
		{
			width:70%;
			margin:10% auto;
			boder:1px solid  gray;
		}
		.label
		{
			height:35px;
		   }
		   .pwords
		   {
			   width:200px;
			}
			.collgoe
			{
				width:200px;
				height:35px;
			}
	</style>
</head>
<body>
		<div class="header">
		<div id="logo"><img src="images/logo.png" alt=""></div> 
		<span>淮师校园微博</span>		
	</div>
	<form id="form1" runat="server">
	<div class="content">
	  个人资料：<br /><br />
	  用户名：<asp:Label ID="userName" runat="server" Text="敲键盘的人" CssClass="lablel"></asp:Label> 
		<br /><br />
		个性签名：<asp:TextBox ID="pwords" runat="server" Text="无"  CssClass="pwords"></asp:TextBox><br /><br />
		学院：<asp:TextBox ID="colloge" runat="server"  Text="计算机学院 "  CssClass="colloge"></asp:TextBox> <br />
		<br />
		<asp:Button ID="btnSave" runat="server" Text="保 存" CssClass="btnlarge_blue"  style = "display:inline-block;"/>
		<a href="MainForm.aspx"><asp:Button ID="btnCancel" runat="server" Text="返 回" 
			CssClass="btnlarge_blue" onclick="btnCancel_Click" />
		</a>
	</div>
	</form>
</body>
</html>
