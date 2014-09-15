
$('#$VWGEditControlID$').unbind('focusin');
$('#$VWGEditControlID$').bind('focusin', function () {
        var text = $(this).val();
        if (text == ("$mask$"))
            $(this).val("");
});

$('#$VWGEditControlID$').unbind('focusout');
$('#$VWGEditControlID$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});
