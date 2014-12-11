var Vehicle;
(function (Vehicle) {
    (function (Engine) {
        Engine[Engine["Diesel"] = 0] = "Diesel";
        Engine[Engine["Electric"] = 1] = "Electric";
        Engine[Engine["Gas"] = 2] = "Gas";
        Engine[Engine["Hybrid"] = 3] = "Hybrid";
        Engine[Engine["Hydrogen"] = 4] = "Hydrogen";
        Engine[Engine["Petrol"] = 5] = "Petrol";
    })(Vehicle.Engine || (Vehicle.Engine = {}));
    var Engine = Vehicle.Engine;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=Engine.js.map
