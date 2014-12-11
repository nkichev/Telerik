var Collections;
(function (Collections) {
    var List = (function () {
        function List() {
            this._collection = [];
        }
        List.prototype.add = function (item) {
            this._collection.push(item);
        };

        List.prototype.remove = function () {
            this._collection.pop();
        };

        Object.defineProperty(List.prototype, "count", {
            get: function () {
                return this._collection.length;
            },
            enumerable: true,
            configurable: true
        });
        return List;
    })();
    Collections.List = List;
})(Collections || (Collections = {}));

var list = new Collections.List();
list.add(newStud);
console.log(list.count);
list.remove();
console.log(list.count);
//# sourceMappingURL=List.js.map
