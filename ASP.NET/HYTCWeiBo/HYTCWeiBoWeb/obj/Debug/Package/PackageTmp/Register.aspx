<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HYTCWeiBoWeb.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta name="viewport"
		  content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"/>
	<meta name="description" content="HYTCWeiBo">
	<meta name="author" content="ZYH">
	<title>register.aspx</title>
	<link rel="shortcut icon" href="favicon.ico">
	<link rel="stylesheet" href="styles/common.css">
	<link rel="stylesheet" href="styles/register.css">
<%--	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/app.js"></script>--%>
</head>
<body>
	<form id="form1" runat="server">
	<div class="header">
		<div id="logo"><img src="images/logo.png" alt=""></div> 
		<span>淮师校园微博</span>     
	</div>
	<div id="container">
		<div id="banner"><img src="images/calendar.png" alt=""></div>

		<div id="boxcontent">           
			<div id="personal">             
				<label for=""><span>*</span>用户名</label>
				<asp:TextBox ID="userName" runat="server" ontextchanged="userName_TextChanged"></asp:TextBox>
				<span class="icon"></span> 
					<%--<asp:Image ID="check" runat="server" />--%>
					<asp:Label ID="labcheck" runat="server" Text="X"></asp:Label>
				<span class="notes "><i>用户名为字母加数字或符号的组合，不能以符号开头，长度为6-40</i>
				</span><br>
				<label for=""><span>*</span>性&nbsp;&nbsp;&nbsp;别</label>
					<asp:RadioButton ID="radsexNan"  Name=" sex" runat="server" />	男	
					<asp:RadioButton ID="radsexNv"  Name=" sex" runat="server" />	女 	
				<br>		
				<label for=""><span>*</span>邮&nbsp;&nbsp;&nbsp;箱</label>
					<input id="email" type="text" runat="server">
				<span class="icon"></span>
				<span class="notes"><i>请正确输入邮箱格式</i>
				</span><br>				
				<label for=""><span>*</span>个性签名</label><input id="pwords" type="text" runat="server">
				<span class="icon"></span>
				<span class="notes"><i>中文或外文皆可</i>
				</span><br>		 				 				
				<label for=""><span>*</span>密&nbsp;&nbsp;&nbsp;码</label>
				<input id="pwd"  type="password" runat="server">
				<span class="icon"></span>
				<span class="notes"><i>密码为字母加数字或符号的组合，长度为6-12</i>
				</span><br>		 				
				<label for=""><span>*</span>再输一遍密码</label>
				<input id="pwd2" type="password" runat="server">
				<span class="icon"></span>
				<span class="notes"><i>请再输一遍密码</i>
				</span><br>	<br>   
				<asp:RadioButton ID="radRead" runat="server" />我已阅读<a href="guaifan.html" target="_blank">《淮师校园微博规范》</a><br><br>
				 <asp:Label ID="labInfo" runat="server" Text="" style="color:red;margin: 30px  50px; font-size:13px;"></asp:Label><br>
				<asp:Button ID="btnRegister" runat="server" Text="注 册"  
					cssClass="btnlarge_blue"  style="display:inline;margin:20px;" 
					onclick="btnRegister_Click"/>
				<asp:Button ID="btnCancel" runat="server" Text="取 消"  cssClass="btnlarge_blue" 
					style="display:inline;margin:20px; " onclick="btnCancel_Click"/>
					
			</div>
			<!-- <div id="team"></div> -->
		</div>	


	</div>
	<div class="footer">
		@copyright 2014 淮阴师范学院 &nbsp;计算机科学与技术学院 1003班 Crystal Zhu
	</div>
	</form>
</body>
</html>
