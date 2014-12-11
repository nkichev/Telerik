module Vehicle {
    export class Car implements Interfaces.ICar, Interfaces.IVehicle {
        private passengersList: Interfaces.IPassenger[];

        addPassanger(passenger: Interfaces.IPassenger): void {
            this.passengersList.push(passenger);
        }

        removePassenger(passenger: Interfaces.IPassenger): void {
            var passengerToBeRemovedIndex = this.passengersList.indexOf(passenger);
            this.passengersList[passengerToBeRemovedIndex] = this.passengersList[this.passengersList.length - 1];
            this.passengersList.pop();
        }

        listPassengers(): Interfaces.IPassenger[]{
            return this.passengersList.splice(0);
        }

        

        constructor(public manufacture: string, public engineType: Vehicle.Engine, public numberOfPassengerSeats: number, public maximumSpeed: number) {
            this.passengersList = [];
        }
    }
} 