var existInput = document.getElementById('exist-input'),
    matchInput = document.getElementById('match-input'),
    checkBtn = document.getElementById('check'),
    saveBtn = document.getElementById('save'),
    loadBtn = document.getElementById('load'),
    theNumberInput = document.getElementById('the-number-input'),
    endGameText = document.getElementById('end-game-text'),
    table = document.getElementById('table'),
    max = 9999,
    min = 1000,
    tries = 0,
    theNumber,
    playerNumber;

theNumber = Math.floor(Math.random() * (max - min + 1)) + min;
checkBtn.addEventListener('click', onBtnCheckClick, false);
loadBtn.addEventListener('click', onBtnLoadClick, false);

function onBtnCheckClick() {
    var existCount = 0,
        matchCount = 0;

    playerNumber = document.getElementById('second-container-input').value;
    if (playerNumber < 1000 || playerNumber > 9999) {
        endGameText.innerHTML = 'You have to enter 4 digit number.';
    } else {
        endGameText.innerHTML = '';
        tries++;
        if (tries === 35) {
            endGameText.innerHTML = "Sorry, you couldn't do it!";
            theNumberInput.value = theNumber;
            checkBtn.removeEventListener('click', onBtnCheckClick, false);
        }

        checkForMatches();
        checkForMatches();

        existInput.value = existCount;
        matchInput.value = matchCount;

        function checkForMatches() {
            for (var i = 0; i < 4; i++) {
                var theNumberCurrentDigit = theNumber.toString()[i],
					playerNumberCurrentDigit = playerNumber.toString()[i];
                if (theNumberCurrentDigit === playerNumberCurrentDigit) {
                    matchCount++;
                    if (matchCount === 4) {
                        theNumberInput.value = theNumber;
                        saveBtn.addEventListener('click', onBtnSaveClick, false);
                        endGameText.innerHTML = 'Congratulations!\n' + 'You did it with ' + tries + (tries > 1 ? ' tries.' : ' try.');
                    }
                }
            }
        };
        function checkForExists() {
            var theNumberAsStr = theNumber.toString(),
            playerNumberAsStr = playerNumber.toString();
            for (i = 0; i < 4; i++) {
                for (var j = 0; j < 4; j++) {
                    if (theNumberAsStr[i] === playerNumberAsStr[j]) {
                        playerNumberAsStr = playerNumberAsStr.replaceAt(j, 'x');
                        existCount++;
                        break;
                    }
                }
            }
        }
    }
};
function onBtnSaveClick() {
    var name = document.getElementById('name-input').value;
    localStorage.setItem(name, tries);
}
function onBtnLoadClick() {
    table.innerHTML = '';
    table.style.display = 'inline-block';

    table.innerHTML += '<li>' + 'Scores:' + '</li>';
    for (var i = 0; i < localStorage.length; i++) {
        var key = localStorage.key(i),
            value = localStorage.getItem(key);

        table.innerHTML += '<li>' + key + ' : ' + value + '</li>';
    }

    setTimeout(function () {
        table.style.display = 'none';
    }, 4000);
}

String.prototype.replaceAt = function (index, character) {
    return this.substr(0, index) + character + this.substr(index + character.length);
}





