define(['jquery', 'Q'], function ($, Q) {
    var requester = function (resourceUrl, type, data) {
        var deferred = Q.defer();

        $.ajax({
            url: resourceUrl,
            type: type,
            data: JSON.stringify(data) || {},
            contentType: 'application/json',
            accept: 'application/json',
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.reject(error);
            }
        });

        return deferred.promise;
    };

    return requester;
});