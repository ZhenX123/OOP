<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Managefg.aspx.cs" Inherits="Managefg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="900px" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="操作ID" ReadOnly="True" />
            <asp:TemplateField HeaderText="标题">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2"  Width="50px" runat="server" Text='<%# Bind("title") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
          
            <asp:TemplateField HeaderText="日期">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Width="50px" Text='<%# Bind("addtime") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("addtime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="更新" ShowEditButton="True" />
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
        </Columns>
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
