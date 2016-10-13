<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserFavweibo.aspx.cs" Inherits="HYTCWeiBoWeb.UserFavweibo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<link rel="stylesheet" href="styles/common.css"/>
	<link rel="stylesheet" href="styles/weibo.css"/>
	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/weibo.js"></script>
</head>
<body>
	<form id="form1" runat="server">
<asp:GridView ID="gv_WeiboPersonal" runat="server" 
		CssClass="dlweibo" AutoGenerateColumns="False" 
		GridLines="None" 
		PageSize="10" DataKeyNames="weiboId"   >
			<Columns>
				<asp:TemplateField>
					  <ItemTemplate   >
					  <div class="item">
						<div class="item-left">
						<div class="userlogo">
							<%--<asp:Image ID="img_Book" runat="server" alt='<%# Eval("Title") %>' ImageUrl='<%# getBookUrl(Eval("userId")) %>' Width="30px" Height="30px" />--%>
						</div>
						<div class="btnAddFocus">
							<asp:Button ID="btnAddFocus" runat="server" Text="+关注" CssClass="btnadd" />
						</div>
					</div>
						<div class="item-right">
							<div class="authorName">	 <%# Eval("authorName") %> </div>
							<div class="wbcontent"> <%# Eval("content")%>  </div>		 
						</div>
						<div class="item-footer">
							<div class="createtime">	<%# Eval("createtime")%>  	</div>
								<ul class="action">
								<li>
									<div class="zan">
									 <input type="button" name="weiboId" value='<%# Eval("weiboId") %> ' class="weiboId" />
									 <input type="button" name="authorId" value='<%# Eval("authorId") %> ' class="authorId" />
									 <input type="button" name="btnZan" value="赞 " id="btnZan"  class="itembtn"    />                     
									 <span class="number">(<%# Eval("zanNumber")%>)</span>   
									 <div class="zanImg">
					 
									 </div>
						
									</div>
								</li>
								<li>
									 <div class="transmit">
										<asp:Button ID="btnTrans" runat="server" Text="转发" CssClass="itembtn"  />
										<span class="number">(<%# Eval("transmitNumber")%>)</span>
										<div class="trancontent">
							
										</div>
									</div>
								</li>
								<li>
									<div class="favorite">
									 <input type="button" name="weiboId" value='<%# Eval("weiboId") %> ' class="weiboId" />
									 <input type="button" name="authorId" value='<%# Eval("authorId") %> ' class="authorId" />
									 <input type="button" name="btnFavs" value="收藏 " id="btnFavs"  class="itembtn"    />      
									  <span class="number">(<%# Eval("favsNumber")%>)</span>
									</div>
								</li>
								<li>
									<div class="review">
										 <input type="button" name="name"  id="btnReview" value="评论 " class="btnReview"  />
										 <span class="number">(<%# Eval("reviewNumber")%>)</span>
										</div>					
								</li>
								<li>
								<input type="button" name="btnOpenReview" value=" 查看评论" class="btnOpenReview"/>
								</li>  				
							 </ul>


						</div> 

						  <asp:Panel ID="Panel1" runat="server" CssClass="reviewlistbox">
								<div class="WB_arrow">
									<span class="S_line1_c">◆</span>
									<span class="S_bg4_c">◆</span>
								</div>
								 <asp:Panel runat="server" ID="reviewContent"  CssClass="reviewlistcontent">
							 
								 </asp:Panel>
						  </asp:Panel>                       

						  <input type="text" name="reviewContent" value=" " class="reviewContent"  />
						  <input type="button" name="btnPubReview" value="发表 " class="btnPubReview" />
					 </div>
					 </ItemTemplate>
						
				</asp:TemplateField>
			</Columns>
			
			<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
			
		</asp:GridView>
	</form>
</body>
</html>
