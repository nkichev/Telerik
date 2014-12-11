var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Cars;
(function (Cars) {
    var Combi = (function (_super) {
        __extends(Combi, _super);
        function Combi(model, year) {
            _super.call(this, model, year);
        }
        Combi.prototype.start = function () {
            return _super.prototype.start.call(this);
        };
        Combi.prototype.move = function () {
            return _super.prototype.move.call(this) + " a combi is a pleasure.";
        };
        Combi.prototype.stop = function () {
            return _super.prototype.stop.call(this);
        };
        return Combi;
    })(Cars.Car);
    Cars.Combi = Combi;
})(Cars || (Cars = {}));

var combi = new Cars.Combi("Wolkswagen", 2008);
console.log(combi.move());
console.log(combi.year);
//# sourceMappingURL=Combi.js.map
