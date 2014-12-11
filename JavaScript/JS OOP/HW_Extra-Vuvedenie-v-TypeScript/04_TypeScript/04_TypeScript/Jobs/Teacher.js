var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Jobs;
(function (Jobs) {
    var Teacher = (function (_super) {
        __extends(Teacher, _super);
        function Teacher(salary, holidayDays, isDangerous) {
            _super.call(this, salary, holidayDays, isDangerous);
        }
        Teacher.prototype.driveCar = function (canDrive) {
            return _super.prototype.driveCar.call(this, canDrive);
        };

        Teacher.prototype.calculate = function () {
            return "I can calculate the results of the students.";
        };

        Teacher.prototype.teach = function () {
            return "I'm teaching the students.";
        };

        Teacher.prototype.examine = function () {
            return "I'm giving exams to the students.";
        };
        return Teacher;
    })(Jobs.Job);
    Jobs.Teacher = Teacher;
})(Jobs || (Jobs = {}));
//# sourceMappingURL=Teacher.js.map
