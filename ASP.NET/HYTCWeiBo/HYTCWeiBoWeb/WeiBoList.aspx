<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeiBoList.aspx.cs" Inherits="HYTCWeiBoWeb.WeiBoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>WeiBoList.aspx</title>
	<link rel="shortcut icon" href="favicon.ico"/>
	<link rel="stylesheet" href="styles/common.css"/>
	<link rel="stylesheet" href="styles/weibo.css"/>
	<script type="text/javascript" src="scripts/libs/jquery/jquery-2.1.0.min.js"></script>
	<script type="text/javascript" src="scripts/libs/TweenMax.js"></script>
	<script type="text/javascript" src="scripts/weibo.js"></script>
    <script type="text/javascript">

    </script>
</head>
<body>
	<form id="form4" runat="server">
<asp:GridView ID="gv_WeiboList" runat="server" AllowPaging="true"
		CssClass="dlweibo" AutoGenerateColumns="False" 
		GridLines="None" 
		PageSize="20" DataKeyNames="weiboId" 
		onpageindexchanging="gv_WeiboPersonal_PageIndexChanging" 		>
			<Columns>
				<asp:TemplateField>
					  <ItemTemplate   >
					  <div class="item">
						  <div class="item-top">
							  <div class="item-top-top">
									<div class="isOriginal">[<%# Eval("isOriginal")%>]</div>
									<div class="trTime"><%#setForm(Eval("orTime"), Eval("isOriginal"))%></div>
							  </div>		
							  <div class="item-top-left">
									<div class="trAuthorId"><%# Eval("orAuthorId")%></div>
									<div class="truserlogo">
										 <%#getUserlogoURL2( Eval("orAuthorId"),Eval("isOriginal"))%>
									</div>
							  </div>
							  <div class="item-top-right">
								  <div  class="trAuthorName"><%# Eval("orAuthorName")%></div>
								  <div class="trContent"><%# Eval("orContent")%></div>							      
							  </div>

						  </div>
						  <div class="item-body <%#setCss( Eval("isOriginal"))%>">
								<div class="item-left">
										<div class="userlogo">
											  <img src="<%#getUserlogoURL(Eval("authorId"))%>" alt="logo"  />
										</div>
										<div class="btnAddFocus">
											<input type="button"  id="btnAddFocus" name="btnAddFocus" value="+关注 " class="btnadd" />
										</div>
										 <input type="button" name="name" value='<%# Eval("weiboId") %> ' class="weiboId" />
										<input type="button" name="name" value='<%# Eval("authorId") %> ' class="authorId" />
									</div>
								<div class="item-right">
									<div class="authorName">
										<a href="MainForm.aspx?masterid=<%# Eval("authorId") %>&guestid=<%#getguestid() %>" target="_blank" title="点击进入主页"><%# Eval("authorName") %></a>	 
										</div>
									<div class="wbcontent"> <%# Eval("content")%>  </div>		 
								</div>
								<div class="item-footer">
							<div class="createtime">	<%# Eval("createtime")%>  	</div>
								<ul class="action">
								<li>
									<div class="zan">
									 <input type="button" name="btnZan" value="赞 " id="btnZan"  class="itembtn"    />                     
									 <span class="number">(<%# Eval("zanNumber")%>)</span>   
									 <div class="zanImg">
					 
									 </div>
						
									</div>
								</li>
								<li>
									 <div class="transmit">
										 <input type="button" id="btnTrans"  name="btnTrans" value="转发 "class="" />
										<span class="number">(<%# Eval("transmitNumber")%>)</span>
										<div class="trancontent">
							
										</div>
									</div>
								</li>
								<li>
									<div class="favorite">
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

						


					 </div>
					 </ItemTemplate>
						
				</asp:TemplateField>
			</Columns>
			<EmptyDataTemplate>
				<br />
				<br />
			<span style="  font-size:14px; text-align:center;" >还没有微博记录......</span> 
			</EmptyDataTemplate>
			
			<PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
			
		</asp:GridView>
	</form>
</body>
</html>
