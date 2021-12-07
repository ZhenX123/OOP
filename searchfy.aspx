<%@ Page Language="C#" AutoEventWireup="true" CodeFile="searchfy.aspx.cs" Inherits="searchfy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="700" align="center">
                        <tr>
                            <td style="width: 2078px; height: 21px">
                                <asp:Label ID="Label1" runat="server" Text="查询条件" Font-Size="9pt"></asp:Label></td>
                            <td style="width: 120px; height: 21px">
                                <asp:DropDownList ID="ddlAdminName" runat="server" Width="107px" Font-Size="9pt">
                                    <asp:ListItem Value="lx">类型</asp:ListItem>
                                    <asp:ListItem Value="zj">总价</asp:ListItem>
                                    <asp:ListItem Value="dj">单价</asp:ListItem>
                                    <asp:ListItem Value="xq">小区</asp:ListItem>
                                     <asp:ListItem Value="fx">房型</asp:ListItem>
                                      <asp:ListItem Value="mj">面积</asp:ListItem>
                                      <asp:ListItem Value="lc">楼层</asp:ListItem>
                                      <asp:ListItem Value="nd">年代</asp:ListItem>
                                      <asp:ListItem Value="cx">朝向</asp:ListItem>
                                      <asp:ListItem Value="addtime">日期</asp:ListItem>
                                </asp:DropDownList></td>
                            <td style="width: 1080px; height: 21px">
                                <asp:Label ID="Label2" runat="server" Text="关键字" Font-Size="9pt"></asp:Label></td>
                            <td style="width: 260px; height: 21px">
                                <asp:TextBox ID="txtSelect" runat="server" Width="100px" Font-Size="9pt"></asp:TextBox></td>
                            <td style="width: 279px; height: 21px">
                                <asp:Button ID="btnSelect" runat="server" Text="查询" OnClick="Button1_Click" 
                                    Font-Size="9pt" Height="28px" Width="69px" /></td>
                           
                        </tr>
                    </table>
                    <br />
                    <asp:GridView ID="gvAdminInfo" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#507CD1" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="#333333"
                        GridLines="Horizontal" Width="700px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5"  Font-Size="9pt" OnRowDataBound="GridView1_RowDataBound" HorizontalAlign="Center" OnSelectedIndexChanged="gvAdminInfo_SelectedIndexChanged">
                        <FooterStyle BackColor="#efefef" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" >
                            </asp:BoundField>
                            <asp:BoundField DataField="lx" HeaderText="类型" />
                            <asp:BoundField DataField="zj" HeaderText="总价" />
                            <asp:BoundField DataField="dj" HeaderText="单价" />
                            <asp:BoundField DataField="xq" HeaderText="小区" />
                            <asp:BoundField DataField="fx" HeaderText="房型" />
                            <asp:BoundField DataField="mj" HeaderText="面积" />
                            <asp:BoundField DataField="lc" HeaderText="楼层" />
                              <asp:BoundField DataField="addtime" HeaderText="日期" />
                                    
                        </Columns>
                        <SelectedRowStyle BackColor="#efefef" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
    </div>
    </form>
</body>
</html>
