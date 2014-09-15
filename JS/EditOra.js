

    var editingKeys = {
        '8': 'backspace',
        '46': 'canc',
        '37': 'leftarrow',
        '39': 'rightarrow',
        '9': 'tab'
    };

    $('#$VWGHour$').unbind('keydown');
    $('#$VWGHour$').bind('keydown', function (e) {
        if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (length == 2 && !(e.keyCode in editingKeys)) {
                    $("#$VWGMinute$").focus();
                }
                return true;
            }
        }
        else
            return false;
    });

    $('#$VWGMinute$').unbind('keydown');
    $('#$VWGMinute$').bind('keydown', function (e) {
        if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (e.keyCode == 8 && length == 0) {
                    $("#$VWGHour$").focus();
                }
            }
        }
        else
            return false;
    });

    $('#$VWGHour$').unbind('focusin');
    $('#$VWGHour$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$VWGHour$').unbind('focusout');
    $('#$VWGHour$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
    });

    $('#$VWGMinute$').unbind('focusin');
    $('#$VWGMinute$').bind('focusin', function () {
        var text = $(this).val();
        if ( text == "$mask$")
            $(this).val("");
    });

    $('#$VWGMinute$').unbind('focusout');
    $('#$VWGMinute$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
    });


