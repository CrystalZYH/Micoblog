<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeiBoManage.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.WeiBoManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="weiboId" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="weiboId" HeaderText="weiboId" InsertVisible="False" 
                    ReadOnly="True" SortExpression="weiboId" />
                <asp:BoundField DataField="authorId" HeaderText="authorId" 
                    SortExpression="authorId" />
                <asp:BoundField DataField="authorName" HeaderText="authorName" 
                    SortExpression="authorName" />
                <asp:BoundField DataField="content" HeaderText="content" 
                    SortExpression="content">
                <ItemStyle Width="500px" />
                </asp:BoundField>
                <asp:BoundField DataField="isOriginal" HeaderText="isOriginal" 
                    SortExpression="isOriginal" />
                <asp:BoundField DataField="orAuthorId" HeaderText="orAuthorId" 
                    SortExpression="orAuthorId" />
                <asp:BoundField DataField="orContent" HeaderText="orContent" 
                    SortExpression="orContent" />
                <asp:BoundField DataField="orAuthorName" HeaderText="orAuthorName" 
                    SortExpression="orAuthorName" />
                <asp:BoundField DataField="orTime" HeaderText="orTime" 
                    SortExpression="orTime" />
                <asp:BoundField DataField="createTime" HeaderText="createTime" 
                    SortExpression="createTime" />
                <asp:BoundField DataField="zanNumber" HeaderText="zanNumber" 
                    SortExpression="zanNumber" />
                <asp:BoundField DataField="reviewNumber" HeaderText="reviewNumber" 
                    SortExpression="reviewNumber" />
                <asp:BoundField DataField="transmitNumber" HeaderText="transmitNumber" 
                    SortExpression="transmitNumber" />
                <asp:BoundField DataField="favsNumber" HeaderText="favsNumber" 
                    SortExpression="favsNumber" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_hytcweiboConnectionString %>" 
            SelectCommand="SELECT * FROM [t_WeiBo]" 
            DeleteCommand="DELETE FROM [t_WeiBo] WHERE [weiboId] = @weiboId" 
            InsertCommand="INSERT INTO [t_WeiBo] ([authorId], [authorName], [content], [isOriginal], [orAuthorId], [orContent], [orAuthorName], [orTime], [createTime], [zanNumber], [reviewNumber], [transmitNumber], [favsNumber]) VALUES (@authorId, @authorName, @content, @isOriginal, @orAuthorId, @orContent, @orAuthorName, @orTime, @createTime, @zanNumber, @reviewNumber, @transmitNumber, @favsNumber)" 
            UpdateCommand="UPDATE [t_WeiBo] SET [authorId] = @authorId, [authorName] = @authorName, [content] = @content, [isOriginal] = @isOriginal, [orAuthorId] = @orAuthorId, [orContent] = @orContent, [orAuthorName] = @orAuthorName, [orTime] = @orTime, [createTime] = @createTime, [zanNumber] = @zanNumber, [reviewNumber] = @reviewNumber, [transmitNumber] = @transmitNumber, [favsNumber] = @favsNumber WHERE [weiboId] = @weiboId">
            <DeleteParameters>
                <asp:Parameter Name="weiboId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="authorId" Type="Int32" />
                <asp:Parameter Name="authorName" Type="String" />
                <asp:Parameter Name="content" Type="String" />
                <asp:Parameter Name="isOriginal" Type="String" />
                <asp:Parameter Name="orAuthorId" Type="Int32" />
                <asp:Parameter Name="orContent" Type="String" />
                <asp:Parameter Name="orAuthorName" Type="String" />
                <asp:Parameter Name="orTime" Type="DateTime" />
                <asp:Parameter Name="createTime" Type="DateTime" />
                <asp:Parameter Name="zanNumber" Type="Int32" />
                <asp:Parameter Name="reviewNumber" Type="Int32" />
                <asp:Parameter Name="transmitNumber" Type="Int32" />
                <asp:Parameter Name="favsNumber" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="authorId" Type="Int32" />
                <asp:Parameter Name="authorName" Type="String" />
                <asp:Parameter Name="content" Type="String" />
                <asp:Parameter Name="isOriginal" Type="String" />
                <asp:Parameter Name="orAuthorId" Type="Int32" />
                <asp:Parameter Name="orContent" Type="String" />
                <asp:Parameter Name="orAuthorName" Type="String" />
                <asp:Parameter Name="orTime" Type="DateTime" />
                <asp:Parameter Name="createTime" Type="DateTime" />
                <asp:Parameter Name="zanNumber" Type="Int32" />
                <asp:Parameter Name="reviewNumber" Type="Int32" />
                <asp:Parameter Name="transmitNumber" Type="Int32" />
                <asp:Parameter Name="favsNumber" Type="Int32" />
                <asp:Parameter Name="weiboId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
