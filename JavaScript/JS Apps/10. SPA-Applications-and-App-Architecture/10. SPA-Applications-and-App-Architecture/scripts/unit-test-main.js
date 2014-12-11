(function () {

    require.config({
        paths: {
            mocha: 'libs/mocha',
            chai: 'libs/chai',
            q: 'libs/q',
            jquery: 'libs/jquery-2.1.1.min',
            sammy: "libs/sammy-latest.min",
            reloadChat: "app/reloadChat",
            sendMessage: "app/sendMessage",
            controller: "app/controller",
            requester: "app/requester"
        }
    });

    require(['chai', 'mocha'], function (chai, mocha) {
        mocha.setup('bdd');
        expect = chai.expect;
        require(['tests/messages-module-test'], function () {
            mocha.run();
        });
    });

}());