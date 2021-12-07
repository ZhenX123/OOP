<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Managehy.aspx.cs" Inherits="Managehy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="750px" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="操作ID" ReadOnly="True" />
            <asp:TemplateField HeaderText="用户名">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2"  Width="30px" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="姓名">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3"  Width="30px" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="性别">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4"  Width="30px" runat="server" Text='<%# Bind("sex") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("sex") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="电话">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5"  Width="30px" runat="server" Text='<%# Bind("tel") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("tel") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="邮箱">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6"  Width="30px" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
          
            <asp:TemplateField HeaderText="QQ">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7"  Width="30px" runat="server" Text='<%# Bind("qq") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("qq") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="类别">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox8"  Width="30px" runat="server" Text='<%# Bind("typename") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("typename") %>'></asp:Label>
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
