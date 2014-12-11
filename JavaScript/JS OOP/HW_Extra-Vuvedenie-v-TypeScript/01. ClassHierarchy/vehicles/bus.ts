module Vehicle {
    "use strict";

    export class Bus extends Van implements Interfaces.ICar, Interfaces.IVehicle, Interfaces.ILoadable {
        private destination: Town;
        private route: Town[];

        constructor(manufacture: string, engineType: Vehicle.Engine, numberOfPassengerSeats: number, maximumSpeed: number, maxCapacity: number) {
            super(manufacture, engineType, numberOfPassengerSeats, maximumSpeed, maxCapacity);
            // this.maxCapacity = maxCapacity; // doesn't need to call again maxCapasity - see the js file
            this.route = [];
        }

        addDestination(townName: Town): void {
            this.destination = townName;
        }

        getDestination(): Town {
            return this.destination;
        }

        addRoute(newRoute: Town[]): void {
            var that = this;
            newRoute.forEach(function (town) {
                that.route.push(town);
            });
        }

        listRoute(): Town[]{
            return this.route.slice(0);
        }
    }
} 