var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Jobs;
(function (Jobs) {
    var ITSpecialist = (function (_super) {
        __extends(ITSpecialist, _super);
        function ITSpecialist(salary, holidayDays, isDangerous) {
            _super.call(this, salary, holidayDays, isDangerous);
        }
        ITSpecialist.prototype.driveCar = function (canDrive) {
            return _super.prototype.driveCar.call(this, canDrive);
        };

        ITSpecialist.prototype.code = function () {
            return "I'm coding";
        };
        return ITSpecialist;
    })(Jobs.Job);
    Jobs.ITSpecialist = ITSpecialist;
})(Jobs || (Jobs = {}));
//# sourceMappingURL=ITSpecialist.js.map
