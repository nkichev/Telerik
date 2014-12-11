function convertStringToNumberArray(arrayOfStrings) {
    var arrayOfNumbers = [],
        arrayLength = arrayOfStrings.length;

    for (var i = 0; i < arrayLength; i += 1) {
        arrayOfNumbers[i] = parseInt(arrayOfStrings[i]);
    }
    return arrayOfNumbers;
}

function validateInput(inputArray, searchedIndex) {
    var isCorrect,
        inputArrayLength = inputArray.length;

    for (var i = 0; i < inputArrayLength; i += 1) {
        if (isNaN(inputArray[i])) {
            isCorrect = false;
        } else {
            isCorrect = true;
        }
    }
    if (isNaN(searchedIndex) || searchedIndex < 0 ||
        searchedIndex >= inputArrayLength) {
        isCorrect = false;
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

function execute() {
    var input = document.getElementById('numbers').value,
        searchedIndex = parseInt(document.getElementById('searched-value').value),
        inputAsArray = input.split(' '),
        inputAsArrayOfNumbers = [],
        resultStringToPrint;

    inputAsArrayOfNumbers = convertStringToNumberArray(inputAsArray);

    if (validateInput(inputAsArrayOfNumbers, searchedIndex)) {
        if (searchedIndex === 0 || searchedIndex === inputAsArrayOfNumbers.length - 1) {
            resultStringToPrint = 'The element of index ' + searchedIndex +
                ' has only one neighbour.';
        } else {
            if (checkNeighbours(inputAsArrayOfNumbers, searchedIndex)) {
                resultStringToPrint = 'The number ' +
                    inputAsArrayOfNumbers[searchedIndex] + ' at inxex ' +
                    searchedIndex + ' is bigger than it\'s neighnours ' +
                    inputAsArrayOfNumbers[searchedIndex + 1] + ' and ' +
                    inputAsArrayOfNumbers[searchedIndex - 1];
            } else {
                resultStringToPrint = 'The number ' +
                    inputAsArrayOfNumbers[searchedIndex] + ' at inxex ' +
                    searchedIndex + ' is NOT bigger than it\'s neighnours ' +
                    inputAsArrayOfNumbers[searchedIndex + 1] + ' and ' +
                    inputAsArrayOfNumbers[searchedIndex - 1];
            }
        }
    } else {
        resultStringToPrint = 'Wrong input.';
    }

    printResult(resultStringToPrint);
}