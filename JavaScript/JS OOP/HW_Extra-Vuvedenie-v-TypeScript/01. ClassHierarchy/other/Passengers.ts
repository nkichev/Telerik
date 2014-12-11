module Vehicle {
    export class Passanger implements Interfaces.IPassenger {
        constructor(public name: string) {
        }

        sayJoke(): string {
            return 'Some joke';
        }
    }
} 