var ctx = document.getElementById("canvas").getContext("2d");

var shape = (function () {
    'use strict';

    function DrawRect(position, measures, color) {
       // ctx.save();
        //ctx.fillStyle = color;
        ctx.beginPath();
        ctx.strokeStyle =  color;
        ctx.rect(position.x, position.y, measures.width, measures.height);
        ctx.stroke();
      //  ctx.restore();
    }

    function DrawCircle(position, radius, color) {
      //  ctx.save();
        ctx.beginPath();
        ctx.strokeStyle =  color;
        ctx.moveTo(position.x + radius, position.y);
        ctx.arc(position.x, position.y, radius, 0, 2 * Math.PI);
        ctx.stroke();
     //   ctx.restore();
    }

    function DrawLine(startPosition, endPosition, color) {
       // ctx.save();
        ctx.beginPath();
        ctx.strokeStyle = color;
        ctx.moveTo(startPosition.x, startPosition.y);
        ctx.lineTo(endPosition.x, endPosition.y);
        ctx.stroke();
      //  ctx.restore();
    }

    return {
        drawRect: DrawRect,
        drawCircle: DrawCircle,
        drawLine: DrawLine
    };

}());

var createFeatures = (function () {
    'use strict';
    var label = document.createElement('label'),
        input = document.createElement('input'),
        field = function (legendName) {
            var fieldset = document.createElement('fieldset'),
                legend = document.createElement('legend'),
                labelX = label.cloneNode(true),
                inputX = input.cloneNode(true),
                labelY = label.cloneNode(true),
                inputY = input.cloneNode(true);

            fieldset.classList.add('inputFields');

            legend.classList.add('legend');
            legend.innerText = legendName;

            labelX.innerText = 'Start X :';
            labelY.innerText = 'Start Y :';

            fieldset.appendChild(legend);

            fieldset.appendChild(labelX);
            fieldset.appendChild(inputX);

            fieldset.appendChild(labelY);
            fieldset.appendChild(inputY);

            return fieldset;
        };

    label.classList.add('inputLabels');
    label.style.display = 'inline-block';
    input.classList.add('inputs');

    function rectFeatures() {
        var fieldsetRect = field('Rectangle').cloneNode(true),
            labelWidth = label.cloneNode(true),
            inputWidth = input.cloneNode(true),
            labelHeight = label.cloneNode(true),
            inputHeight = input.cloneNode(true);
        // buttonRect = buttonCreate.cloneNode(true);
        console.log(fieldsetRect);
        fieldsetRect.classList.add('rect');
        labelWidth.innerText = 'Width :';
        labelHeight.innerText = 'Height :';
        //   buttonRect.addEvent(shape.drawRect);

        fieldsetRect.appendChild(labelWidth);
        fieldsetRect.appendChild(inputWidth);

        fieldsetRect.appendChild(labelHeight);
        fieldsetRect.appendChild(inputHeight);
        //   fieldsetRect.appendChild(buttonRect);

        return fieldsetRect;
    }

    function circleFeatures() {
        var fieldsetCircle = field('Circle').cloneNode(true),
            labelRadius = label.cloneNode(true),
            inputRadius = input.cloneNode(true);
        fieldsetCircle.classList.add('circle');
        labelRadius.innerText = 'Radius :';

        fieldsetCircle.appendChild(labelRadius);
        fieldsetCircle.appendChild(inputRadius);

        return fieldsetCircle;
    }

    function lineFeatures() {
        var fieldsetLine = field('Line').cloneNode(true),
            labelX = label.cloneNode(true),
            inputX = input.cloneNode(true),
            labelY = label.cloneNode(true),
            inputY = input.cloneNode(true);
        fieldsetLine.classList.add('line');
        labelX.innerText = 'End X :';
        labelY.innerText = 'End Y :';

        fieldsetLine.appendChild(labelX);
        fieldsetLine.appendChild(inputX);

        fieldsetLine.appendChild(labelY);
        fieldsetLine.appendChild(inputY);
          return fieldsetLine;
    }

    return {
        rectFeatures: rectFeatures,
        circleFeatures: circleFeatures,
        lineFeatures: lineFeatures
    };
}());

