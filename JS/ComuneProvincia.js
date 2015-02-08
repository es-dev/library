$('#$vwgComuneId$').unbind('focusin');
$('#$vwgComuneId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgComuneId$').unbind('focusout');
$('#$vwgComuneId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});

$('#$vwgProvinciaId$').unbind('focusin');
$('#$vwgProvinciaId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgProvinciaId$').unbind('focusout');
$('#$vwgProvinciaId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});