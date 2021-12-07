<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员登录</title>
    <link rel="stylesheet" href="images/Site_Css.css" type="text/css" />
       <script language="javascript" src="js/checkform.js"></script>
    <style type="text/css">
        .style7
        {
            width: 321px;
        }
        </style>
</head>
<body scroll="no" leftmargin="0" topmargin="0" marginheight="0" marginwidth="0">
    <table border="0" cellspacing="0" cellpadding="0" width="100%" height="100%">
        <tr>
            <td width="100%" height="50" colspan="3" style="border-bottom: 1px solid #000000">
               <table height="49" border="0" cellspacing="0" cellpadding="0" width="100%" class="font_size">
                    <tr>
                        <td valign="bottom" style="width:510px; height: 49px;" align="right">
                          <img src="images/logon.gif"style="width: 510px; height: 49px;" alt="" />                            
                        </td>
                        <td style="background-image: url(images/top-gray.gif); background-repeat: no-repeat;
                            background-position: right top; height: 49px;" valign="bottom">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
       
  <tr>
    <td height="28" background="images/Index/top-b-3-2.gif">
    <img border="0" src="images/Index/top-b-2-1-2.gif" align="left" hspace="0">     
    </td>
  </tr>

        <tr>
            <td colspan="3" >
                <table width="100%" border="0" cellspacing="0" cellpadding="0" height="100%">
                    <form id="Form2" name="login" method="post" runat="server" defaultfocus="LoginName" >
                        <tr>
                            <td >
                                 <table border="0" cellpadding="0" cellspacing="0" align="center" 
                                     style="width: 511px">
                                    <tr>
                                        <td   width="431" height="60" >
                                            管理用户登录</td>
                                    </tr>
                                   
                                    <tr>
                                        
                                        <td  valign="top">
                                            <table border="0" cellpadding="0" cellspacing="0" 
                                                style="width: 482px; margin-left: 67px;">
                                             <tr>
    <td width="40" align="right">账号：</td>
                                        <td class="style7">
                                            <asp:TextBox ID="txtid"  runat="server"  Height="22px" Width="128px"
                                                style="margin-left: 0px"  ></asp:TextBox>
                                            </td>
                                        <td  >
                 </td>
                                    </tr>
                                              <tr>
                                              <td width="40" lign="right" align="right">密码：</td>
                                              <td class="style7" >                                            
                                           <asp:TextBox ID="txtpsw" runat="server"   TextMode="Password" Width="128px"></asp:TextBox>
                                                </td>
                                              </tr>
                                               
                                                <tr>
                                                <td width="40"></td>
                                                    <td class="style7">
                                                        <asp:Button ID="btnlogin"  runat="server" Text="确定" 
                                                            OnClick="btnlogin_Click" Width="63px"  />    
                                                        <input type="reset" value="重填" class="button_bak" id="Reset1" onclick="return Reset1_onclick()" style="width: 61px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                <td width="40"></td>
                                                    <td class="style7">
                                                       
                                                    </td>
                                                </tr>
                                                <tr>
                                                <td width="40"></td>
                                                    <td class="style7">
                                                       
                                                    </td>
                                                </tr>
                                            </table>
                                            
                                            
                                           
                                        </td>
                                    </tr>
                                 
                                   
                                </table>
                            </td>
                        </tr>
                    </form>
                </table>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td colspan="3" height="20">
            <br><br><br><br>
                <table border="0" cellpadding="0" cellspacing="0" width="100%" height="20">
                    <tr>
                        <td class="down_text" align="center">
                          建议使用分辨率1024*768 CopyRight @2013 房产中介网站管理系统</td>
                    </tr>
                </table>
            </td>
        </tr>
        
    
      
        </table>                                        
        
</body>
</html>
<script language="JavaScript" type="text/javascript"><!-- 

    // The Central Randomizer 1.3 (C) 1997 by Paul Houle (houle@msc.cornell.edu) 

    // See: http://www.msc.cornell.edu/~houle/javascript/randomizer.html 

    rnd.today=new Date(); 

    rnd.seed=rnd.today.getTime(); 

    function rnd() { 

　　　　rnd.seed = (rnd.seed*9301+49297) % 233280; 

　　　　return rnd.seed/(233280.0); 

    }; 

    function rand(number) { 

　　　　return Math.ceil(rnd()*number); 

    }; 

    // end central randomizer. --> 

</script>
