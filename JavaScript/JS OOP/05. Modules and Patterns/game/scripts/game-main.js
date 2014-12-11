var Game = (function () {
    "use strict";

    var gameInstance;

    var Game = (function () {

        var _cellSize,
            _fieldWidth,
            _fieldHeight,
            _numApples,
            _intervalID,
            _snake,
            _apples,
            _canvasRenderer;

        function _getRandomCell() {
            var x = Math.round(Math.random() * (_fieldWidth / _cellSize - 1)) * _cellSize;
            var y = Math.round(Math.random() * (_fieldHeight / _cellSize - 1)) * _cellSize;
            return {
                x: x,
                y: y
            };
        }

        function _gameLoop() {
            _canvasRenderer.clearScreen();
            _apples.forEach(function (apple) {
                apple.draw(_canvasRenderer);
            });
            _snake.draw(_canvasRenderer);
            _snake.move();
            if (_snakeIsAlive()) {
                _eatApples();
            } else {
                clearInterval(_intervalID);
                alert('Game Over.');
            }
        }

        function _eatApples() {
            for (var i = 0; i < _apples.length; i++) {
                if (_apples[i].body.x === _snake._head.x && _apples[i].body.y === _snake._head.y) {
                    // Add cell to the snake tail
                    _snake.eatApple();
                    // Remove the eaten apple and create a new one at random position
                    _apples.splice(i, 1);
                    var randomCell = _getRandomCell();
                    _apples.push(new GameObjects.Apple(randomCell));
                }
            }
        }

        function _snakeIsAlive() {
            // Check if head collides with the screen borders
            if (_snake._head.x < 0 || _snake._head.x > _fieldWidth - _cellSize ||
                _snake._head.y < 0 || _snake._head.y > _fieldHeight - _cellSize)
                return false;

            if (_snake.headCollidesWithBody())
                return false;

            return true;
        }

        // constructor
        function Game(cellSize) {
            _cellSize = cellSize || 20; // pixels
            _fieldWidth = 32 * _cellSize;
            _fieldHeight = 20 * _cellSize;
            _numApples = 1;
        }

        Game.prototype.run = function () {
            _canvasRenderer = CanvasRenderer.getRenderer(_fieldWidth, _fieldHeight, _cellSize);
            // Snake(cellSize, startLength, startX, startY)
            _snake = new GameObjects.Snake(_cellSize, 5, _cellSize, _cellSize);
            _snake.attachEventHandlers(document);
            _apples = [];
            for (var i = 0; i < _numApples; i++) {
                var randomCell = _getRandomCell();
                _apples.push(new GameObjects.Apple(randomCell));
            }

            _intervalID = setInterval(_gameLoop, 1000 / 10);
        }

        return Game;

    })();

    return {
        createGame: function () {
            if (!gameInstance) {
                gameInstance = new Game();
            }

            return gameInstance;
        }
    };
})();