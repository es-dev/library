$('#$vwgId$').unbind('mouseenter');
$('#$vwgId$').unbind('mouseleave');
$('#$vwgId$').unbind('mousedown');
$('#$vwgId$').unbind('mouseup');
$('#$vwgId$').mouseenter(function () { $('#$vwgContainerId$').animate({ backgroundColor: '$enterBackColor$', borderWidth: '2px', borderColor: '$enterBorderColor$'}, $durationEnter$) });
$('#$vwgId$').mouseleave(function () { $('#$vwgContainerId$').animate({ backgroundColor: '$leaveBackColor$', borderWidth: '1px', borderColor: '$leaveBorderColor$' }, $durationLeave$) });
$('#$vwgId$').mousedown(function () { $('#$vwgContainerId$').animate({ backgroundColor: '$downBackColor$' }, 0) });
$('#$vwgId$').mouseup(function () { $('#$vwgContainerId$').animate({ backgroundColor: '$enterBackColor$' }, 0) });
$('#$vwgContainerId$').animate({ backgroundColor: '$leaveBackColor$' }, 0);
