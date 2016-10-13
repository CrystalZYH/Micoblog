<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="HYTCWeiBoWeb.MainForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
	<meta name="viewport"
		  content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"/>
	<meta name="description" content="HYTCWeiBo"/>
	<meta name="author" content="ZYH"/>
	<title>MainForm.aspx</title>
	<link rel="shortcut icon" href="favicon.ico"/>
	<link rel="stylesheet" href="styles/common.css"/>
	<link rel="stylesheet" href="styles/mainForm.css"/>
	<link rel="stylesheet" href="styles/weibo.css"/>
	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
   <script type="text/javascript" src="scripts/app.js"></script>
	<script type="text/javascript">
		
	
	</script>
 </head>
<body>

	<form id="form1"  runat="server">
	 <div class="wrap">
		<div class="headerbox">
			<div class="headerfix" >
				<ul> 
					<li><div id="logo"><img src="images/color-apple.png" alt=""></div></li>
					<li><div class="logo-text">淮师校园微博</div></li>
					<li><asp:TextBox ID="txtsearchInfo"    runat="server" placeholder="search......"></asp:TextBox></li>    
<%--					<li><asp:ImageButton  ID="ibtnSearch"  ImageUrl="images/search.png" title="搜索" runat="server"  /></li>
					<li><asp:ImageButton  ID="ibtnPhoto" CssClass="liitem" ImageUrl="images/photos.png" title=" 相册" runat="server"  /></li>     
					<li>	<asp:ImageButton  ID="ibtnMessage"  CssClass="liitem"    ImageUrl="images/e-mail.png" title=" 私信" runat="server"  /> </li>                    
					<li><asp:ImageButton  ID="ibtnTalk"  CssClass="liitem" ImageUrl="images/talk02.png" title=" 私聊" runat="server" /></li>
--%>					<li><img  id="ibtnFavs"  class="liitem"  src="images/favsImg.png" title=" 收藏夹" alt="" ></li>
					<li><span class="userid_t">在线用户：</span>                    					
						<input type="button" name="labuserId" id="labuserId" value=" " runat="server" />                  
					</li>
					<li><asp:Button  ID="ibtnExit"   CssClass="liitem" Text="退出"  runat="server" PostBackUrl="~/Login.aspx" /></li>
				</ul> 
				<div class="flowerpic"><img src="images/flowerpic.png" alt=""></div>
			</div>
		</div>
		
		<div id="container">
			<div class="top">
				<div class="user-logos">
					<div id="userlogo"><img src="images/eyelogo.jpeg" alt=""></div>
					<ul>
						<li>
							<div id="focus"><asp:Label ID="labfocusNo" runat="server" Text="0"></asp:Label><br/>
							<span>
								<input type="button" name="btnFocus" value="关注 " id="btnFocus" style="border-style:none"/>
							</span>
							</div>
						</li>
						<li>
							<div id="fans"><asp:Label ID="labfansNo" runat="server" Text="0"></asp:Label><br/>
							<span>
								 <input type="button" name="btnFans" value="粉丝 " id="btnFans" style="border-style:none"/>
							 </span>
							</div>
						</li>
						<li>
							<div id="weibo"><asp:Label ID="labweiboNo" runat="server" Text="0"></asp:Label><br/>
							<span>
									 <input type="button" name="btnWeiBo" value="微博 " id="btnWeiBo" style="border-style:none"/>
							</span>
							</div>
						</li>
					</ul>
				</div>
				<div class="user-info">
					<div class="username">
                        <input type="button" name="btnmasterName" id="btnmasterName" value=" " runat="server" />
                        <input type="button" name="btnmasterId" id="btnmasterId" value=" " runat="server" class="hiddenInfo"/>
                        <input type="button" name="btnguestId" id="btnguestId" value=" " runat="server" class="hiddenInfo"/>
                        <input type="button" name="btnguestName" id="btnguestName" value=" " runat="server" class="hiddenInfo"/>
					</div> 
					<asp:Label ID="labpWords"  runat="server" Text="" ></asp:Label>                                
						<asp:Label ID="labsex"    runat="server" Text=""></asp:Label>
						<asp:Label ID="labcolloge"   runat="server" Text=""></asp:Label>
		
				<div id="editinfo">		
					<input type="button" id="btnEdit"  name="btnEdit" value="编辑个人资料 "  runat="server" />
					<input type="button" id="btnAddFocus"  name="btnAddFocus" value="+关注 " runat="server" />
				</div>
			</div>
			</div>

			<div id="left-weibo">
			   <asp:Panel runat="server"  ID="publish">
				   <asp:Image  ID="pubImg" ImageUrl="Images/pubImg.PNG" runat="server" />               
					<div class="pubInfo"> 发言请遵守社区公约，您还可输入<span>140</span>字
					</div>	
					   <textarea id="txtPubContent" cols="20" rows="2" class="txtPubContent" ></textarea>
						 <input type="button"  id="btnPublish" name="name" value="发布" />
                </asp:Panel>
				<div id="weiboselect">
				   <div id="WeiBoFocus" class="focus selected" onclick="" >关注微博</div>  
				   <div id="WeiboPersonal"  class="persoanal">个人微博</div> 
				   <div id="WeiBoAll" class="all">全部微博</div> 
				</div>

						  
			   <div class="weibo-content">                
						<div id="personalweibo">
                        <span style="margin:100px auto; font-family:微软雅黑;  font-size:30px;">Welcome......  </span>
				        </div> 
			   </div>
			</div>

			<div id="right-fans">
				<div class="title-1">
				</div>
			</div>

	
		
		

		
	
		<div class="footer">
			@copyright 2014 淮阴师范学院 &nbsp;计算机科学与技术学院 1003班 Crystal Zhu
		</div>   
	</div>
                <asp:Panel runat="server"  ID="TransmitbgBox" CssClass="transmitbgbox">
                <div class="transcontainer">
                    <div class="transcontent">
                        <asp:Label Text="转发评论" runat="server" style="color:blue; font-weight:bold;margin:10px;"/>
                        <textarea id="txtTransContent" cols="20" rows="2" class=""  placeholder="转发说点儿什么吧"></textarea>
                    </div>
                    <input type="button" name="transCancle" id ="transCancle"  value="取消" />
                    <input type="button" name="transYes" id="transYes"  value="确定" />
                </div>
            </asp:Panel>
	</div>
	</form>
		<script type="text/javascript" src="scripts/mainForm.js"></script>
</body>
</html>
