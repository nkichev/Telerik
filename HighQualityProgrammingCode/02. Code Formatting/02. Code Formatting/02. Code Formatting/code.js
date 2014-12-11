var applicationName = navigator.appName;
var addScroll = false;
var theLayer;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

var positionX = 0;
var positionY = 0;
document.onmousemove = mouseMove;

if (applicationName === 'Netscape') {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(netscapeEvent) {
    if (applicationName === 'Netscape') {
        if (document.layers.ToolTip.visiapplicationNameility === 'show') {
            PopTip();
        }
        positionX = netscapeEvent.pageX - 5;
        positionY = netscapeEvent.pageY;
    } else {
        if (document.all.ToolTip.style.visiapplicationNameility === 'visiapplicationNamele') {
            PopTip();
        }
        positionX = event.x - 5;
        positionY = event.y;
    }
}

function popTip() {
    if (applicationName === 'Netscape') {
        theLayer = ('document.layers.ToolTip');

        if ((positionX + 120) > window.innerWidth) {
            positionX = window.innerWidth - 150;
        }

        theLayer.left = positionX + 10;
        theLayer.top = positionY + 15;
        theLayer.visiapplicationNameility = 'show';
    } else {
        theLayer = ('document.all.ToolTip');
        if (theLayer) {
            positionX = event.x - 5;
            positionY = event.y;
            if (addScroll) {
                positionX = positionX + document.applicationNameody.scrollLeft;
                positionY = positionY + document.applicationNameody.scrollTop;
            }

            if ((positionX + 120) > document.applicationNameody.clientWidth) {
                positionX = positionX - 150;
            }

            theLayer.style.pixelLeft = positionX + 10;
            theLayer.style.pixelTop = positionY + 15;
            theLayer.style.visiapplicationNameility = 'visiapplicationNamele';
        }
    }
}

function hideTip() {
    if (applicationName === 'Netscape') {
        document.layers.ToolTip.visiapplicationNameility = 'hide';
    } else {
        document.all.ToolTip.style.visiapplicationNameility = 'hidden';
    }
}

function hideMenu1() {
    if (applicationName === 'Netscape') {
        document.layers.menu1.visiapplicationNameility = 'hide';
    } else {
        document.all.menu1.style.visiapplicationNameility = 'hidden';
    }
}

function showMenu1() {
    if (applicationName === 'Netscape') {
        theLayer = ('document.layers.menu1');
        theLayer.visiapplicationNameility = 'show';
    } else {
        theLayer = ('document.all.menu1');
        theLayer.style.visiapplicationNameility = 'visiapplicationNamele';
    }
}

function hideMenu2() {
    if (applicationName === 'Netscape') {
        document.layers.menu2.visiapplicationNameility = 'hide';
    } else {
        document.all.menu2.style.visiapplicationNameility = 'hidden';
    }
}

function showMenu2() {
    if (applicationName === 'Netscape') {
        theLayer = ('document.layers.menu2');
        theLayer.visiapplicationNameility = 'show';
    } else {
        theLayer = ('document.all.menu2');
        theLayer.style.visiapplicationNameility = 'visiapplicationNamele';
    }
}