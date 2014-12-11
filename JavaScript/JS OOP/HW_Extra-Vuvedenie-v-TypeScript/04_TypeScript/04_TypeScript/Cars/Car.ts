module Cars {
    export class Car implements Interfaces.Cars.ICar {
        model: string;
        year: number;
        static numberOfDoors: number;

        constructor(model: string, year: number) {
            this.model = model;
            this.year = year;
        }

        start() {
            return "Drive off ... Brrrrm";
        }
        move() {
            return "Driving ...";
        }
        stop() {
            return "Arrived";
        }
    }
}

var myCar = new Cars.Car("Toyota", 2002);
console.log(myCar.start());
console.log(myCar.move());
console.log(myCar.stop());
