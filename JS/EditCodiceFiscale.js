var editingKeys = {
    '8': 'backspace',
    '46': 'canc',
    '37': 'leftarrow',
    '39': 'rightarrow',
    '9': 'tab'
};

$('#$VWGEditControlID$').unbind('focusin');
$('#$VWGEditControlID$').bind('focusin', function () {
    var text = $(this).val();
    if (text == "$mask$")
        $(this).val("");

});

$('#$VWGEditControlID$').unbind('focusout');
$('#$VWGEditControlID$').bind('focusout', function () {
    var text = $(this).val();
    if (text == null || text == "")
        $(this).val("$mask$");

});