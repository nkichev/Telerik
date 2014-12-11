module Humans {
    export class Human implements Interfaces.Humans.IHuman {
        firstName: string;
        lastName: string;
        age: number;
        gender: Gender;
        majority: Majority;

        constructor(firstName: string, lastName: string, age: number, gender: Gender, majority: Majority) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.majority = majority;
        }

        greet() {
            return "Hello, I'm " + this.firstName + ".";
        }

        goto() {
            return "I'm going to ";
        }
    }
}

var pesho = new Humans.Human("Pesho", "Peshov", 20, Gender.Male, Majority.Major);
var greeting = pesho.greet();
console.log(greeting);
console.log(pesho.goto());