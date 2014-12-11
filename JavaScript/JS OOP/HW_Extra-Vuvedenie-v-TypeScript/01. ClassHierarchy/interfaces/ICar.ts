module Interfaces {
    export interface ICar extends IVehicle{
        numberOfPassengerSeats: number;
        addPassanger(passenger: IPassenger): void;
        removePassenger(passenger: IPassenger): void;
        listPassengers(): IPassenger[];
    }
}