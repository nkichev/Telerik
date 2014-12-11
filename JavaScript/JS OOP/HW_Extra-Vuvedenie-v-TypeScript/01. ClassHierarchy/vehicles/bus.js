var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Vehicle;
(function (Vehicle) {
    "use strict";

    var Bus = (function (_super) {
        __extends(Bus, _super);
        function Bus(manufacture, engineType, numberOfPassengerSeats, maximumSpeed, maxCapacity) {
            _super.call(this, manufacture, engineType, numberOfPassengerSeats, maximumSpeed, maxCapacity);

            // this.maxCapacity = maxCapacity; // doesn't need to call again maxCapasity - see the js file
            this.route = [];
        }
        Bus.prototype.addDestination = function (townName) {
            this.destination = townName;
        };

        Bus.prototype.getDestination = function () {
            return this.destination;
        };

        Bus.prototype.addRoute = function (newRoute) {
            var that = this;
            newRoute.forEach(function (town) {
                that.route.push(town);
            });
        };

        Bus.prototype.listRoute = function () {
            return this.route.slice(0);
        };
        return Bus;
    })(Vehicle.Van);
    Vehicle.Bus = Bus;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=bus.js.map
