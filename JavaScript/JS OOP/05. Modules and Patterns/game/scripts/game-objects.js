var GameObjects = (function () {
    "use strict";

    function _Cell(x, y) {
        this.x = x;
        this.y = y;
    }

    var Apple = (function () {

        function Apple(cell) {
            this.body = new _Cell(cell.x, cell.y);
        }
        Apple.prototype.draw = function (renderer) {
            renderer.drawCells([this.body], 'orange');
        };

        return Apple;
    })();

    var Snake = (function () {
        var _dirs = {
            right: [1, 0],
            left: [-1, 0],
            up: [0, -1],
            down: [0, 1]
        };

        // constructor
        function Snake(cellSize, startLength, startX, startY) {
            this._cellSize = cellSize;
            this._head = new _Cell(startX, startY);
            this._body = new Array(startLength - 1);
            for (var i = 0; i < startLength - 1; i++) {
                this._body[i] = new _Cell(startX - this._cellSize * (i + 1), startY);
            }
            this._direction = _dirs.right;
        }

        Snake.prototype.move = function () {
            this._body.splice(this._body.length - 1, 1);
            this._body.unshift(new _Cell(this._head.x, this._head.y));

            this._head.x += this._direction[0] * this._cellSize;
            this._head.y += this._direction[1] * this._cellSize;
        };

        Snake.prototype.draw = function (renderer) {
            renderer.drawCells([this._head], 'blue');
            renderer.drawCells(this._body, 'blue');
        };

        Snake.prototype.eatApple = function () {
            // Add cell to the snake body
            var tailX = this._body[this._body.length - 1].x * 2 - this._body[this._body.length - 2].x;
            var tailY = this._body[this._body.length - 1].y * 2 - this._body[this._body.length - 2].y;
            this._body.push(new _Cell(tailX, tailY));
        };

        Snake.prototype.headCollidesWithBody = function () {
            for (var i = 0; i < this._body.length; i++)
                if (this._head.x === this._body[i].x && this._head.y === this._body[i].y)
                    return true;
            return false;
        };

        Snake.prototype.attachEventHandlers = function (document) {
            document.addEventListener('keydown', this.onKeyDown.bind(this), false);
        };

        Snake.prototype.onKeyDown = function (event) {
            event = event || window.event;
            var keyCode = event.keyCode;

            // 'this' is bound to the Snake instance in attachEventHandlers()
            if (keyCode === 37 && this._direction !== _dirs.right) // left
                this._direction = _dirs.left;

            if (keyCode === 38 && this._direction !== _dirs.down) // up
                this._direction = _dirs.up;

            if (keyCode === 39 && this._direction !== _dirs.left) // right
                this._direction = _dirs.right;

            if (keyCode === 40 && this._direction !== _dirs.up) // down
                this._direction = _dirs.down;
        };

        return Snake;
    }());

    return {
        Apple: Apple,
        Snake: Snake
    };
}());