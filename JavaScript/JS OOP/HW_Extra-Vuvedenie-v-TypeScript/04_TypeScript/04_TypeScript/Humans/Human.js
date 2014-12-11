var Humans;
(function (Humans) {
    var Human = (function () {
        function Human(firstName, lastName, age, gender, majority) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.majority = majority;
        }
        Human.prototype.greet = function () {
            return "Hello, I'm " + this.firstName + ".";
        };

        Human.prototype.goto = function () {
            return "I'm going to ";
        };
        return Human;
    })();
    Humans.Human = Human;
})(Humans || (Humans = {}));

var pesho = new Humans.Human("Pesho", "Peshov", 20, 0 /* Male */, 0 /* Major */);
var greeting = pesho.greet();
console.log(greeting);
console.log(pesho.goto());
//# sourceMappingURL=Human.js.map
