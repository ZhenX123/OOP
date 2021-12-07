<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Managesh.aspx.cs" Inherits="Managesh" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" DataKeyNames="ID" Width="800px" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="lx" HeaderText="类型" />
            <asp:BoundField DataField="zj" HeaderText="总价" />
           
            <asp:BoundField HeaderText="单价" DataField="dj" />
            <asp:BoundField HeaderText="小区" DataField="xq" />
             <asp:BoundField HeaderText="房型" DataField="fx" />
              <asp:BoundField HeaderText="面积" DataField="mj" />
               <asp:BoundField HeaderText="楼层" DataField="lc" />
               <asp:BoundField HeaderText="更新日期" DataField="addtime" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="shfcxx.aspx?id={0}"
                HeaderText="审核" Text="审核" />
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <EditRowStyle BackColor="#2461BF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    </div>
    </form>
</body>
</html>
