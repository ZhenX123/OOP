<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu1.aspx.cs" Inherits="menu1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <LINK href="Style.css" type="text/css" rel="stylesheet">
     <style rel='stylesheet'>
       div	{
			width:			100%;
			text-align:		left;
			line-height:	18px;
			padding:		1px;
			overflow:		hidden;
		}
		ul	{
			width:			90%;
			text-align:		left;
			line-height:	20px;
			padding:		4px 6px;
			margin:			0px;
			display:		block !important;
			display:		inline;
		}
		li	{
			display:		block !important;
			font-family:	宋体;
			font-size:		12px;
		}
        </style>
        <script language='javascript'>
		function over(obj)
		{
			obj.style.color = '#ff6600';
			obj.style.backgroundColor = '#f7f7f7';
		}
		function out(obj)
		{
			obj.style.color = '';
			obj.style.backgroundColor = '';
		}
		function shift(id)
		{
			var obj = document.getElementById(id);
			if (obj.style.display == 'none')
			{
				obj.style.display = 'inline';
			}
			else
			{
				obj.style.display = 'none';
			}
		}
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('system')">系统用户管理</div>
            <ul id='system'>
                <li>
                    <a href="ManageUser.aspx" target="mainFrame">用户管理</a> </li>
                <li>
                    <a href="addUser.aspx" target="mainFrame">添加用户</a></li>
                
            </ul>
        </div>
        <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('board')">会员管理</div>
            <ul id='board' style='display:none'>
                <li>
                    <a href="Managehy.aspx" target="mainFrame">会员管理</a></li>
                   
                 
            </ul>
        </div>
        <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('yuangong')">行业新闻管理</div>
            <ul id='yuangong' style='display:none'>
                <li>
                    <a href="Managexw.aspx" target="mainFrame">新闻管理</a></li>
                 <li>
                    <a href="addxw.aspx" target="mainFrame">添加新闻</a></li>
                 
            </ul>
        </div>
        <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('shenbao')">行业法规管理</div>
            <ul id='shenbao' style='display:none'>
                <li>
                    <a href="Managefg.aspx" target="mainFrame">法规管理</a></li>
                     <li>
                    <a href="addfg.aspx" target="mainFrame">添加法规</a></li>
                
            </ul>
        </div>
      <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('renwu')">房源信息管理</div>
            <ul id='renwu' style='display:none'>
                <li>
                    <a href="Managesh.aspx" target="mainFrame">房源审核</a></li>
                     <li>
                    <a href="dosh.aspx" target="mainFrame">已审核的房源</a></li>
                 <li>
                    <a href="searchfy.aspx" target="mainFrame">查询房源</a></li> 
            </ul>
        </div>
         <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('guanxi')">留言信息管理</div>
            <ul id='guanxi' style='display:none'>
                <li>
                    <a href="guest.aspx" target="_blank">留言管理</a></li>
                  
            </ul>
        </div>
        <br />
        <div class='grid'>
            <div class='category cursor' onmouseover='over(this)' onmouseout='out(this)' onclick="shift('order')">系统管理</div>
            <ul id='order'>
                
				   <li>
                   <a href="outlogin.aspx" target="_top">退出系统</a></li>
                
            </ul>
        </div>
        <br />
        <br>
        <div align='left'>
            <font  style='font-size:11px;font-family:Tahoma'><b>Copyright&copy;</b></font><br />
            <font class='t1'>房产中介网站管理系统</font>
        </div>
    </div>
    </form>
</body>
</html>
