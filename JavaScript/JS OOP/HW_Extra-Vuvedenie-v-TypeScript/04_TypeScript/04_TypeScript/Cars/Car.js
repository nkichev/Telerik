var Cars;
(function (Cars) {
    var Car = (function () {
        function Car(model, year) {
            this.model = model;
            this.year = year;
        }
        Car.prototype.start = function () {
            return "Drive off ... Brrrrm";
        };
        Car.prototype.move = function () {
            return "Driving ...";
        };
        Car.prototype.stop = function () {
            return "Arrived";
        };
        return Car;
    })();
    Cars.Car = Car;
})(Cars || (Cars = {}));

var myCar = new Cars.Car("Toyota", 2002);
console.log(myCar.start());
console.log(myCar.move());
console.log(myCar.stop());
//# sourceMappingURL=Car.js.map
