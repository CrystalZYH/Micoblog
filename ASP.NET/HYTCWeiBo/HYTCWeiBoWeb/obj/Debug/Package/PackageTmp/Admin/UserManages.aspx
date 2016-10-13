<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManages.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.UserManages" %>

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
            DataKeyNames="userId" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="userId" HeaderText="用户Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="userId" />
                <asp:BoundField DataField="userName" HeaderText="用户名" 
                    SortExpression="userName" />
                <asp:BoundField DataField="pwd" HeaderText="密码" SortExpression="pwd" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="sex" HeaderText="性别" SortExpression="sex" />
                <asp:BoundField DataField="colloge" HeaderText="学院" SortExpression="colloge" />
                <asp:BoundField DataField="inCollogeYear" HeaderText="入学年份" 
                    SortExpression="inCollogeYear" />
                <asp:BoundField DataField="realName" HeaderText="真实姓名" 
                    SortExpression="realName" />
                <asp:BoundField DataField="home" HeaderText="籍贯" SortExpression="home" />
                <asp:BoundField DataField="birthday" HeaderText="出生日期" 
                    SortExpression="birthday" />
                <asp:BoundField DataField="boodtype" HeaderText="血型" 
                    SortExpression="boodtype" />
                <asp:BoundField DataField="personalwords" HeaderText="个性签名" 
                    SortExpression="personalwords" />
                <asp:BoundField DataField="registerTime" HeaderText="注册时间" 
                    SortExpression="registerTime" />
                <asp:BoundField DataField="phone" HeaderText="电话号码" SortExpression="phone" />
                <asp:BoundField DataField="QQ" HeaderText="QQ" SortExpression="QQ" />
                <asp:BoundField DataField="MSN" HeaderText="MSN" SortExpression="MSN" />
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
            SelectCommand="SELECT * FROM [t_User]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
