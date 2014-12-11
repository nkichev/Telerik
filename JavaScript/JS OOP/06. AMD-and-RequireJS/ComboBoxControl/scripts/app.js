/// <reference path="libs/jquery-1.11.1.min.js" />
/// <reference path="libs/require.js" />

require(['controls', 'libs/jquery-1.11.1.min'], function (controls) {
    var people = [
        { id: 1, name: "Doncho Minkov", age: 25, avatarUrl: "images/doncho.jpg" },
        { id: 2, name: "Nikolay Kostov", age: 24, avatarUrl: "images/niki.jpg" },
        { id: 3, name: "Ivaylo Kenov", age: 22, avatarUrl: "images/ivo.jpg" },
        { id: 4, name: "Todor Stoyqnov", age: 26, avatarUrl: "images/todor.jpg" }];

    var comboBox = controls.ComboBox(people);
    var template = $("#person-template").html();
    var comboBoxHtml = comboBox.render(template);
    var container = document.getElementById('container');
    container.innerHTML = comboBoxHtml;
});