var Jobs;
(function (Jobs) {
    var Job = (function () {
        function Job(salary, holidayDays, isDangerous) {
            this.salary = salary;
            this.holidayDays = holidayDays;
            this.isDangerous = isDangerous;
        }
        Job.prototype.driveCar = function (canDrive) {
            return canDrive;
        };
        return Job;
    })();
    Jobs.Job = Job;
})(Jobs || (Jobs = {}));
//# sourceMappingURL=Job.js.map