var userInput = document.getElementById('inputUser');
var buttonCreate = document.createElement('a');
buttonCreate.classList.add('buttonCreate');
buttonCreate.innerText = 'Create';

function getRandomNumber(min, max) {
    'use strict';
    if (!max) {
        max = min;
        min = 0;
    }

    return (Math.random() * (max - min) + min) | 0;
}

function parseInputValue(inputValue) {
    'use strict';
    var x = $(inputValue).val() | 0;
    if (!x) {
        x = getRandomNumber(100, 500);
    }
    return x;
}

function readRectFeatures() {
    'use strict';
    var inputRectFeatures = $('.rect').find('.inputs'),
        x = parseInputValue(inputRectFeatures[0]),
        y = parseInputValue(inputRectFeatures[1]),
        width = parseInputValue(inputRectFeatures[2]),
        height = parseInputValue(inputRectFeatures[3]);
    console.log(inputRectFeatures);
    return {
        x: x,
        y: y,
        width: width,
        height: height
    };
}

function drawRect() {
    'use strict';
    var rectFeatures = readRectFeatures(),
        positionRect = {
            x: rectFeatures.x,
            y: rectFeatures.y
        },
        sizeRect = {
            width: rectFeatures.width,
            height: rectFeatures.height
        };
    console.log(rectFeatures);
    console.log(sizeRect);
    console.log(sizeRect);

    shape.drawRect(positionRect, sizeRect, 'blue');
}

function showRectUI() {
    'use strict';
    var element = createFeatures.rectFeatures(),
        currentButton = buttonCreate.cloneNode(true);
    currentButton.addEventListener('click', drawRect);
    console.log(currentButton);
    element.appendChild(currentButton);
    userInput.appendChild(element);
}

document.getElementById('rect').addEventListener('change', showRectUI);

function readCircleFeatures() {
    'use strict';
    var inputCircleFeatures = $('.circle').find('.inputs'),
        x = parseInputValue(inputCircleFeatures[0]),
        y = parseInputValue(inputCircleFeatures[1]),
        radius = parseInputValue(inputCircleFeatures[2]);
    console.log(inputCircleFeatures);
    return {
        x: x,
        y: y,
        radius: radius
    };
}

function drawCircle() {
    'use strict';
    var circleFeatures = readCircleFeatures(),
        positionCircle = {
            x: circleFeatures.x,
            y: circleFeatures.y
        },
        radius = circleFeatures.radius;
    console.log(positionCircle);
    console.log(radius);
    console.log(circleFeatures);

    shape.drawCircle(positionCircle, radius, 'green');
}

function showCircleUI() {
    'use strict';
    var element = createFeatures.circleFeatures(),
        currentButton = buttonCreate.cloneNode(true);
    currentButton.addEventListener('click', drawCircle);
    element.appendChild(currentButton);
    userInput.appendChild(element);
}

document.getElementById('circle').addEventListener('change', showCircleUI);

function readLineFeatures() {
    'use strict';
    var inputLineFeatures = $('.line').find('.inputs'),
        startX = parseInputValue(inputLineFeatures[0]),
        startY = parseInputValue(inputLineFeatures[1]),
        endX = parseInputValue(inputLineFeatures[2]),
        endY = parseInputValue(inputLineFeatures[3]);
    console.log(inputLineFeatures);
    return {
        startX: startX,
        startY: startY,
        endX: endX,
        endY: endY
    };
}

function drawLine() {
    'use strict';
    var lineFeatures = readLineFeatures(),
        positionStart = {
            x: lineFeatures.startX,
            y: lineFeatures.startY
        },
        positionEnd = {
            x: lineFeatures.endX,
            y: lineFeatures.endY
        };
    console.log(lineFeatures);
    console.log(positionStart);
    console.log(positionEnd);

    shape.drawLine(positionStart, positionEnd, 'red');
}

function showLineUI() {
    'use strict';
    var element = createFeatures.lineFeatures(),
        currentButton = buttonCreate.cloneNode(true);
    currentButton.addEventListener('click', drawLine);
    element.appendChild(currentButton);
    userInput.appendChild(element);
}

document.getElementById('line').addEventListener('change', showLineUI);
