function convertStringToNumberArray(arrayOfStrings) {
    var arrayOfNumbers = [],
        arrayLength = arrayOfStrings.length;

    for (var i = 0; i < arrayLength; i += 1) {
        arrayOfNumbers[i] = parseInt(arrayOfStrings[i]);
    }
    return arrayOfNumbers;
}

function validateInput(inputArray) {
    var isCorrect,
        inputArrayLength = inputArray.length;

    for (var i = 0; i < inputArrayLength; i += 1) {
        if (isNaN(inputArray[i])) {
            isCorrect = false;
        } else {
            isCorrect = true;
        }
    }
    return isCorrect;
}

function printResult(text) {
    document.getElementById('result').innerText = text;
}

function checkNeighbours(inputArray, index) {
    var arrayLength = inputArray.length,
        isBigger = false;

    if (inputArray[index] > inputArray[index - 1] &&
        inputArray[index] > inputArray[index + 1]) {
        isBigger = true;
    } else {
        isBigger = false;
    }
    return isBigger;
}

function returnIndexOfFirstBiggest(inputArray) {
    var arrLength = inputArray.length,
        indexOfFirstGreatest = -1;

    for (var i = 0; i < arrLength; i++) {
        if (checkNeighbours(inputArray, i)) {
            indexOfFirstGreatest = i;
            break;
        }
    }
    return indexOfFirstGreatest;
}

function execute() {
    var input = document.getElementById('numbers').value,
        inputAsArray = input.split(' '),
        inputAsArrayOfNumbers = [],
        indexOfFirstGreatest,
        resultStringToPrint;

    inputAsArrayOfNumbers = convertStringToNumberArray(inputAsArray);
    indexOfFirstGreatest = returnIndexOfFirstBiggest(inputAsArrayOfNumbers);

    if (validateInput) {
        if (indexOfFirstGreatest > 0) {
            resultStringToPrint = 'The index of the first number, biggest that its neighbours in ' +
            inputAsArrayOfNumbers + ' is ' + indexOfFirstGreatest + ' -> number ' +
            inputAsArrayOfNumbers[indexOfFirstGreatest];
        } else {
            resultStringToPrint = 'There is no element biggest than its neighbours in ' +
                inputAsArrayOfNumbers;
        }
    } else {
        resultStringToPrint = 'Wrong input. The data must be numeric.'
    }
    printResult(resultStringToPrint);
}