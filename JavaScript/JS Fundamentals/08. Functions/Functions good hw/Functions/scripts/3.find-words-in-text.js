function countRepeatingWordInText(text, word, isCaseSensitive) {
    var defaultText = 'There are only 10 types of people in the world:' +
        'Those who understand binary, and those who don’t.',
        defaultSearchedWord = 'those',
        wordCount;

    text = text || defaultText;
    word = word || defaultSearchedWord;
    isCaseSensitive = isCaseSensitive || false;

    if (isCaseSensitive === true) {
        word = new RegExp('\\b' + word + '\\b', 'g');
    } else {
        word = new RegExp('\\b' + word + '\\b', 'gi');
    }
    wordCount = text.match(word).length;
    return wordCount;
}

function printResult(text) {
    document.getElementById('result').innerText = text;
}

function execute() {
    var inputText = document.getElementById('input').value,
        wordToSearch = document.getElementById('word').value,
        isCaseSensitive,
        wordCount,
        resultToPrint;

    if (document.getElementById('search-type').checked) {
        isCaseSensitive = true;
    } else {
        isCaseSensitive = false;
    }

    wordCount = countRepeatingWordInText(inputText, wordToSearch, isCaseSensitive);

    resultToPrint = 'The word has been found ' + wordCount + ' times.'

    printResult(resultToPrint);
}