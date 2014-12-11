var Vehicle;
(function (Vehicle) {
    var Town = (function () {
        function Town(type) {
            this.type = type;
        }
        return Town;
    })();
    Vehicle.Town = Town;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=Town.js.map
