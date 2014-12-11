module Cars {
    export class Hatchback extends Car implements Interfaces.Cars.ICar {
        model: string;
        year: number;

        constructor(model: string, year: number) {
            super(model, year);
        }

        start() {
            return super.start();
        }
        move() {
            return super.move() + " a hatchback is a pleasure.";
        }
        stop() {
            return super.stop();
        }
    }
} 

var hatchback = new Cars.Hatchback("Toyota", 2008);
console.log(hatchback.move());
console.log(hatchback.year);
