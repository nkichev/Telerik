var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Cars;
(function (Cars) {
    var Hatchback = (function (_super) {
        __extends(Hatchback, _super);
        function Hatchback(model, year) {
            _super.call(this, model, year);
        }
        Hatchback.prototype.start = function () {
            return _super.prototype.start.call(this);
        };
        Hatchback.prototype.move = function () {
            return _super.prototype.move.call(this) + " a hatchback is a pleasure.";
        };
        Hatchback.prototype.stop = function () {
            return _super.prototype.stop.call(this);
        };
        return Hatchback;
    })(Cars.Car);
    Cars.Hatchback = Hatchback;
})(Cars || (Cars = {}));

var hatchback = new Cars.Hatchback("Toyota", 2008);
console.log(hatchback.move());
console.log(hatchback.year);
//# sourceMappingURL=Hatchback.js.map
