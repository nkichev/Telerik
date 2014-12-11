function getValueFromInput() {
    var input = document.getElementsByTagName('input')[0];

    if (input.type === 'text') {
        var value = input.value;
        console.log(value);
    }
}

getValueFromInput();