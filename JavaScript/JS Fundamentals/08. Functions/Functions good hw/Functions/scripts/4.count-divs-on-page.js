function printResult(text) {
    document.getElementById('result').innerText = text;
}

function getNumberOfTagsInPage(tag) {
    var numberOfTags;

    tag = tag || 'div';
    numberOfTags = document.getElementsByTagName(tag).length;
    return numberOfTags;
}

function execute() {
    var resultToPrint;

    resultToPrint = 'Div tags on this page: ' + getNumberOfTagsInPage();
    printResult(resultToPrint);
}