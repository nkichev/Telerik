window.onload = function onload() {
    'use strict';
    var tasks = [
        {
            title: 'Task 1',
            condition: 'Create a module for drawing shapes using Canvas.\n' +
                ' Implement the following shapes:\n' +
                ' Rect, by given position (X, Y) and size (Width, Height)\n' +
                ' Circle, by given center position (X, Y) and radius (R)\n' +
                ' Line, by given from (X1, Y1) and to (X2, Y2) positions\n',
            solution: 'html/01.DrawingShaps.html'
        }
    ];

    var $right = $('#right'),
        $left = $('#left'),
        dfrag = $(document.createDocumentFragment()),
        $task = $(document.createElement('div')),
        $taskTitle = $(document.createElement('h2')),
        $taskSubTitle = $(document.createElement('h6')),
        $taskCond = $(document.createElement('p')),
        $taskSolutionLink = $(document.createElement('a')),
        i,
        $currentTask,
        $currentTitle,
        $currentCond,
        $currentLink;

    $right.css('float', 'right');
    $left.css('float', 'left');
    $task.addClass('task');
    $taskCond.css('display', 'none');
    $taskSubTitle.html('Condition');
    $taskTitle.append($taskSubTitle);
    $taskSubTitle.css('color', '#808080');
    $taskSolutionLink.html('Go To Solution');
    $taskSolutionLink.css('display', 'none');

    for (i = 0; i < tasks.length; i++) {
        $currentTask = $task.clone(true);
        $currentTitle = $taskTitle.clone(true);
        $currentTitle.prepend(tasks[i].title);

        $currentCond = $taskCond.clone(true);
        $currentCond.append(tasks[i].condition);

        $currentLink = $taskSolutionLink.clone(true);
        $currentLink.attr('href', tasks[i].solution);

        $currentTask.append($currentTitle);
        $currentTask.append($currentCond);
        $currentTask.append($currentLink);

        dfrag.append($currentTask);
    }

    $right.append(dfrag);

    $right.on('click', '.task', function clicked() {
        var $this = $(this),
            childrenInLeft = $left.find('.children'),
        $thisCondition,
            $thisLink,
            $conditionToAppend,
            $linkToAppend;

        childrenInLeft.remove();

        console.log($this);
         $thisCondition = $this.find('p');
         $thisLink = $this.find('a');

        $($right.find('.current')).removeClass('current');
        $this.addClass('current');

         $conditionToAppend = $thisCondition.clone(true);
        $conditionToAppend.css('display', '');
        $conditionToAppend.addClass('children');
        $left.append($conditionToAppend);

         $linkToAppend = $thisLink.clone(true);
        $linkToAppend.css('display', '');
        $linkToAppend.addClass('children');
        $left.append($linkToAppend);
    });

};
