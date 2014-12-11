module Interfaces.Humans {
    export interface IHuman {
        firstName: string;
        lastName: string;
        age?: number;
        gender?: Gender;
        majority: Majority;
        greet(): void;
        goto(): void;
    }
}

enum Gender { Male, Female }

enum Majority { Major, Minor }