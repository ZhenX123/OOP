function doSearch(o) {
    window.location.href = doSearchUrl(o);
}
function doSearchSubmit(o) {
    doSearch(o);
}
function jumpTo(p) {
    var intReg = new RegExp("^(\\d)+$");
    if (intReg.exec(p) == null) { alert("请输入正确的页数."); return false; }
    doSearchSubmit({ 'p': p });
}
function btnDoSearch(min, max, k) {
    var checkK = true;
    var checkP = true;
    var doFun = function () { doSearchSubmit({ 'p': 1, 'minprice': min, 'maxprice': max, 'pr': '', 'k': k }); }
    if (k.length>0&&/\S/g.exec(k)==null) {
        checkK = false;
    }
    if (min.replace(/\s/g, '').length > 0 || max.replace(/\s/g, '').length > 0) {
        if (!checkMinMaxValue(min, max) || parseFloat(min) > 550000 || parseFloat(max) > 550000) {
            checkP = false;
        }
    }
    
    if (checkK && checkP) {
        doFun();
    }
    else {
        if (!checkP) { alert("请输入正确的价格."); }
        if (!checkK) { alert("请输入正确的关键字.");}
    }
}
function doSearchHouseType(tag) {
    doSearchSubmit({ 'ht': tag, 'p': 1 });
}
function doSearchK(tag) {
    doSearchSubmit({ 'k': tag, 'p': 1 });
}
function doSearchTag(tag)
{
    doSearchSubmit({ 'tag': tag, 'p': 1 });
}
function doSearchPrice(pr) {
    doSearchSubmit({ 'pr': pr, 'p': 1, 'minprice': '', 'maxprice': '' });
}
function doSearchSize(ar) {
    doSearchSubmit({ 'ar': ar, 'p': 1, 'minsize': '', 'maxsize': '' });
}
function doSearchScp(scp) {
    doSearchSubmit({ 'scp': scp, 'gscp': '', 'sub': '', 'subst': '', 'p': 1, 'tag': '' });
}
function doSearchGscp(gscp) {
    doSearchSubmit({ 'gscp': gscp, 'sub': '', 'subst': '', 'p': 1, 'tag': '' });
}
function doSearchSubWay(sub) {
    doSearchSubmit({ 'sub': sub, 'subst': '', 'p': 1 });
}
function doSearchSubStation(subst) {
    doSearchSubmit({ 'subst': subst, 'p': 1 });
}
function doSearchBedRoom(bc) {
    doSearchSubmit({ 'bc': bc, 'p': 1, 'minbd': '', 'maxbd': '' });
}
function checkMinMaxValue(min, max) {
    var check = true;
    var intReg = new RegExp("^[0-9]*[1-9]+[0-9]*$");
    if (intReg.exec(min) == null || intReg.exec(max) == null) { check = false; }
    if (check) {
        if((parseInt(max) < parseInt(min)) && parseInt(max) > 0){check=false;}
    }
    return check;
}
function btnDoSearchBedRoom(min, max) {        
    if (!checkMinMaxValue(min, max) || parseFloat(min) > 99 || parseFloat(max) > 99) {
        alert("请输入正确的户型.");
    }
    else {
        doSearchSubmit({ 'p': 1, 'minbd': min, 'maxbd': max, 'bc': '' });
    }
}
function btnDoSearchPrice(min, max) {
    if (!checkMinMaxValue(min, max) || parseFloat(min) > 550000 || parseFloat(max) > 550000) {
        alert("请输入正确的价格.");
    }
    else {
        doSearchSubmit({ 'p': 1, 'minprice': min, 'maxprice': max ,'pr':''});
    }
}
function btnDoSearchSize(min, max) {
    if (!checkMinMaxValue(min, max) || parseFloat(min) > 99999 || parseFloat(max) > 99999) {
        alert("请输入正确的面积.");
    }
    else {
        doSearchSubmit({ 'p': 1, 'minsize': min, 'maxsize': max, 'ar': '' });
    }
}
function doSelectListStyle(css) {
    doSearch({ 'ListStyle': css });
}
