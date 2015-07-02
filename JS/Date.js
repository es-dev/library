    var editingKeys = {
        '8': 'backspace',
        '46': 'canc',
        '37': 'leftarrow',
        '39': 'rightarrow',
        '9': 'tab'
    };

    $('#$vwgDayId$').unbind('keydown');
    $('#$vwgDayId$').bind('keydown', function (e) {
        if ((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105) || (e.keyCode in editingKeys)) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (length == 1 && !(e.keyCode in editingKeys)) {
                    if (text == "0" && (e.keyCode == 48 || e.keyCode == 96))
                        return false;
                }
                else if (length == 2 && !(e.keyCode in editingKeys)) {
                    $("#$vwgMonthId$").focus();
                }
                return true;
            }
        }
        else
            return false;
    });

   

    $('#$vwgMonthId$').unbind('keydown');
    $('#$vwgMonthId$').bind('keydown', function (e) {
        if ((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105) || (e.keyCode in editingKeys)) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (e.keyCode == 8 && length == 0) {
                    $("#$vwgDayId$").focus();
                }
                else {
                    if (length == 1 && !(e.keyCode in editingKeys)) {
                       if (text == "0" && (e.keyCode==48 || e.keyCode==96))
                            return false;
                    }
                    else if (length == 2 && !(e.keyCode in editingKeys)) {
                        $("#$vwgYearId$").focus();
                    }
                    return true;
                }
            }
        }
        else
            return false;
    });

    $('#$vwgYearId$').unbind('keydown');
    $('#$vwgYearId$').bind('keydown', function (e) {
        if ((e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105) || (e.keyCode in editingKeys)) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (e.keyCode == 8 && length == 0) {
                    $("#$vwgMonthId$").focus();
                }
                 else if(length == 1 && !(e.keyCode in editingKeys)) {
                    if (text == "0" && (e.keyCode == 48 || e.keyCode == 96))
                        return false;
                }
           
            }
        }
        else
            return false;
    });

    $('#$vwgDayId$').unbind('focusin');
    $('#$vwgDayId$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$vwgDayId$').unbind('focusout');
    $('#$vwgDayId$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
        else if (text != null) {            
            if (text == "00" || text == "0")
                $(this).val("01");
        }           
    });

    $('#$vwgMonthId$').unbind('focusin');
    $('#$vwgMonthId$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$vwgMonthId$').unbind('focusout');
    $('#$vwgMonthId$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
        else if (text != null) {
            if (text == "00" || text == "0")
                $(this).val("01");
        }
    });

    $('#$vwgYearId$').unbind('focusin');
    $('#$vwgYearId$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$$mask$")
            $(this).val("");
    });

    $('#$vwgYearId$').unbind('focusout');
    $('#$vwgYearId$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$$mask$");
        else if (text != null) {
            if (text == "000" || text == "000" || text == "00" || text == "0")
                $(this).val("0001");
        }
    });

  

