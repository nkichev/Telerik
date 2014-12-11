//var divs = document.querySelectorAll('div > div'),
//    len = divs.length;

//for (var i = 0; i < len; i++) {
//    console.log(divs[i].outerHTML);
//    console.log('-----------------------------');
//}

var divs = document.getElementsByTagName('div'),
    len = divs.length;

for (var i = 0; i < len; i++) {
    if (divs[i].parentNode.tagName === 'DIV') {
        console.log(divs[i].outerHTML);
        console.log('-----------------------------');
    }
}