function getEnglishNameOfDigit(digit) {
    var nameOfDigit;
    //There is no tab before the "case" statement because of jslint
    switch (Math.abs(digit)) {
        case 0:
            nameOfDigit = 'zero';
            break;
        case 1:
            nameOfDigit = 'one';
            break;
        case 2:
            nameOfDigit = 'two';
            break;
        case 3:
            nameOfDigit = 'three';
            break;
        case 4:
            nameOfDigit = 'four';
            break;
        case 5:
            nameOfDigit = 'five';
            break;
        case 6:
            nameOfDigit = 'six';
            break;
        case 7:
            nameOfDigit = 'seven';
            break;
        case 8:
            nameOfDigit = 'eight';
            break;
        case 9:
            nameOfDigit = 'nine';
            break;
        default:
            nameOfDigit = 'Well this is embarrassing. I don\'t know how you endet up here';
            break;
    }
    return nameOfDigit;
}

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

function execute() {
    var inputNumber = Number(document.getElementById('input').value),
        lastDigit = inputNumber % 10,
    outputMesage;

    if (validateInput(inputNumber)) {
        outputMesage = 'Name of the digit: ' + getEnglishNameOfDigit(lastDigit);
    } else {
        outputMesage = 'Wrong input. The data must be numeric!';
    }

    printResult(outputMesage);
}