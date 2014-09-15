var editingKeys = {
    '8': 'backspace',
    '46': 'canc',
    '37': 'leftarrow',
    '39': 'rightarrow',
    '9': 'tab'
};

$('#$VWGEditControlID$').unbind('keydown');
$('#$VWGEditControlID$').bind('keydown', function (e) {
    if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
        var text = $(this).val();
        if (text != null) {
            var length = text.length;
            if (length >11 && !(e.keyCode in editingKeys))               
                    return false;           
           else
                return true;
        }
    }
    else
        return false;
});

$('#$VWGEditControlID$').unbind('focusin');
$('#$VWGEditControlID$').bind('focusin', function () {
    var text = $(this).val();
    if ( text == "$mask$")
        $(this).val("");

});

$('#$VWGEditControlID$').unbind('focusout');
$('#$VWGEditControlID$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");

});
