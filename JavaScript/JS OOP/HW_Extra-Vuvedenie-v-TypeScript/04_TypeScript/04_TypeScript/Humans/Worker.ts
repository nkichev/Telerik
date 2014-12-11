module Humans {
    export class Worker extends Human implements Interfaces.Humans.IHuman {
        firstName: string;
        lastName: string;
        age: number;
        gender: Gender;
        majority: Majority;

        constructor(firstName: string, lastName: string, age: number, gender: Gender, majority: Majority) {
            super(firstName, lastName, age, gender, majority);
        }

        greet() {
            return super.greet() + " I'm a worker.";
        }

        goto() {
            return super.goto() + "work.";
        }
    }
}

var newWorker = new Humans.Worker("Pesho", "Petrov", 20, Gender.Male, Majority.Major);
console.log(newWorker.greet());
console.log(newWorker.goto());