var Canvas = (function () {
    function Canvas(selector) {
        this._canvas = document.querySelector(selector);
        this._ctx = this._canvas.getContext('2d');
    }

    Canvas.prototype = {
        Rect: function (x, y, width, height) {
            this._ctx.strokeRect(x, y, width, height);
        },
        Circle: function (x, y, r) {
            this._ctx.beginPath();
            this._ctx.arc(x, y, r, 0, 2 * Math.PI);
            this._ctx.stroke();
        },
        Line: function (x1, y1, x2, y2) {
            this._ctx.beginPath();
            this._ctx.moveTo(x1, y1);
            this._ctx.lineTo(x2, y2);
            this._ctx.stroke();
        }
    }

    return Canvas;
})();