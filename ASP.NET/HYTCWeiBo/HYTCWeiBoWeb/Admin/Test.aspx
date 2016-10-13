<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="HYTCWeiBoWeb.Admin.Test" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2">
            <Series>
                <asp:Series Name="Series1" ChartType="Pie" YValuesPerPoint="4" 
                    XValueMember="content" YValueMembers="weiboId">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1" Area3DStyle-Enable3D="True" ShadowColor="#CCCCFF" Area3DStyle-LightStyle="Realistic">

<Area3DStyle Enable3D="True" LightStyle="Realistic"></Area3DStyle>

                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </div>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataSourceID="SqlDataSource2" Height="50px" 
        Width="125px" AllowPaging="True">
    </asp:DetailsView>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2">
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:db_hytcweiboConnectionString %>" 
        SelectCommand="SELECT * FROM [t_WeiBo]"></asp:SqlDataSource>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="weiboId" 
        DataSourceID="SqlDataSource2" GroupItemCount="3">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color: #FAFAD2;color: #284775;">
                weiboId:
                <asp:Label ID="weiboIdLabel" runat="server" Text='<%# Eval("weiboId") %>' />
                <br />
                authorName:
                <asp:Label ID="authorNameLabel" runat="server" 
                    Text='<%# Eval("authorName") %>' />
                <br />
                content:
                <asp:Label ID="contentLabel" runat="server" Text='<%# Eval("content") %>' />
                <br />
                createTime:
                <asp:Label ID="createTimeLabel" runat="server" 
                    Text='<%# Eval("createTime") %>' />
                <br />
            </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color: #FFCC66;color: #000080;">
                weiboId:
                <asp:Label ID="weiboIdLabel1" runat="server" Text='<%# Eval("weiboId") %>' />
                <br />
                authorName:
                <asp:TextBox ID="authorNameTextBox" runat="server" 
                    Text='<%# Bind("authorName") %>' />
                <br />
                content:
                <asp:TextBox ID="contentTextBox" runat="server" Text='<%# Bind("content") %>' />
                <br />
                createTime:
                <asp:TextBox ID="createTimeTextBox" runat="server" 
                    Text='<%# Bind("createTime") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                <br />
            </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" 
                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>
                        未返回数据。</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr ID="itemPlaceholderContainer" runat="server">
                <td ID="itemPlaceholder" runat="server">
                </td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">
                weiboId:
                <asp:TextBox ID="weiboIdTextBox" runat="server" Text='<%# Bind("weiboId") %>' />
                <br />
                authorName:
                <asp:TextBox ID="authorNameTextBox" runat="server" 
                    Text='<%# Bind("authorName") %>' />
                <br />
                content:
                <asp:TextBox ID="contentTextBox" runat="server" Text='<%# Bind("content") %>' />
                <br />
                createTime:
                <asp:TextBox ID="createTimeTextBox" runat="server" 
                    Text='<%# Bind("createTime") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                <br />
            </td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #FFFBD6;color: #333333;">
                weiboId:
                <asp:Label ID="weiboIdLabel" runat="server" Text='<%# Eval("weiboId") %>' />
                <br />
                authorName:
                <asp:Label ID="authorNameLabel" runat="server" 
                    Text='<%# Eval("authorName") %>' />
                <br />
                content:
                <asp:Label ID="contentLabel" runat="server" Text='<%# Eval("content") %>' />
                <br />
                createTime:
                <asp:Label ID="createTimeLabel" runat="server" 
                    Text='<%# Eval("createTime") %>' />
                <br />
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="groupPlaceholderContainer" runat="server" border="1" 
                            style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr ID="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" 
                        style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                    ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" 
                style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                weiboId:
                <asp:Label ID="weiboIdLabel" runat="server" Text='<%# Eval("weiboId") %>' />
                <br />
                authorName:
                <asp:Label ID="authorNameLabel" runat="server" 
                    Text='<%# Eval("authorName") %>' />
                <br />
                content:
                <asp:Label ID="contentLabel" runat="server" Text='<%# Eval("content") %>' />
                <br />
                createTime:
                <asp:Label ID="createTimeLabel" runat="server" 
                    Text='<%# Eval("createTime") %>' />
                <br />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:db_hytcweiboConnectionString %>" 
        SelectCommand="SELECT [weiboId], [authorName], [content], [createTime] FROM [t_WeiBo]">
    </asp:SqlDataSource>
    </form>
</body>
</html>
