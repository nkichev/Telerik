var vehicle;
(function (vehicle) {
    (function (engine) {
        engine[engine["Diesel"] = 0] = "Diesel";
        engine[engine["Electric"] = 1] = "Electric";
        engine[engine["Gas"] = 2] = "Gas";
        engine[engine["Hybrid"] = 3] = "Hybrid";
        engine[engine["Hydrogen"] = 4] = "Hydrogen";
        engine[engine["Petrol"] = 5] = "Petrol";
    })(vehicle.engine || (vehicle.engine = {}));
    var engine = vehicle.engine;
})(vehicle || (vehicle = {}));
//# sourceMappingURL=engins.js.map
