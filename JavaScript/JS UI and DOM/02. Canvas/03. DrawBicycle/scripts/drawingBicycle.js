var canvas = document.getElementById('the-canvas'),
    ctx = canvas.getContext('2d');

//left wheel
ctx.beginPath();
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#328295';
ctx.arc(150, 500, 55, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

//right wheel
ctx.beginPath();
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#328295';
ctx.arc(400, 500, 55, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

//thing else
ctx.beginPath();
ctx.moveTo(150, 500);
ctx.lineTo(230, 400);
ctx.lineTo(380, 400);
ctx.lineTo(280, 500);
ctx.lineTo(150, 500);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(280, 500);
ctx.lineTo(210, 360);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(180, 360);
ctx.lineTo(240, 360);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(400, 500);
ctx.lineTo(370, 340);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(370, 340);
ctx.lineTo(324, 365);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(370, 340);
ctx.lineTo(390, 300);
ctx.stroke();

ctx.beginPath();
ctx.arc(280, 500, 24, 0, 2 * Math.PI);
ctx.stroke();