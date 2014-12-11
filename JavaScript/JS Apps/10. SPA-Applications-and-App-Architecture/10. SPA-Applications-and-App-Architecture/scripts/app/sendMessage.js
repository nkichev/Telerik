define(["jquery", "requester"], function ($, requester) {
    var sendMessage = function (resourceUrl, data) {

        requester(resourceUrl, 'POST', data).then(function (data) {
            //reloadChat(resourceUrl);
            $('#tb-send').val('');
        });
    };

    return sendMessage;
});