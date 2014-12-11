var Vehicle;
(function (Vehicle) {
    var Cargo = (function () {
        function Cargo(type) {
            this.type = type;
        }
        return Cargo;
    })();
    Vehicle.Cargo = Cargo;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=Cargo.js.map
