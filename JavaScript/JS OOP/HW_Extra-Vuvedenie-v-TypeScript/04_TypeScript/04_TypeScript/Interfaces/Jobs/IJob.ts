module Interfaces.Jobs {
    export interface IJob {
        salary: number;
        holidayDays: number;
        isDangerous: boolean;
        driveCar(canDrive): boolean;
    }
}