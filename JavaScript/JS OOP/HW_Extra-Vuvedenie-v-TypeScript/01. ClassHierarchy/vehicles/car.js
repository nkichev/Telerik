var Vehicle;
(function (Vehicle) {
    var Car = (function () {
        function Car(manufacture, engineType, numberOfPassengerSeats, maximumSpeed) {
            this.manufacture = manufacture;
            this.engineType = engineType;
            this.numberOfPassengerSeats = numberOfPassengerSeats;
            this.maximumSpeed = maximumSpeed;
            this.passengersList = [];
        }
        Car.prototype.addPassanger = function (passenger) {
            this.passengersList.push(passenger);
        };

        Car.prototype.removePassenger = function (passenger) {
            var passengerToBeRemovedIndex = this.passengersList.indexOf(passenger);
            this.passengersList[passengerToBeRemovedIndex] = this.passengersList[this.passengersList.length - 1];
            this.passengersList.pop();
        };

        Car.prototype.listPassengers = function () {
            return this.passengersList.splice(0);
        };
        return Car;
    })();
    Vehicle.Car = Car;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=car.js.map
