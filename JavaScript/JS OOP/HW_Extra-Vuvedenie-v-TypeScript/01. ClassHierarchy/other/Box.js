var Vehicle;
(function (Vehicle) {
    var Box = (function () {
        function Box(type) {
            this.type = type;
        }
        return Box;
    })();
    Vehicle.Box = Box;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=Box.js.map
