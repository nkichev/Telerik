module Cars {
    export class Combi extends Car implements Interfaces.Cars.ICar {
        model: string;
        year: number;

        constructor(model: string, year: number) {
            super(model, year);
        }

        start() {
            return super.start();
        }
        move() {
            return super.move() + " a combi is a pleasure.";
        }
        stop() {
            return super.stop();
        }
    }
}

var combi = new Cars.Combi("Wolkswagen", 2008);
console.log(combi.move());
console.log(combi.year);
 