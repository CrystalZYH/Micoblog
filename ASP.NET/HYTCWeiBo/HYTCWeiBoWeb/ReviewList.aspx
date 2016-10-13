<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewList.aspx.cs" Inherits="HYTCWeiBoWeb.ReviewList" %>


    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv_ReviewList" runat="server" AutoGenerateColumns="False"  CssClass="gvrelist">
        <Columns>
        <asp:TemplateField>
        <ItemTemplate>
            <div class="revitem">
                <div class="logo"></div>
                <div class="reviewid"><%#Eval("reviewId")%></div>
                <div class="reauthorname"><%#Eval("reAuthorName")%>:</div>
                <div class="recontent"><%#Eval("returnContent")%></div>
                <div class="retime">(<%#Eval("reTime")%>)</div>
               <%-- <div class="btndelete"></div>--%>
            </div>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        
        <EmptyDataTemplate>
			<span style="  font-size:12px; text-align:center;" >暂无记录</span> 
		</EmptyDataTemplate>
        </asp:GridView>
    </div>
    </form>

