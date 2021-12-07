<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addfg.aspx.cs" Inherits="addfg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width=760>
            <tr>
                <td colspan="3" style="height: 47px" >
                    添加法规：</td>
            </tr>
             <tr>
                <td  align=right style="width: 9574px">
                 名称</td>
                <td style="width: 253px; height: 29px" align=left> <asp:TextBox ID="TextBox1" runat="server" Width="406px"></asp:TextBox>
                    </td>
                <td style="width: 27px; height: 29px"><FONT color="#ff0000"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                    ErrorMessage="名称不允许为空"></asp:RequiredFieldValidator></FONT >
                    </td>
            </tr>
          
             <tr>
                <td  align=right style="width: 9574px">
                    内容</td>
                <td style="width: 253px; height: 129px" align=left>
                    <asp:TextBox ID="TextBox2" runat="server" Height="124px" TextMode="MultiLine" 
                        Width="445px"></asp:TextBox></td>
                <td style="width: 27px; height: 29px"><FONT color="#ff0000">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                                    ErrorMessage="内容不允许为空"></asp:RequiredFieldValidator></FONT ></td>
            </tr>
          
            
            <tr>
            <td style="width: 9574px"></td>
                <td colspan="2" style="height: 47px"  >
                    <asp:Button ID="Button1" runat="server" Text="　提交　" OnClick="Button1_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
