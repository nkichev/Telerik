module Jobs {
    export class ITSpecialist extends Job implements Interfaces.Jobs.IJob {
        salary: number;
        holidayDays: number;
        isDangerous: boolean;

        constructor(salary: number, holidayDays: number, isDangerous: boolean) {
            super(salary, holidayDays, isDangerous);
        }

        driveCar(canDrive: boolean) {
            return super.driveCar(canDrive);
        }

        code() {
            return "I'm coding";
        }
    }
} 