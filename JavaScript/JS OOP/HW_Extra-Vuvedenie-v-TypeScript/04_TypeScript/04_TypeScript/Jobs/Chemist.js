var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Jobs;
(function (Jobs) {
    var Chemist = (function (_super) {
        __extends(Chemist, _super);
        function Chemist(salary, holidayDays, isDangerous) {
            _super.call(this, salary, holidayDays, isDangerous);
        }
        Chemist.prototype.driveCar = function (canDrive) {
            return _super.prototype.driveCar.call(this, canDrive);
        };

        Chemist.prototype.calculate = function () {
            return "I can calculate the assay of the active substance in this material.";
        };

        Chemist.prototype.identify = function () {
            return "I can identify the active substance in this material.";
        };
        return Chemist;
    })(Jobs.Job);
    Jobs.Chemist = Chemist;
})(Jobs || (Jobs = {}));
//# sourceMappingURL=Chemist.js.map
