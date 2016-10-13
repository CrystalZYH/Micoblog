<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charts.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.Charts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
        <Series>
            <asp:Series Name="Series1" XValueMember="weiboId" YValueMembers="zanNumber">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:db_hytcweiboConnectionString %>" 
        SelectCommand="SELECT * FROM [t_WeiBo]"></asp:SqlDataSource>
    <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1">
        <Series>
            <asp:Series ChartType="Doughnut" Name="Series1" XValueMember="weiboId" 
                YValueMembers="reviewNumber">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource2">
        <Series>
            <asp:Series ChartType="Pie" Name="Series1" XValueMember="sex" 
                YValueMembers="userId">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:db_hytcweiboConnectionString %>" 
        SelectCommand="SELECT * FROM [t_User]"></asp:SqlDataSource>
    </form>
</body>
</html>
