var editingKeys = {
    '8': 'backspace',
    '46': 'canc',
    '37': 'leftarrow',
    '39': 'rightarrow',
    '9': 'tab'
};

$('#$vwgHourId$').unbind('keydown');
$('#$vwgHourId$').bind('keydown', function (e) {
    if ((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105) || (e.keyCode in editingKeys)) {
        var text = $(this).val();
        if (text != null) {
            var length = text.length;
            if (length == 2 && !(e.keyCode in editingKeys)) {
                $("#$vwgMinuteId$").focus();
            }
            return true;
        }
    }
    else
        return false;
});

$('#$vwgMinuteId$').unbind('keydown');
$('#$vwgMinuteId$').bind('keydown', function (e) {
    if ((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105) || (e.keyCode in editingKeys)) {
        var text = $(this).val();
        if (text != null) {
            var length = text.length;
            if (e.keyCode == 8 && length == 0) {
                $("#$vwgHourId$").focus();
            }
        }
    }
    else
        return false;
});

$('#$vwgHourId$').unbind('focusin');
$('#$vwgHourId$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");
});

$('#$vwgHourId$').unbind('focusout');
$('#$vwgHourId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});

$('#$vwgMinuteId$').unbind('focusin');
$('#$vwgMinuteId$').bind('focusin', function () {
    var text = $(this).val();
    if ( text == "$mask$")
        $(this).val("");
});

$('#$vwgMinuteId$').unbind('focusout');
$('#$vwgMinuteId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");
});


