<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>房产中介网站</title>

<link rel="stylesheet" type="text/css" href="Css/common.css" />
<link rel="stylesheet" type="text/css" href="Css/sidebar.css" />
<link rel="stylesheet" type="text/css" href="Css/searchlist.css" />
<script src="Js/jquery-1.7.1.min.js"></script>
<script src="Js/CommonDoSearch.js"></script>
<script> 
    function doSearchUrl(o) {
        var url = [];
        if ((o.scp=(o.scp == null ? "" : o.scp)) != "") { url.push("scp=" + o.scp); }
        if ((o.gscp = (o.gscp == null ? "" : o.gscp)) != "") { url.push("gscp=" + o.gscp); }
        if ((o.pr = (o.pr == null ? "" : o.pr)) != "") { url.push("pr=" + o.pr); }
        if ((o.ar = (o.ar == null ? "" : o.ar) )!= "") { url.push("ar=" + o.ar); }
        if ((o.bc = (o.bc == null ? "" : o.bc)) != "") { url.push("bc=" + o.bc); }
        if ((o.order = (o.order == null ? "" : o.order)) != "" ) { url.push("order=" + o.order); }
        if ((o.sub = (o.sub == null ? "" : o.sub)) != "") { url.push("sub=" + o.sub); }
        if ((o.subst = (o.subst == null ? "" : o.subst)) != "") { url.push("subst=" + encodeURIComponent(o.subst)); }        
        if ((o.ListStyle = (o.ListStyle == null ? "1" : o.ListStyle))!= "") { url.push("ListStyle=" + o.ListStyle); }
        if ((o.tag = (o.tag == null ? "" : o.tag)) != "") { url.push("tag=" + encodeURIComponent(o.tag)); }
        if ((o.k = (o.k == null ? "" : o.k)) != "") { url.push("k=" + encodeURIComponent(o.k)); }
        if ((o.p = (o.p == null ? "1" : o.p)) != "") { url.push("p=" + o.p); }
 
        if ((o.ht = (o.ht == null ? "" : o.ht)) != "") { url.push("ht=" + o.ht); }
        
        if ((o.minprice = (o.minprice == null ? $("#txt_minprice").val() : o.minprice)) != "") { url.push("minprice=" + o.minprice); }
        if ((o.maxprice = (o.maxprice == null ? $("#txt_maxprice").val() : o.maxprice)) != "") { url.push("maxprice=" + o.maxprice); }
 
        if ((o.minbd = (o.minbd == null ? $("#txt_minbd").val() : o.minbd)) != "") { url.push("minbd=" + o.minbd); }
        if ((o.maxbd = (o.maxbd == null ? $("#txt_maxbd").val() : o.maxbd)) != "") { url.push("maxbd=" + o.maxbd); }
 
        if ((o.minsize = (o.minsize == null ? $("#txt_minsize").val() : o.minsize)) != "") { url.push("minsize=" + o.minsize); }
        if ((o.maxsize = (o.maxsize == null ? $("#txt_maxsize").val() : o.maxsize)) != "") { url.push("maxsize=" + o.maxsize); }
 
        return "?"+url.join("&");
    }    
</script>
</head>
 
<body>
 
    <form id="form1" runat="server">
 
<div class="header">
 
<!--<div class="loginbar">
    <div class="pagewidth960">
    <div class="loginbar_login"> 账号
        <input class="TEXT width110" name="" type="text" />
        密码
        <input class="TEXT width110" name="" type="text" />
        <input class="BTN" name="" type="button" value="登录" />
        <input class="BTN" name="" type="button" value="注册" />
    </div>
    <div class="loginbar_seach">
        <ul>
        <li class="weibo"><a href="#">官方微博</a></li>
        <li><a href="#">会员中心</a></li>
        <li><a href="#">网站导航</a></li>
        <li><a href="#">收藏夹</a></li>
        </ul>
    </div>
    </div>
