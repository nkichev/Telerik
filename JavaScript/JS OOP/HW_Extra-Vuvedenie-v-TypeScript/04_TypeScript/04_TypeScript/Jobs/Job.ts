module Jobs {
    export class Job implements Interfaces.Jobs.IJob {
        salary: number;
        holidayDays: number;
        isDangerous: boolean;

        constructor(salary: number, holidayDays: number, isDangerous: boolean) {
            this.salary = salary;
            this.holidayDays = holidayDays;
            this.isDangerous = isDangerous;
        }

        driveCar(canDrive: boolean): boolean {
            return canDrive;
        }
    }
}
 