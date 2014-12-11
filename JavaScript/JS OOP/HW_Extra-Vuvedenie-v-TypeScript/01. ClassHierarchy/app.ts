module Vehicle {
    "use strict";

    var oldMazda = new Car("Mazda", Engine.Petrol, 5, 140);
    console.log(oldMazda);

    oldMazda.addPassanger(new Passanger("Pesho"));
    oldMazda.addPassanger(new Passanger("Gosho"));
    console.log(oldMazda.listPassengers());

    var newVan = new Van("Toyota", Engine.Hybrid, 7, 200, 100);
    console.log(newVan);

    newVan.addPassanger(new Passanger("Ivan"));
    newVan.addPassanger(new Passanger("Kiro"));
    console.log(newVan.listPassengers());

    newVan.addCargo(new Cargo("bag"));
    newVan.addCargo(new Cargo("suitcase"));
    console.log(newVan.listCargoItems());

    var newTruck = new Truck("Renault", Engine.Diesel, 2, 120, 1000);
    console.log(newTruck);

    newTruck.addCargo(new Cargo("tiles"));
    newTruck.addCargo(new Cargo("bricks"));
    console.log(newTruck.listCargoItems());

    var newBus = new Bus("Neoplan", Engine.Diesel, 7, 200, 100);
    console.log(newBus);

    newBus.addPassanger(new Passanger("Ivan"));
    newBus.addPassanger(new Passanger("Kiro"));
    console.log(newBus.listPassengers());

    newBus.addCargo(new Cargo("bag"));
    newBus.addCargo(new Cargo("suitcase"));
    console.log(newBus.listCargoItems());

    newBus.addDestination(new Town("Bourgas"));
    newBus.addRoute([
        new Town("Sofia"),
        new Town("Plovdiv"),
        new Town("Stara Zagora"),
        newBus.getDestination()
    ]);

    console.log(newBus.listRoute());


}   