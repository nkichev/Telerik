define(['jquery', 'requester'], function ($, requester) {
    
    var reloadChat = function (resourceUrl) {

        requester(resourceUrl, 'GET').then(function (data) {
            var chatters = data.reverse();
            var chatlist = $('<ul/>').attr("id", "chat-list");
            for (var i = 0; i < chatters.length; i++) {
                $('<li />')
                .append($('<strong/>')
                .html(chatters[i].by))
                .append($('<br/>'))
                .append($('<span/>')
                .html(chatters[i].text))
                .appendTo(chatlist);
            };

            $('#chat-div').html(chatlist);
        });
    };

    return reloadChat;
});