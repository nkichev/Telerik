module Vehicle {
    export class Truck implements Interfaces.IVehicle, Interfaces.ILoadable {
        private cargoList: Interfaces.ICargo[];

        addCargo(cargo: Interfaces.ICargo): void {
            this.cargoList.push(cargo);
        }

        unloadCargo(cargo: Interfaces.ICargo): void {
            var cargoToBeRemovedIndex = this.cargoList.indexOf(cargo);
            this.cargoList[cargoToBeRemovedIndex] = this.cargoList[this.cargoList.length - 1];
            this.cargoList.pop();
        }

        listCargoItems(): Interfaces.ICargo[]{
            return this.cargoList.slice(0);
        }

        constructor(public manufacture: string, public engineType: Vehicle.Engine, public numberOfPassengerSeats: number, public maximumSpeed: number, public maxCapacity: number) {
            this.cargoList = [];
        }
    }
} 