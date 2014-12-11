function convertStringToNumberArray(arrayOfStrings) {
    var arrayOfNumbers = [],
        arrayLength = arrayOfStrings.length;

    for (var i = 0; i < arrayLength; i += 1) {
        arrayOfNumbers[i] = parseInt(arrayOfStrings[i]);
    }
    return arrayOfNumbers;
}

function validateInput(inputArray, searchedValue) {
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

function countNumberOccurrancies(array, number) {
    var arrayLength = array.length,
        countOccurrances = 0;

    for (var i = 0; i < arrayLength; i += 1) {
        if (array[i] === number) {
            countOccurrances += 1;
        }
    }
    return countOccurrances;
}

function execute() {
    var input = document.getElementById('numbers').value,
        searchedValue = parseInt(document.getElementById('searched-value').value),
        inputAsArray = input.split(' '),
        inputAsArrayOfNumbers = [],
        occurrancies,
        resultStringToPrint;

    inputAsArrayOfNumbers = convertStringToNumberArray(inputAsArray);
    occurrancies = countNumberOccurrancies(inputAsArrayOfNumbers, searchedValue);

    if (validateInput(inputAsArrayOfNumbers)) {
        if (occurrancies !== 0) {
            resultStringToPrint = 'Number "' + searchedValue +
            '" was found ' + occurrancies + ' times.';
        } else {
            resultStringToPrint = 'The number "' + searchedValue +
                '" has not been found.';
        }
    } else {
        resultStringToPrint = 'Wrong input. The data must be numeric.';
    }

    printResult(resultStringToPrint);
}