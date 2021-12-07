<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="addUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <br/><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="text-align:left; color:Red; font-size:36px">添加操作员<asp:Label
            ID="Label9" runat="server" Visible="False"></asp:Label></span><br/><br/><br/>
<table style=" text-align:center;width:585px;"> 
<tr>
<td style="width: 36%; height: 21px; text-align: right">
    <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label></td>
<td style="width: 80%; height: 21px; text-align: left">
    <asp:TextBox ID="TextBox1" runat="server" Width="104px"></asp:TextBox><span  style=" color:red">*</span>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
        ErrorMessage="不能为空！"></asp:RequiredFieldValidator></td>
</tr>
    <tr>
        <td style="width: 36%; height: 21px; text-align: right">
            <asp:Label ID="Label2" runat="server" Text="密　码："></asp:Label></td>
        <td style="width: 80%; height: 21px; text-align: left">
            <asp:TextBox ID="TextBox2" runat="server" Width="104px" MaxLength="16" TextMode="Password"></asp:TextBox><span  style=" color:red">*</span>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="6-16位字母数字下划线！" ValidationExpression="^(\w){6,16}$"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td colspan="2" style="   height: 21px; text-align: center">
            <div style="margin-right:100px;"><asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" /></div></td>
        <td style="width: 80%; height: 21px; text-align: left">
        </td>
    </tr>
   
</table>
    </div>
    </form>
</body>
</html>
