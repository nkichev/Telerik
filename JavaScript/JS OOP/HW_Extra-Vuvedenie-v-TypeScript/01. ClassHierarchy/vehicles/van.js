var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Vehicle;
(function (Vehicle) {
    var Van = (function (_super) {
        __extends(Van, _super);
        function Van(manufacture, engineType, numberOfPassengerSeats, maximumSpeed, maxCapacity) {
            _super.call(this, manufacture, engineType, numberOfPassengerSeats, maximumSpeed);
            this.maxCapacity = maxCapacity;

            //this.maxCapacity = maxCapacity; // doesn't need to call again maxCapasity - see the js file
            this.cargoList = [];
        }
        Van.prototype.addCargo = function (cargo) {
            this.cargoList.push(cargo);
        };

        Van.prototype.unloadCargo = function (cargo) {
            var cargoToBeRemovedIndex = this.cargoList.indexOf(cargo);
            this.cargoList[cargoToBeRemovedIndex] = this.cargoList[this.cargoList.length - 1];
            this.cargoList.pop();
        };

        Van.prototype.listCargoItems = function () {
            return this.cargoList.slice(0);
        };
        return Van;
    })(Vehicle.Car);
    Vehicle.Van = Van;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=van.js.map
