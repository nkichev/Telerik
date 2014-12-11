var canvas = document.getElementById('the-canvas'),
    ctx = canvas.getContext('2d'),
    fieldRows = 300,
    fieldCols = 586,
    row = 10,
    col = 10,
    radius = 5,
    rowChange = 8,
    colChange = 8;

function ballBounce() {


    ctx.clearRect(0, 0, fieldCols, fieldRows);
    drawCircle(col, row);

    if (row + radius >= fieldRows || row + radius <= 5) {
        rowChange *= -1;
    }
    if (col + radius >= fieldCols || col + radius <= 5) {
        colChange *= -1;
    }

    row += rowChange;
    col += colChange;

    function drawCircle(x, y) {
        ctx.beginPath();
        ctx.arc(x, y, radius, 0, 2 * Math.PI);
        ctx.fillStyle = 'blue';
        ctx.fill();
        ctx.stroke();
    }

    requestAnimationFrame(ballBounce);
}

ballBounce();