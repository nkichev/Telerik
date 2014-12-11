module Humans {
    export class Student extends Human implements Interfaces.Humans.IHuman {
        firstName: string;
        lastName: string;
        age: number;
        gender: Gender;
        majority: Majority;

        constructor(firstName: string, lastName: string, age: number, gender: Gender, majority: Majority) {
            super(firstName, lastName, age, gender, majority);
        }

        greet() {
            return super.greet() + " I'm a student.";
        }

        goto() {
            return super.goto() + "school.";
        }
    }
}

var newStud = new Humans.Student("Pesho", "Petrov", 20, Gender.Male, Majority.Major);
console.log(newStud.greet());
console.log(newStud.goto());