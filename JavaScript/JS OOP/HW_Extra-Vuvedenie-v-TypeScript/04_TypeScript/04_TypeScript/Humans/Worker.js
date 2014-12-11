var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Humans;
(function (Humans) {
    var Worker = (function (_super) {
        __extends(Worker, _super);
        function Worker(firstName, lastName, age, gender, majority) {
            _super.call(this, firstName, lastName, age, gender, majority);
        }
        Worker.prototype.greet = function () {
            return _super.prototype.greet.call(this) + " I'm a worker.";
        };

        Worker.prototype.goto = function () {
            return _super.prototype.goto.call(this) + "work.";
        };
        return Worker;
    })(Humans.Human);
    Humans.Worker = Worker;
})(Humans || (Humans = {}));

var newWorker = new Humans.Worker("Pesho", "Petrov", 20, 0 /* Male */, 0 /* Major */);
console.log(newWorker.greet());
console.log(newWorker.goto());
//# sourceMappingURL=Worker.js.map
