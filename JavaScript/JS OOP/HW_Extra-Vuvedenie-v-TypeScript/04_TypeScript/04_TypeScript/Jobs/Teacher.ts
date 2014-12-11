module Jobs {
    export class Teacher extends Job implements Interfaces.Jobs.IJob {
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
            return "I can calculate the results of the students.";
        }

        teach() {
            return "I'm teaching the students.";
        }

        examine() {
            return "I'm giving exams to the students.";
        }
    }
}  