</div>-->
<style type="text/css"> 
.seachbar_text .dk_container {height:24px; border:1px solid #D90202; border-width:3px 0 3px 3px; width:74px;}
.seachbar_text .dk_toggle {width:36px; padding:4px 32px 6px 10px;}
.dk_options  .dk_options_inner { width:72px}
 
.Area .dk_container { height:20px;}
.Area .dk_toggle {width:25px;padding:2px 15px 2px 5px;}
.titleTab li a{color:#fff;}
</style>
<LINK href="/favicon.ico" type="image/x-icon" rel=icon>
<link rel="stylesheet" type="text/css" href="Js/dropkick.css" />
<link rel="stylesheet" type="text/css" href="Js/jquery-ui-1.8.14.custom.css" />
<script type="text/javascript" src="Js/jquery-ui-1.8.14.custom.min.js"></script> 
<script> 
    var textfieldDefaultValue1 = "请任意输入区域、楼盘名、房源特征、学校名…，拼音也可以的，试一下吧";
    var textfieldDefaultValue2 = "请输入经纪人姓名";
    function divSelecctChange(id, o) {
        $('#' + id).html($(o).html());
        $('#searchHouseType').val($(o).attr('v'));
	selectSearchHouseType($(o).attr('v'));
    }
    function selectSearchHouseType(value) {
        switch (value) {
            case "sale": //二手房 
                $("#txt_keyWord").val(textfieldDefaultValue1);
                break;
            case "rent": //租房 
                $("#txt_keyWord").val(textfieldDefaultValue1);
                break;
            case "agent": //代理人 
                $("#txt_keyWord").val(textfieldDefaultValue2);
                break;
        }
    }
    function textfieldOnblur(obj) {
        if (obj.value == "") {
            var searchHouseType = $("#searchHouseType").val();
            if (searchHouseType != "agent") { obj.value = textfieldDefaultValue1; }
            else { obj.value = textfieldDefaultValue2; }
            obj.style.color = "#aaa";
        }
    }
    function textfieldOnfocus(obj) {
        if (obj.value == textfieldDefaultValue2 || obj.value == textfieldDefaultValue1) {
            obj.value = "";
            obj.style.color = "black";
        }
    }
    function doSearchKeyWord(k,searchHouseType) {
        //var searchHouseType = $("#searchHouseType").val();
        //var k = $("#txt_keyWord").val();
        if (k == textfieldDefaultValue1 || k == textfieldDefaultValue2) {
            alert("请输入搜索关键字");
            return;
        }
        window.location.href = doSearchKeyWordUrl(k, searchHouseType);
    }
    function doSearchKeyWordUrl(k, searchHouseType) {
        var url = "";
        switch (searchHouseType) {
            case "sale": //二手房 
                url = "salesearch.aspx?k=" + encodeURIComponent(k);
                break;
            case "rent": //租房 
                url = "rentsearch.aspx?k=" + encodeURIComponent(k);
                break;
            case "agent": //代理人 
                url = "/findproperty/agents?k=" + encodeURIComponent(k);
                break;
        }
        return url;
    }
    function initSearchAutocomplete(id) {
        $("#" + id).autocomplete({
            source: function (request, response) {
		var searchTypeId = $("#searchHouseType")[0].selectedIndex;
                $.ajax({
                    url: '/findproperty/searchAutoComplete',
                    dataType: 'json',
                    data: {
                        k: $("#txt_keyWord").val(),
                        postType: "",
                        searchType:searchTypeId 
                    },
                    error: function (data, e) {  },
                    success: function (data2) {
                        if (data2 != "" && data2 != null) {
                            response($.map(data2.props, function (item) {
                                return {
                                    name: item.name,
                                    count: item.count,
                                    value: item.name
                                }
                            }));
                        }
                    }
                });
            },
            minLength: 1,
            select: function () { }
        }).data('autocomplete')._renderItem = function (ul, item) {
            return $('<li style="width: 450px;" onclick="searchTag(\'' + item.name + '\')"></li>').data('item.autocomplete', item)
                        .append('<a style="height:20px;"><span style="float:left">' + item.name + '</span><span style="float:right">(约 ' + item.count + ' 房源 )</span></a>')
                        .appendTo(ul);
        };
    }
    function searchTag(v) {
        window.open(doSearchKeyWordUrl(v, $("#searchHouseType").val()));
    }
    function searchTopTag(v, ob) {
        window.open("/findproperty/sale?k=" + encodeURIComponent(v));
    }
    function loadImg(callBack) {
        var imgs = $('img[src1]');
        var index = 0;
        var count = imgs.size();
        if (count > 0) {
            var loadImgAct = function () {
                var url = $(imgs[index]).attr("src1");
                $(imgs[index]).attr("src", url);
                setTimeout(function () { if (++index < count) { loadImgAct(); } else { if (callBack) { callBack();} } }, 10);
            }
            loadImgAct();
        }
    }
    function lazyloadImg(p) {
        var defaults = {
            container: $(window)
        },
		p = $.extend(defaults, p);
        var imgs = $("img[src1]");
        var count = imgs.size();
        var loadFun = function (imgs, top) {
            $(imgs).each(function (i) {
                var img = $(this); 
                if (img.offset().top + 10 <= top) {
                    setTimeout(function () {
                        var url = img.attr("src1");
                        if (url != null) {
                            img.attr("src", url);
                            img.removeAttr("src1");
                        }
                    }, 50);
                }
            });
        }
        var loagAgent=function(){
            loadFun(imgs, $(p.container).scrollTop() + $(p.container).height());
        }
        if (count > 0) {
            p.container.bind("scroll", loagAgent);
            p.container.bind("resize",loagAgent);
            p.container.trigger("scroll");
        }
    }
    $(document).ready(function () {
        initSearchAutocomplete("txt_keyWord");
        setTag(1);
        setSearchType(0);
        enterKey();
    });
    function enterKey() {
        $('#txt_keyWord').bind('keydown', function (e) {
            var key = e.which;
            if (key == 13) {
                var k = $('#txt_keyWord').val(); 
                if (k == textfieldDefaultValue1 || k == textfieldDefaultValue2) {
                    return;
                }
                searchTag(k);
            }
        });
    }
    function setTag(tagIndex) {
        var tags = $(".titleTab").find("li");
        if (tagIndex < tags.size()) {
            var li = $(tags[tagIndex]);
            li.attr("class", "current");
            li.find("a").removeAttr("style").attr("href", "javascript:void(0)").removeAttr("target");
        }
    }
    function setSearchType(t) {
        var op = $("#searchHouseType option").eq(t);
        op.attr("selected", "selected");
        $("#dk_label").html(op.html());
    }
</script>
</head>
<body>
    <div class="seachbar">
    <div class="pagewidth960">
    <ul>
        <li class="seachbar_logo">
        <p class="logo"><a href="/"></a></p>
        <div class="Area"> 
 
            
 
        </div>
        </li>
        <li class="seachbar_text">
        <div class="searchKeyWord">
            <div id="dk_container_searchHouseType" class="dk_container dk_theme_default" tabindex="" style="display: block;"  onclick="$('#dk_container_searchHouseType').attr('class',($('#dk_container_searchHouseType').attr('class')=='dk_container dk_theme_default'?'dk_container dk_theme_default dk_open':'dk_container dk_theme_default'))">
                <a class="dk_toggle">
                    <span class="dk_label" id="dk_label">二手房</span>
                </a>
                <div class="dk_options" style="top: 23px;" id="dk_options">
                    <ul class="dk_options_inner">
                        <li>
                        <a v="sale" onclick="divSelecctChange('dk_label',this)">二手房</a>
                        </li>
                        <li class="">
                        <a v="rent" onclick="divSelecctChange('dk_label',this)">租房</a>
                        </li>
                        
                    </ul>
                </div>
            </div>
 
            <select name="" class="Searchoptions" id="searchHouseType" onchange="selectSearchHouseType(this.value)" style="display:none;">
                <option value="sale">二手房</option>
	            <option value="rent">租房</option>
	            
            </select>
            <input class="Searchbox" name="" id="txt_keyWord" type="text" value="请任意输入区域、楼盘名、房源特征、学校名…，拼音也可以的，试一下吧" onblur="textfieldOnblur(this)" onfocus="textfieldOnfocus(this)"/>
            <i></i>
        </div>
        
        </li>
        <li class="SearchButton">
        <input name="" type="button" value="" onclick="doSearchKeyWord($('#txt_keyWord').val(),$('#searchHouseType').val())"/>
        </li>
        <li class="SearchClass">
        
        </li>
    </ul>
    </div>
</div>
<div class="navbar">
    <div class="left"></div>
    <div class="pagewidth960">
    <ul class="titleTab">
    <li><a target="_blank" title="首页" href="index.aspx"> </a></li>
    <li><a target="_blank" href="login.aspx" title="会员登录"> </a></li>
        <li><a target="_blank" title="首页" href="index.aspx">首页 </a></li>
          <li><a target="_blank" href="login.aspx" title="会员登录">会员登录</a></li>
        <li><a target="_blank" title="注册会员" href="reg.aspx">注册会员</a></li>
        <li><a target="_blank" title="二手房" href="sale.aspx">二手房</a><em><img width="34" height="17" src="images/icon_new.gif"></em></li>
        <li><a target="_blank" title="出租房" href="rent.aspx">租房</a></li>
        
        <li><a target="_blank" title="行业新闻" href="News.aspx">行业新闻</a></li>
        <li><a target="_blank" title="行业法规" href="fagui.aspx">行业法规</a></li>
        <li><a target="_blank" href="mycenter.aspx" title="用户中心">用户中心</a></li>
        
        <li><a target="_blank" title="留言反馈" href="guest.aspx">留言反馈</a></li>
       
      
    </ul>
    </div>
    <div class="right"></div>
</div>
</div>
<div class="content pagewidth960">
    
<script> 
    function showSearchRecommendTags(o, link) {
        var dis = $(o).css("display");
        if (dis == "none") {
            $(o).css("display", "");
            $(link).find("img").attr("src", "images/btn_up.gif");
    }
    else {
        $(o).css("display", "none");
        $(link).find("img").attr("src", "images/btn_down.gif");
    }
}
</script>
<div class="crumbs">
    <span>您当前位置：<a href="index.aspx">首页</a> &gt; <a href="">留言反馈</a></span>
       
</div>

<script> 
    $(document).ready(function () {
        $("#SearchRecommendTags").css("display",(0>0?"":"none"));
    });
</script> 

 
   
 <div class="left710 blockIndex">
      
        
       
      </div>

  
  
        <div class="cellDescript" id="houseDescript">
           
            <div class="descript">
            
            
            
   <table border="0" cellpadding="0" cellspacing="0" style="width: 700px; position: relative;
            text-align: center">
            
            <tr>
                <td style="height: 476px">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; position: relative;
                        height: 94%; border-right: activeborder 1px solid; border-top: activeborder 1px solid; left: 0px; border-left: activeborder 1px solid; border-bottom: activeborder 1px solid; top: 0px;">
                        <tr>
                            <td colspan="2" style="font-weight: bold; color: red; height: 32px" align="left">
                                &nbsp;&nbsp;发表新留言</td>
                        </tr>
                        <tr>
                            <td style="width: 111px; text-align: right; height: 29px;">
                                &nbsp;用户名：</td>
                            <td style="text-align: left; height: 29px;">
                                <asp:TextBox ID="txtUserName" runat="server" Style="position: relative"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; text-align: right; height: 29px;">
                                个人主页：</td>
                            <td style="text-align: left; height: 29px;">
                                <asp:TextBox ID="txtUrl" runat="server" Style="position: relative"></asp:TextBox>
                                (如有自己的网站，请填写网站的网址,格式：http://www.xxx.com)</td>
                        </tr>
                        <tr>
                            <td style="width: 111px; text-align: right">
                                性别：</td>
                            <td style="text-align: left" height="29">
                                <asp:RadioButton ID="rbtnNv" runat="server"
                                    Checked="True" GroupName="sex" Style="position: relative" Text="女" />
                                <asp:RadioButton ID="rbtnNan" runat="server"
                                    GroupName="sex" Style="position: relative" Text="男" /></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; text-align: right; height: 29px;">
                                Email：</td>
                            <td style="text-align: left; height: 29px;">
                                <asp:TextBox ID="txtEmail" runat="server" Style="position: relative"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; height: 15px; text-align: right">
                                QQ：</td>
                            <td style="text-align: left" height="29">
                                <asp:TextBox ID="txtQq" runat="server" Style="position: relative"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; height: 110px; text-align: right">
                                头像：</td>
                            <td style="height: 110px; text-align: left" valign="middle">
                                <asp:DropDownList ID="ddlPic" runat="server" Style="position: relative; top: 0px;" AutoPostBack="True" OnSelectedIndexChanged="ddlPic_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Image ID="Image1" runat="server" Style="position: relative; left: 0px;" /></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; text-align: right" valign="top">
                                留言内容：</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtContent" runat="server" Height="140px" Style="position: relative"
                                    TextMode="MultiLine" Width="380px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 111px; height: 32px; text-align: right" valign="top">
                            </td>
                            <td style="height: 32px; text-align: left">
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                                <asp:Button ID="Button1" runat="server" Style="position: relative" Text="提交" OnClick="Button1_Click" Width="51px" />
                                &nbsp; &nbsp;
                                <asp:Button ID="Button2" runat="server" Style="position: relative" Text="清空" OnClick="Button2_Click" Width="52px" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
           
        </table>

            

            </div>
          </div>

  
  
  
  
  
  
  
  
   
    </div>   

  

  
   </div>
  
    

    
</div>
 
<div class="footer_02">
  <p></p>
    <p>房产中介网站</p>
    
</div>
    </form>
</body>
</html>
