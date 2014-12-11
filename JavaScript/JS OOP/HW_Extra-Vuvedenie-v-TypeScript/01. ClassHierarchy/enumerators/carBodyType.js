var Vehicle;
(function (Vehicle) {
    (function (CarBodyType) {
        CarBodyType[CarBodyType["Saloon"] = 0] = "Saloon";
        CarBodyType[CarBodyType["EstateCar"] = 1] = "EstateCar";
        CarBodyType[CarBodyType["Limousine"] = 2] = "Limousine";
        CarBodyType[CarBodyType["SmallCar"] = 3] = "SmallCar";
        CarBodyType[CarBodyType["OffRoad"] = 4] = "OffRoad";
        CarBodyType[CarBodyType["Cabriolet"] = 5] = "Cabriolet";
        CarBodyType[CarBodyType["Coupe"] = 6] = "Coupe";
        CarBodyType[CarBodyType["MiniVan"] = 7] = "MiniVan";
    })(Vehicle.CarBodyType || (Vehicle.CarBodyType = {}));
    var CarBodyType = Vehicle.CarBodyType;
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=CarBodyType.js.map
