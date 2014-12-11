/// <reference path="libs/require.js" />
/// <reference path="libs/sammy-0.7.4.js" />
/// <reference path="libs/jquery-2.0.3.js" />

(function () {

    require.config({
        paths: {
            Q: 'libs/q',
            jquery: "libs/jquery-2.1.1.min",
            sammy: "libs/sammy-latest.min",
            reloadChat: "app/reloadChat",
            sendMessage: "app/sendMessage",
            controller: "app/controller",
            requester: "app/requester"
        }
    })

    require(["jquery", "controller"], function ($, controller) {
        var resourceUrl = 'http://crowd-chat.herokuapp.com/posts';

        var app = controller("#main-content", resourceUrl);

        app.run("#/home");
    });
}());