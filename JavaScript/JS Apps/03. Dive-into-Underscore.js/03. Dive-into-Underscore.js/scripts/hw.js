/// <reference path="underscore.js" />

if (typeof require !== 'undefined') {
    _ = require('./underscore.js');
}

//Task 1: Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
//Print the students in descending order by full name. Use Underscore.js

var Student = (function () {
    function Student(fname, lname, age, marks) {
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.marks = marks;
    }

    Student.prototype.fullName = function () {
        return this.fname + ' ' + this.lname;
    }

    Student.prototype.calculateMarks = function () {
        var sum = 0;
        for (var i = 0; i < this.marks.length; i++) {
            var currentMark = this.marks[i];
            sum += currentMark;
        }

        return sum;
    }

    return Student;
}());

var students = [
    new Student('Daniel', 'Filov', 14, [5, 6, 6, 6]),
    new Student('Alexander', 'Petrvo', 23, [5, 5, 6, 5]),
    new Student('Ivan', 'Samuilov', 18, [4, 4, 3, 5]),
    new Student('Stanimir', 'Ilarionov', 36, [3, 4, 5, 5]),
    new Student('Petko', 'Georgiev', 16, [3, 3, 4, 3])
];

function studentsFnameBeforeLname(array) {
    var newArr = _.filter(array, function (student) {
        return student.fname < student.lname;
    });

    return newArr;
}

var studentsWithFnameBeforeLname = studentsFnameBeforeLname(students);


_.chain(studentsWithFnameBeforeLname)
    .sortBy(function (student) {
        return student.fullName();
    }).each(function (student) {
        console.log(student);
    });

//Task 2: Write function that finds the first name and last name of all students with age between 18 and 24. Use Underscore.js

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

function studentsBtw18and24(array) {
    var newArr = _.filter(array, function (student) {
        return (18 <= student.age && student.age <= 24);
    });

    return newArr;
};

var studentsWithAgeBtw18and24 = studentsBtw18and24(students);
_.each(studentsWithAgeBtw18and24, function (student) {
    console.log(student);
});

//Task 3: Write a function that by a given array of students finds the student with highest marks

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

function studentsSortedByMarks(array) {
    _.chain(array)
    .sortBy(function (student) {
        return student.calculateMarks() * -1;
    }).each(function (student) {
        console.log(student);
    });
};

studentsSortedByMarks(students);


//Task 4: Write a function that by a given array of animals, groups them by species and sorts them by number of legs

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

var Animal = (function () {
    function Animal(species, legs) {
        this.species = species;
        this.legs = legs;
    }

    return Animal;
}());

var animals = [
    new Animal('cat', 4),
    new Animal('dog', 4),
    new Animal('dog', 4),
    new Animal('chicken', 2),
    new Animal('centipede', 100)
];

function groupBySpeciesAndSortByLegs(array) {
    _.chain(array).sortBy(function (animal) {
        return animal.legs * -1;
    }).groupBy('species').each(function (animal) {
        console.log(animal);
    });
};

groupBySpeciesAndSortByLegs(animals);


//Task 5: By a given array of animals, find the total number of legs
//Each animal can have 2, 4, 6, 8 or 100 legs

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

var sum = 0;

_.chain(animals).pluck('legs').each(function (numberOfLegs) {
    sum += numberOfLegs;
});

console.log(sum);


//Task 6: By a given collection of books, find the most popular author (the author with the highest number of books)

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

var Book = (function () {
    function Book(author) {
        this.author = author;
    }

    return Book;
}());

var books = [
    new Book('Ivan Vazov'),
    new Book('Hristo Botev'),
    new Book('Hristo Botev'),
    new Book('Hristo Smirnenski'),
    new Book('Hristo Botev')
];

var counts = {},
    maxCount = 0,
    maxAuthor = '';

_.each(books, function (book) {
    if (!counts[book.author]) {
        counts[book.author] = 0;
    }
    counts[book.author]++;
});

_.each(counts, function (count, author) {
    if (count > maxCount) {
        maxCount = count;
        maxAuthor = author;
    }
});

console.log(maxAuthor + ' => ' + maxCount + ' books');


//Task 7: By an array of people find the most common first and last name. Use underscore.

console.log('++++++++++++++++++++++++++++++++++++++++++++++');

var Person = (function () {
    function Person(fname, lname) {
        this.fname = fname;
        this.lname = lname;
    }

    return Person;
}());

var people = [
    new Person('Ivan', 'Dimitrov'),
    new Person('Ivan', 'Ivanov'),
    new Person('Ivan', 'Galinov'),
    new Person('Petar', 'Dimitrov'),
    new Person('Gosho', 'Panayotov'),
];

var fnameCounts = _.countBy(people, function (person) {
    return person.fname;
});

var indexOfMaxCount = _.max(fnameCounts);
fnameCounts = _.invert(fnameCounts);
console.log(fnameCounts[indexOfMaxCount] + ' ' + indexOfMaxCount + (indexOfMaxCount > 1 ? ' times' : ' time'));

var lnameCounts = _.countBy(people, function (person) {
    return person.lname;
});

indexOfMaxCount = _.max(lnameCounts);
lnameCounts = _.invert(lnameCounts);
console.log(lnameCounts[indexOfMaxCount] + ' ' + indexOfMaxCount + (indexOfMaxCount > 1 ? ' times' : ' time'));