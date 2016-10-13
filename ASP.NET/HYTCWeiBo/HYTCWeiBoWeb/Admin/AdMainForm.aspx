<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdMainForm.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.AdMainForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	  <title>淮师校园微博——主管理界面</title>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<meta name="description" content="Charisma, a fully featured, responsive, HTML5, Bootstrap admin template."/>
	<meta name="author" content="DY"/>

	<!-- The styles -->
	<link id="bs_css" href="css/bootstrap.css" rel="stylesheet"/>
    	<link rel="shortcut icon" href="favicon.ico">
	<link rel="stylesheet" href="styles/common.css">
	<link rel="stylesheet" href="styles/login.css">
	<style type="text/css">
   #left
   {

   }
      #right
   {
    
       margin: 200px auto;
   }
	</style>

	<link rel="shortcut icon" href="img/favicon.ico">
		
</head>

<body>
    <form id="form2" runat="server">
    <div id="left" >

    </div>
      <div id="right">
        <asp:Button ID="Button1" runat="server" Text="用户管理"  PostBackUrl="~/Admin/UserManages.aspx" CssClass="btn"  />
    <asp:Button ID="Button2" runat="server" Text="微博管理"  PostBackUrl="~/Admin/WeiBoManage.aspx" CssClass="btn"/>
     <asp:Button ID="Button3" runat="server" Text="静态图表分析"  PostBackUrl="~/Admin/Charts.aspx" CssClass="btn"/>
    </div>
  
    </form>
		
</body>
