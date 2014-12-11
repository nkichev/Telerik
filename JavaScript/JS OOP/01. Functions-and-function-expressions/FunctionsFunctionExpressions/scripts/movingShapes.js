var movingShapes = (function () {

    function getRandomColor() {
        return 'rgb(' + parseInt(Math.random() * 256, 10) +
            ',' + parseInt(Math.random() * 256, 10) +
            ',' + parseInt(Math.random() * 256, 10) + ')';
    }

    function ellipticMotion(angle, div) {
        var r1 = 80, 
            r2 = 120, 
            xCenter = 200,
            yCenter = 200,
            x = Math.floor(xCenter + (r1 * Math.cos(angle))),
            y = Math.floor(yCenter + (r2 * Math.sin(angle)));

        angle = angle + 0.01;
        div.style.top = x + 'px';
        div.style.left = y + 'px';

        setTimeout(function () { 
            ellipticMotion(angle, div);
        }, 20);
    }

    function rectangularMotion(dir, offset, div) {
        var xStart = 100, 
            yStart = 800, 
            rectSideA = 200, 
            rectSideB = 100,
            x,
            y;

        offset += 1; 
        if ((offset === rectSideA && dir % 2 === 0) || (offset === rectSideB && dir % 2 === 1)) {
            dir++;
            dir %= 4;
            offset = 0;
        }

        switch (dir) {
            case 0:
                y = yStart + offset;
                x = xStart;
                break;
            case 1:
                x = xStart + offset;
                y = yStart + rectSideA;
                break;
            case 2:
                y = yStart + rectSideA - offset;
                x = xStart + rectSideB;
                break;
            case 3:
                x = xStart + rectSideB - offset;
                y = yStart;
                break;
        }

        div.style.top = x + 'px';
        div.style.left = y + 'px';

        setTimeout(function () { 
            rectangularMotion(dir, offset, div);
        }, 20);
    }

    function add(shape) {
        var content = document.getElementById('content'),
            div = document.createElement('div');

        div.style.width = '50px';
        div.style.height = '50px';
        div.style.borderRadius = '50px';
        div.style.position = 'absolute';
        div.style.textAlign = 'center';
        div.style.backgroundColor = getRandomColor();
        div.style.color = getRandomColor();
        div.style.border = '3px solid' + getRandomColor();
        div.innerHTML = 'div';
        content.appendChild(div);

        if (shape === 'rect') {
            rectangularMotion(0, 0, div);
        } else {
            ellipticMotion(0, div);
        }
    }

    return {
        add: add
    };
}());