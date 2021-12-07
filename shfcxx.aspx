<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shfcxx.aspx.cs" Inherits="shfcxx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
    <tr>
                <td colspan="3" style="height: 47px" >
                    审核操作：</td>
            </tr>
      
                        <tr>
                            <td style="width: 307px" align="right">
                                <asp:Label ID="Label2" runat="server" Text="审核" Font-Size="9pt"></asp:Label></td>
                            <td style="width: 290px"> <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value="1">通过审核</asp:ListItem>
                                    <asp:ListItem Value="0">不通过</asp:ListItem>
                                    
                                </asp:DropDownList>
                                </td>
                            <td style="width: 298px" align="left">
                                </td>
                        </tr>
                       
                        
                        <tr>
                            <td style="width: 307px">
                            </td>
                            <td style="width: 290px;">
                                &nbsp;<asp:Button ID="Button1" runat="server" Text="提交" Width="90px" OnClick="Button1_Click" /></td>
                            <td align="left" colspan="1" rowspan="2" style="width: 298px">
                                &nbsp;</td>
                        </tr>
                        
                    </table>
    </div>
    </form>
</body>
</html>
