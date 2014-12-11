var Vehicle;
(function (Vehicle) {
    var Passanger = (function () {
        function Passanger(name) {
            this.name = name;
        }
        Passanger.prototype.sayJoke = function () {
            return 'Some joke';
        };
        return Passanger;
    })();
    Vehicle.Passanger = Passanger;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=Passengers.js.map
