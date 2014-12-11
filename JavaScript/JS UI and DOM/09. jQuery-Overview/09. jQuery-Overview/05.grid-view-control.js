(function () {
    var table = $('<table/>').css({ borderCollapse: 'collapse' });
    var rows;
    var cols;
    var cwidth = 100;
    var cheight = 25;
    var headerColor = '#3366CC';
    $(document).ready(function () {
        $('#creatTableButton').on('click', createTable);
    });

    function createTable() {
        table.html('');

        rows = $('#row-count').val();
        cols = $('#col-count').val();

        table.append(createHeader(cols));
        for (var i = 0; i < rows; i++) {
            createRow().appendTo(table);
        }
        table.appendTo($('section'));
    }

    function createRow() {
        var $row = $('<tr/>');
        for (var j = 0; j < cols; j++) {
            createCol('td', cwidth, cheight, '#fff', 15).appendTo($row);
        }
        addRowButtons($row);
        return $row;
    }

    function createHeader(cols) {
        var $row = $('<tr/>');
        for (var j = 0; j < cols; j++) {
            createCol('th', cwidth, cheight, headerColor, 25).appendTo($row);
        }
        $row.append($('<th/>').css({ width: 60, background: headerColor, border: '1px solid #000' }))
        return $row;
    }

    function createCol(colType, colWidth, colHeight, colBackgroud, textFontSize) {
        var $col = $('<' + colType + '/>').css({ width: colWidth, height: colHeight, border: '1px solid #000', background: colBackgroud });
        var input = $('<input/>').css({
            width: colWidth,
            height: colHeight,
            border: 'none',
            padding: 10,
            background: colBackgroud,
            fontSize: textFontSize,
            textAlign: 'center',
            color: '#000'
        });
        input.attr('disabled', 'disabled').appendTo($col);

        $col.on('click', function () {
            $currCol = $(this);
            $currCol.children().css({ background: '#defeff' });
            $currCol.children().removeAttr('disabled');

            $currCol.children().on('mouseleave', function () {
                var $currInput = $(this);
                $currInput.attr('disabled', 'disabled');
                $currInput.css({ background: colBackgroud });
            })
        });
        return $col;
    }

    function addRowButtons(row) {
        var $addButton = $('<img/>').attr({ 'src': 'images/add.png' });
        setStyleToButton($addButton);
        
        $addButton.on('click', function () {
            $currButton = $(this);
            $parentRow = $currButton.parent().parent();
            $parentRow.after(createRow());
        })

        var $removeButton = $('<img/>').attr({ 'src': 'images/delete.png' });
        setStyleToButton($removeButton);

        $removeButton.on('click', function () {
            $currButton = $(this);
            $parentRow = $currButton.parent().parent();
            $parentRow.remove();
        });

        $('<td/>').css({ border: '1px solid #000', width: 60 }).append($addButton).append($removeButton).appendTo(row);
    }

    function setStyleToButton(button) {
        button.css({
            width: 20,
            padding: 5,
            cursor: 'pointer',
        });
    }
}());