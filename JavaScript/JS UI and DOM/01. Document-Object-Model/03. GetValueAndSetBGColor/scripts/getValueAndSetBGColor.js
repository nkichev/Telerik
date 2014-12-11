function setBackgroundColor() {
    var input = document.getElementsByTagName('input')[0],
        btn = document.getElementById('btn');
        
    btn.onclick = function () {
        var color = input.value;
        document.body.style.backgroundColor = color;
    }
}

setBackgroundColor();