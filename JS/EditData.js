
    var editingKeys = {
        '8': 'backspace',
        '46': 'canc',
        '37': 'leftarrow',
        '39': 'rightarrow',
        '9': 'tab'
    };

    $('#$VWGDay$').unbind('keydown');
    $('#$VWGDay$').bind('keydown', function (e) {
        if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (length == 1 && !(e.keyCode in editingKeys)) {
                    if (text == "0" && (e.keyCode == 48 || e.keyCode == 96))
                        return false;
                }
                else if (length == 2 && !(e.keyCode in editingKeys)) {
                    $("#$VWGMonth$").focus();
                }
                return true;
            }
        }
        else
            return false;
    });

   

    $('#$VWGMonth$').unbind('keydown');
    $('#$VWGMonth$').bind('keydown', function (e) {
        if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (e.keyCode == 8 && length == 0) {
                    $("#$VWGDay$").focus();
                }
                else {
                    if (length == 1 && !(e.keyCode in editingKeys)) {
                       if (text == "0" && (e.keyCode==48 || e.keyCode==96))
                            return false;
                    }
                    else if (length == 2 && !(e.keyCode in editingKeys)) {
                            $("#$VWGYear$").focus();
                        }
                    return true;
                }
            }
        }
        else
            return false;
    });

    $('#$VWGYear$').unbind('keydown');
    $('#$VWGYear$').bind('keydown', function (e) {
        if (e.keyCode >= 48 && e.keyCode <= 57 || e.keyCode >= 96 && e.keyCode <= 105 || e.keyCode in editingKeys) {
            var text = $(this).val();
            if (text != null) {
                var length = text.length;
                if (e.keyCode == 8 && length == 0) {
                    $("#$VWGMonth$").focus();
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

    $('#$VWGDay$').unbind('focusin');
    $('#$VWGDay$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$VWGDay$').unbind('focusout');
    $('#$VWGDay$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
        else if (text != null) {            
            if (text == "00" || text == "0")
                $(this).val("01");
        }           
    });

    $('#$VWGMonth$').unbind('focusin');
    $('#$VWGMonth$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$VWGMonth$').unbind('focusout');
    $('#$VWGMonth$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
        else if (text != null) {
            if (text == "00" || text == "0")
                $(this).val("01");
        }
    });

    $('#$VWGYear$').unbind('focusin');
    $('#$VWGYear$').bind('focusin', function () {
        var text = $(this).val();
        if (text == "$mask$")
            $(this).val("");
    });

    $('#$VWGYear$').unbind('focusout');
    $('#$VWGYear$').bind('focusout', function () {
        var text = $(this).val();
        if (text == null || text == "")
            $(this).val("$mask$");
        else if (text != null) {
            if (text == "000" || text == "000" || text == "00" || text == "0")
                $(this).val("0001");
        }
    });

  

