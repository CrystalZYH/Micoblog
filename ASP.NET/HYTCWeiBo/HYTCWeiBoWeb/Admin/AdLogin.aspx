<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdLogin.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.AdLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>淮师校园微博后台管理系统</title>
	<link id="bs_css" href="css/bootstrap.css" rel="stylesheet"/>
	<link id="bs_css" href="styles/AdLogin.css" rel="stylesheet"/>
	<style type="text/css">
	  body {
		padding-bottom: 40px;
	  }
	  .sidebar-nav {
		padding: 9px 0;
	  }
	  .container-fluid
	  {
	      position:relative !important;
	         width:30%;
	         left:30%;
	         top:20%;
	        text-align:center !important;
	</style>
</head>
<body>
	<div class="container-fluid">
		<div class="row-fluid">
		
			<div class="row-fluid">
				<div class="span12 center login-header">
					<h2>欢迎登陆<br />淮师校园微博后台管理系统</h2>
				</div><!--/span-->
			</div><!--/row-->
			
			<div class="row-fluid">
				<div class="well span5 center login-box">
					<div class="alert alert-info">
						请输入用户名和密码
					</div>
					<form id="Form1" class="form-horizontal"  method="post" runat="server">
						<fieldset>
							<legend></legend>
							<div class="input-prepend" title="Username" data-rel="tooltip">
								<span class="add-on"><i class="icon-user"></i></span>
								<%--<input autofocus class="input-large span10" name="username" id="username" type="text" value="admin" />--%>
								<asp:TextBox ID="txtLoginId" runat="server" CssClass="input-large span10" Text=""></asp:TextBox>
							</div>
							<div class="clearfix"></div>

							<div class="input-prepend" title="Password" data-rel="tooltip">
								<span class="add-on"><i class="icon-lock"></i></span>
							 <%--   <input class="input-large span10" name="password" id="password" type="password" value="admin123456" />--%>
								<asp:TextBox ID="txtLoginPwd" runat="server" CssClass="input-large span10" TextMode="Password"></asp:TextBox>
							</div>
							<div class="clearfix"></div>

							<div class="input-prepend">
							<%--<label class="remember" for="remember">
								<input type="checkbox" id="remember" />Remember me</label>--%>
								<asp:Label ID="labInfo" runat="server" Text="友情提示：用户名或密码输入不正确" style="color:purple;"></asp:Label>
							</div>
							<div class="clearfix"></div>

							<p class="center span5">
							<%--<button type="submit" class="btn btn-primary">Login</button>--%>
							<a href=“AdMainForm.aspx”><asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" /></a>
							</p>
						</fieldset>
					</form>
				</div><!--/span-->
			</div><!--/row-->
				</div><!--/fluid-row-->
		
	</div>
</body>
</html>
