$('#$vwgId$').unbind('mouseenter');
$('#$vwgId$').unbind('mouseleave');
$('#$vwgId$').unbind('mousedown');
$('#$vwgId$').unbind('mouseup');
$('#$vwgId$').mouseenter(function () { $('#$vwgId$').animate({ backgroundColor: '$enterBackColor$', borderWidth: '2px', borderColor: '$enterBorderColor$' }, $durationEnter$) });
$('#$vwgId$').mouseleave(function () { $('#$vwgId$').animate({ backgroundColor: '$leaveBackColor$', borderWidth: '1px', borderColor: '$leaveBorderColor$' }, $durationLeave$) });
$('#$vwgId$').mousedown(function () { $('#$vwgId$').animate({ backgroundColor: '$downBackColor$' }, 0) });
$('#$vwgId$').mouseup(function () { $('#$vwgId$').animate({ backgroundColor: '$enterBackColor$' }, 0) });
$('#$vwgId$').animate({ backgroundColor: '$leaveBackColor$'}, 0);
