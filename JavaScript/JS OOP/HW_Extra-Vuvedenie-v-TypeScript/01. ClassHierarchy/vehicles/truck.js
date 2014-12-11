var Vehicle;
(function (Vehicle) {
    var Truck = (function () {
        function Truck(manufacture, engineType, numberOfPassengerSeats, maximumSpeed, maxCapacity) {
            this.manufacture = manufacture;
            this.engineType = engineType;
            this.numberOfPassengerSeats = numberOfPassengerSeats;
            this.maximumSpeed = maximumSpeed;
            this.maxCapacity = maxCapacity;
            this.cargoList = [];
        }
        Truck.prototype.addCargo = function (cargo) {
            this.cargoList.push(cargo);
        };

        Truck.prototype.unloadCargo = function (cargo) {
            var cargoToBeRemovedIndex = this.cargoList.indexOf(cargo);
            this.cargoList[cargoToBeRemovedIndex] = this.cargoList[this.cargoList.length - 1];
            this.cargoList.pop();
        };

        Truck.prototype.listCargoItems = function () {
            return this.cargoList.slice(0);
        };
        return Truck;
    })();
    Vehicle.Truck = Truck;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=truck.js.map
