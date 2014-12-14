$('#$vwgId$').unbind('focusin');
$('#$vwgId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgId$').unbind('focusout');
$('#$vwgId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});



