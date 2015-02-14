$('#$vwgCityId$').unbind('focusin');
$('#$vwgCityId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgCityId$').unbind('focusout');
$('#$vwgCityId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});

$('#$vwgCountyId$').unbind('focusin');
$('#$vwgCountyId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgCountyId$').unbind('focusout');
$('#$vwgCountyId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});