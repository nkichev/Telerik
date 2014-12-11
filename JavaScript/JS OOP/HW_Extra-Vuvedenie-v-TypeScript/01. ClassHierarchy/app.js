var Vehicle;
(function (Vehicle) {
    "use strict";

    var oldMazda = new Vehicle.Car("Mazda", 5 /* Petrol */, 5, 140);
    console.log(oldMazda);

    oldMazda.addPassanger(new Vehicle.Passanger("Pesho"));
    oldMazda.addPassanger(new Vehicle.Passanger("Gosho"));
    console.log(oldMazda.listPassengers());

    var newVan = new Vehicle.Van("Toyota", 3 /* Hybrid */, 7, 200, 100);
    console.log(newVan);

    newVan.addPassanger(new Vehicle.Passanger("Ivan"));
    newVan.addPassanger(new Vehicle.Passanger("Kiro"));
    console.log(newVan.listPassengers());

    newVan.addCargo(new Vehicle.Cargo("bag"));
    newVan.addCargo(new Vehicle.Cargo("suitcase"));
    console.log(newVan.listCargoItems());

    var newTruck = new Vehicle.Truck("Renault", 0 /* Diesel */, 2, 120, 1000);
    console.log(newTruck);

    newTruck.addCargo(new Vehicle.Cargo("tiles"));
    newTruck.addCargo(new Vehicle.Cargo("bricks"));
    console.log(newTruck.listCargoItems());

    var newBus = new Vehicle.Bus("Neoplan", 0 /* Diesel */, 7, 200, 100);
    console.log(newBus);

    newBus.addPassanger(new Vehicle.Passanger("Ivan"));
    newBus.addPassanger(new Vehicle.Passanger("Kiro"));
    console.log(newBus.listPassengers());

    newBus.addCargo(new Vehicle.Cargo("bag"));
    newBus.addCargo(new Vehicle.Cargo("suitcase"));
    console.log(newBus.listCargoItems());

    newBus.addDestination(new Vehicle.Town("Bourgas"));
    newBus.addRoute([
        new Vehicle.Town("Sofia"),
        new Vehicle.Town("Plovdiv"),
        new Vehicle.Town("Stara Zagora"),
        newBus.getDestination()
    ]);

    console.log(newBus.listRoute());
})(Vehicle || (Vehicle = {}));
//# sourceMappingURL=app.js.map
