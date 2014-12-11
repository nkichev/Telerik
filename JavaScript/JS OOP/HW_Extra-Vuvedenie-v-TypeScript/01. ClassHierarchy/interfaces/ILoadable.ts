module Interfaces {
    export interface ILoadable{
        maxCapacity: number;
        addCargo(cargo: ICargo): void;
        unloadCargo(cargo: ICargo): void;
        listCargoItems(): ICargo[];
    }
} 