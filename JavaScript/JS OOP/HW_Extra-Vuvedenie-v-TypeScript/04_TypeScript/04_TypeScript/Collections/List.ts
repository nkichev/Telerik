module Collections {
    export class List<T> {
        private _collection: T[];

        constructor() {
            this._collection = [];
        }

        add(item: T): void {
            this._collection.push(item);
        }

        remove(): void {
            this._collection.pop();
        }

        get count() {
            return this._collection.length;
        }
    }
} 

var list = new Collections.List<Humans.Human>();
list.add(newStud);
console.log(list.count);
list.remove();
console.log(list.count);