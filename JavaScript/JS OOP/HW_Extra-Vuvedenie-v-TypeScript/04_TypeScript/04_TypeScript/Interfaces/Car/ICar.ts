module Interfaces.Cars {
    export interface ICar {
        model: string;
        year: number;
        start(): void;
        move(): void;
        stop(): void;
    }
}