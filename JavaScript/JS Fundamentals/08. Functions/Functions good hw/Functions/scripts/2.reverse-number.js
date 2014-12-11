function validateInput(argOne) {
    var isCorrect;
    if (isNaN(argOne)) {
        isCorrect = false;
    } else {
        isCorrect = true;
    }
    return isCorrect;
}

function printResult(text) {
    document.getElementById('result').innerText = text;
}

function reverseDigits(numberToReverse) {
    var reversedDigit = [],
        numberLength = numberToReverse.length;

    for (var i = 0; i < numberLength; i+=1) {
        reversedDigit.unshift(numberToReverse[i]);
    }
    if (parseFloat(numberToReverse) < 0) {
        reversedDigit.unshift('-');
    }
    return parseFloat(reversedDigit.join(''));
}

function execute() {
    var input = document.getElementById('input').value,
        reversedNumber,
        resultToPrint;

    reversedNumber = reverseDigits(input);
    if (validateInput(input)) {
        outputMesage = 'Reversed digit: ' + reversedNumber;
    } else {
        outputMesage = 'Wrong input. The data must be numeric!';
    }

    printResult(outputMesage);
}