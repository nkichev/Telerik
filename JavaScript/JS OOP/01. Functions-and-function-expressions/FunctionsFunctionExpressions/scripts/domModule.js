var domModule = (function () {
    var buffer = [];
    var MAX_BUFFER_SIZE = 100;

    var appendChild = function appendChild(elementToAppend, whereToAppend) {
        document.querySelector(whereToAppend).appendChild(elementToAppend);
    }

    var removeChild = function removeChild(from, elementToRemove) {
        document.querySelector(from).removeChild(document.querySelector(elementToRemove));
    }

    var addHandler = function addHandler(selector, eventType, eventHandler) {
        var elements = getElements(selector);
        for (var i = 0; len = elements.length, i < len; i++) {
            elements[i].addEventListener(eventType, eventHandler);
        }
    }

    var getElements = function getElements(selector) {
        return document.querySelectorAll(selector);
    }

    var appendToBuffer = function appendToBuffer(selector, element) {
        if (buffer[selector]) {
            buffer[selector].push(element);
            if (buffer[selector].length === MAX_BUFFER_SIZE) {
                var parent = document.querySelector(selector);
                for (var i = 0; i < buffer[selector].length; i++) {
                    parent.appendChild(buffer[selector][i]);
                }
                buffer[selector] = [];
            }
        } else {
            buffer[selector] = [];
            buffer[selector].push(element);
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        getElements: getElements,
        appendToBuffer: appendToBuffer
    };
})();