module Jobs {
    export class Chemist extends Job implements Interfaces.Jobs.IJob {
        salary: number;
        holidayDays: number;
        isDangerous: boolean;

        constructor(salary: number, holidayDays: number, isDangerous: boolean) {
            super(salary, holidayDays, isDangerous);
        }

        driveCar(canDrive: boolean) {
            return super.driveCar(canDrive);
        }

        calculate() {
            return "I can calculate the assay of the active substance in this material.";
        }

        identify() {
            return "I can identify the active substance in this material.";
        }
    }
} 