define(['sendMessage'], function (sendMessage) {

    var correctUrl = 'http://crowd-chat.herokuapp.com/posts';
    var inccorectUrl = 'http://crowd-chat.herokuapp.com/postsqweqweqweqwe';

    describe("#sendMessage", function () {
        it("Test for sending a message", function (done) {
            //messagesModule.sendMessage("Pesho", "Pesho", function (data, statusText, xhr) {
            //    var expectedData = true;
            //    var expectedTextStatus = 'success';
            //    var expectedStatus = 2;
            //    expect(statusText).to.be.deep.equal(expectedTextStatus);
            //    var returnedStatus = (xhr.status / 100) | 0;
            //    expect(returnedStatus).to.deep.equal(expectedStatus);
            //    expect(expectedData).to.be.deep.equal(data);
            //    done(null, done);
            //},
            //function (error) {
            //});

        })
    });
});