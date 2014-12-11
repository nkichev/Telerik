var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Humans;
(function (Humans) {
    var Student = (function (_super) {
        __extends(Student, _super);
        function Student(firstName, lastName, age, gender, majority) {
            _super.call(this, firstName, lastName, age, gender, majority);
        }
        Student.prototype.greet = function () {
            return _super.prototype.greet.call(this) + " I'm a student.";
        };

        Student.prototype.goto = function () {
            return _super.prototype.goto.call(this) + "school.";
        };
        return Student;
    })(Humans.Human);
    Humans.Student = Student;
})(Humans || (Humans = {}));

var newStud = new Humans.Student("Pesho", "Petrov", 20, 0 /* Male */, 0 /* Major */);
console.log(newStud.greet());
console.log(newStud.goto());
//# sourceMappingURL=Student.js.map
