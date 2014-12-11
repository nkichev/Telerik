module Vehicle {
    export class Van extends Car implements Interfaces.ICar, Interfaces.IVehicle, Interfaces.ILoadable {
        private cargoList: Interfaces.ICargo[];

        constructor(manufacture: string, engineType: Vehicle.Engine, numberOfPassengerSeats: number, maximumSpeed: number, public maxCapacity: number) {
            super(manufacture, engineType, numberOfPassengerSeats, maximumSpeed);
            //this.maxCapacity = maxCapacity; // doesn't need to call again maxCapasity - see the js file
            this.cargoList = [];
        }

        addCargo(cargo: Interfaces.ICargo): void {
            this.cargoList.push(cargo);
        }

        unloadCargo(cargo: Interfaces.ICargo): void {
            var cargoToBeRemovedIndex = this.cargoList.indexOf(cargo);
            this.cargoList[cargoToBeRemovedIndex] = this.cargoList[this.cargoList.length - 1];
            this.cargoList.pop();
        }



        listCargoItems(): Interfaces.ICargo[] {
            return this.cargoList.slice(0);
        }
    }
} 