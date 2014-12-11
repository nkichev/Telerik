var specialConsole = (function () {

    function formatPlaceHolders(input) {
        var stringToFormat = input[0];
        for (var i = 0; i < input.length - 1; i++) {
            while (stringToFormat.indexOf('{' + i + '}') !== -1) {
                stringToFormat = stringToFormat.replace('{' + i + '}', input[i + 1]);
            }
        }

        return stringToFormat;
    }

    function writeLine(msg, placeHolders) {
        if (arguments.length === 1) {
            console.log(msg.toString());
        } else {
            var formattedMsg = formatPlaceHolders(arguments);
            console.log(formattedMsg);
        }
    }

    function writeError(msg, placeHolders) {
        if (arguments.length === 1) {
            console.error(msg.toString());
        } else {
            var formattedError = formatPlaceHolders(arguments);
            console.error(formattedError);
        }
    }

    function writeWarning(msg, placeHolders) {
        if (arguments.length === 1) {
            console.warn(msg.toString());
        } else {
            var formattedWarning = formatPlaceHolders(arguments);
            console.warn(formattedWarning);
        }
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
})();