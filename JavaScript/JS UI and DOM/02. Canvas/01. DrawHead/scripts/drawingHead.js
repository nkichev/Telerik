var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

canvas.style.border = '1px solid black';

//the head
ctx.beginPath();
ctx.arc(180, 180, 65, 0, 2 * Math.PI);
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#31636F';
ctx.fill();
ctx.stroke();

//the nose
ctx.lineWidth = 2.1;
ctx.moveTo(170, 190);
ctx.lineTo(155, 190);
ctx.lineTo(170, 160);
ctx.stroke();

//the mouth
ctx.beginPath();
ctx.save();
ctx.scale(1, 0.3);
ctx.arc(170, 720, 25, 0, 2 * Math.PI);
ctx.stroke();
ctx.restore();

//left eye
ctx.beginPath();
ctx.save();
ctx.scale(1, 0.7);
ctx.arc(142, 230, 11, 0, 2 * Math.PI);
ctx.stroke();
ctx.restore();

//left eye fill
ctx.beginPath();
ctx.save();
ctx.scale(0.6, 1);
ctx.arc(231, 161, 6, 0, 2 * Math.PI);
ctx.fillStyle = '#31636F';
ctx.fill();
ctx.restore();

//right eye
ctx.beginPath();
ctx.save();
ctx.scale(1, 0.7);
ctx.arc(198, 230, 11, 0, 2 * Math.PI);
ctx.stroke();
ctx.restore();

//right eye fill
ctx.beginPath();
ctx.save();
ctx.scale(0.6, 1);
ctx.arc(324, 161, 6, 0, 2 * Math.PI);
ctx.fillStyle = '#31636F';
ctx.fill();
ctx.restore();

//hat base 
ctx.beginPath();
ctx.save();
drawElipse(177, 550, 70, 0, 2 * Math.PI, 1, 0.23);
ctx.restore();

//hat cylinder
ctx.beginPath();
ctx.save();
ctx.fillStyle = '396693';
ctx.fillRect(148, 49, 70, 65);
ctx.strokeStyle = '24211D';
ctx.strokeRect(148, 49, 70, 65);
ctx.restore();


//hat cylinder base
ctx.beginPath();
ctx.save();
drawElipse(183, 249, 35, 0, Math.PI, 1, 0.45)
ctx.restore();

//hat cylinder top
ctx.beginPath();
ctx.save();
drawElipse(183, 100, 35, 0, 2 * Math.PI, 1, 0.45);
ctx.restore();


function drawElipse(x, y, radius, from, to, xScale, yScale) {
    ctx.scale(xScale, yScale);
    ctx.arc(x, y, radius, from, to);
    ctx.fillStyle = '396693';
    ctx.fill();
    ctx.strokeStyle = '24211D';
    ctx.stroke();
}

