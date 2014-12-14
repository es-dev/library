var editingKeys = {
    '8': 'backspace',
    '46': 'canc',
    '37': 'leftarrow',
    '39': 'rightarrow',
    '9': 'tab',
    '188': 'comma',
    '190': 'period'
};

$('#$vwgId$').unbind('keydown');
$('#$vwgId$').bind('keydown', function (e) {
    if (((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105)) || (e.keyCode in editingKeys)) {
        return true;
    }
    else
        return false;
});

$('#$vwgId$').unbind('focusin');
$('#$vwgId$').bind('focusin', function () {
    var text = $(this).val();
    if ( text == "$mask$")
        $(this).val("");

});

$('#$vwgId$').unbind('focusout');
$('#$vwgId$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");

});
