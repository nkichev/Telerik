window.onload = function () {
    document.getElementById('task').onclick = function () {
        if (document.getElementById('task').checked) {
            document.getElementById('task-text').style.display = 'block';
        } else {
            document.getElementById('task-text').style.display = 'none';
        }
    };
};