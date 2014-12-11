var canvas = document.getElementById('the-canvas'),
    ctx = canvas.getContext('2d');

//house base
ctx.fillStyle = '#975B5B';
ctx.strokeStyle = '#000';
ctx.lineWidth = 3;
ctx.fillRect(180, 310, 400, 300);
ctx.strokeRect(180, 310, 400, 300);

//door
ctx.lineWidth = 2;
ctx.fillRect(220, 490, 110, 110);
ctx.strokeRect(220, 490, 110, 110);

ctx.beginPath();
ctx.save();
ctx.scale(1, 0.5);
ctx.arc(275, 983, 55, Math.PI, 2 * Math.PI);
ctx.fill();
ctx.stroke();
ctx.restore();

ctx.beginPath();
ctx.moveTo(273, 465);
ctx.lineTo(273, 600);
ctx.stroke();

ctx.beginPath();
ctx.arc(262, 570, 4, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.arc(284, 570, 4, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();


//windows
//left
ctx.fillStyle = '#000';
ctx.fillRect(203, 335, 70, 50);
ctx.fillRect(275, 335, 70, 50);
ctx.fillRect(203, 388, 70, 50);
ctx.fillRect(275, 388, 70, 50);

//right top
ctx.fillRect(415, 335, 70, 50);
ctx.fillRect(488, 335, 70, 50);
ctx.fillRect(415, 388, 70, 50);
ctx.fillRect(488, 388, 70, 50);

//right bottom
ctx.fillRect(415, 465, 70, 50);
ctx.fillRect(488, 465, 70, 50);
ctx.fillRect(415, 518, 70, 50);
ctx.fillRect(488, 518, 70, 50);

//roof
ctx.beginPath();
ctx.moveTo(180, 310);
ctx.lineTo(380, 90);
ctx.lineTo(580, 310);
ctx.fillStyle = '#975B5B';
ctx.fill();
ctx.stroke();

//chimney
ctx.beginPath();
ctx.moveTo(480, 270);
ctx.lineTo(480, 160);
ctx.lineTo(515, 160);
ctx.lineTo(515, 270);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.save();
ctx.scale(1, 0.24);
ctx.arc(497, 662, 17, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();
ctx.restore();
