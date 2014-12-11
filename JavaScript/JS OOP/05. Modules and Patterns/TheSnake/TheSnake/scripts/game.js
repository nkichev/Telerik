var games = (function () {
    var foods = [];
    var walls = [];

    function generateFoods() {
        for (var i = 0; i < 5; i++) {
            var food = new snakes.getFood(Math.random() * 800, Math.random() * 500, 15);
            foods.push(food);
        }
    }
    function generateWalls() {
        for (i = 0; i < 3; i++) {
            var wall = new snakes.getWall(Math.random() * 800, Math.random() * 500, 15);
            walls.push(wall);
        }
    }
    
	function Game(renderer) {
		this.renderer = renderer;
		this.snake = new snakes.get(250, 250, 15);
		generateFoods();
		generateWalls();
		this.foods = foods;
		this.walls = walls;
		this.bindKeyEvents();
		this.state = "stopped";
	}

	function animationFrame() {
	    function drawFoods() {
	        for (var i = 0; i < theGame.foods.length; i++) {
	            theGame.renderer.draw(theGame.foods[i]);
	        }
	    };
	    function drawWalls() {
	        for (i = 0; i < theGame.walls.length; i++) {
	            theGame.renderer.draw(theGame.walls[i]);
	        }
	    };

		var snakePosition = theGame.snake.getPosition(),
			toChangePosition = false,
			newX = snakePosition.x,
			newY = snakePosition.y;

		if (snakePosition.x < dimensions.minWidth) {
			newX = dimensions.maxWidth;
			toChangePosition = true;
		} else if (dimensions.maxWidth < snakePosition.x) {
			newX = dimensions.minWidth;
			toChangePosition = true;
		}
		if (snakePosition.y < dimensions.minHeight) {
			newY = dimensions.maxHeight;
			toChangePosition = true;
		}
		if (dimensions.maxHeight < snakePosition.y) {
			newY = dimensions.minHeight;
			toChangePosition = true;
		}
		if (toChangePosition) {
			theGame.snake.changePosition(newX, newY);
		}

		theGame.renderer.clear();
		theGame.snake.move();
		drawFoods();
		drawWalls();
		theGame.renderer.draw(theGame.snake);
		if (theGame.state === "running") {
			requestAnimationFrame(animationFrame);
		}
	}

	var dimensions;
	Game.prototype = {
		start: function () {
			theGame = this;
			requestAnimationFrame(animationFrame);
			dimensions = this.renderer.getDimensions();
			this.state = "running";
		},
		stop: function () {
			theGame.state = "stopped";
		},
		bindKeyEvents: function () {
			var self = this;
			document.body.addEventListener("keydown", function (ev) {
				var keyCode = ev.keyCode;
				if (37 <= keyCode && keyCode <= 40) {
					self.snake.changeDirection(keyCode - 37);
				}
			});
		},
		getState: function () {
			return this.state;
		},
		changeRenderer: function (newRenderer) {
			this.renderer = newRenderer;
		}
	}

	return {
		get: function (renderer) {
			return new Game(renderer);
		}
	};
}());