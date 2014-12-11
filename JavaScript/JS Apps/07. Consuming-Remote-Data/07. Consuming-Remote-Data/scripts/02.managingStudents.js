/// <reference path="jquery-2.0.2.js" />

var controller =  (function () {
    var $errorMessage, $successMessage, POSTstudent, GETstudents, DELETEstudent, resourceUrl;

	resourceUrl = 'http://localhost:3000/students/';

	$successMessage = $('.messages .success');

	$errorMessage = $('.messages .error');

	POSTstudent = function (data) {
		return $.ajax({
			url: resourceUrl,
			type: 'POST',
			data: JSON.stringify(data),
			contentType: 'application/json',
			success: function (data) {
				$successMessage
				  .html('' + data.name + ' successfully added')
				  .show()
				  .fadeOut(2000);
				GETstudents();
			},
			error: function () {
				$errorMessage
				  .html('Error happened.')
				  .show()
				  .fadeOut(2000);
			}
		});
	};

	GETstudents = function () {
		$.ajax({
			url: resourceUrl,
			type: 'GET',
			contentType: 'application/json',
			success: function (data) {
				var student, $studentsList, i, len;
				$studentsList = $('<ul/>').addClass('students-list');
				for (i = 0, len = data.students.length; i < len; i++) {
					student = data.students[i];
					$('<li />')
					  .addClass('student-item')
					  .append($('<strong /> ').html(student.name))
					  .append($('<span />').html(student.grade))
					  .append($('<a>').attr('href', '#').html('x').addClass('btn-delete').attr('data-id', student.id).on('click', function () {
					      $this = $(this);
					      $this.parent().html('');
					      DELETEstudent($this.attr('data-id'));
					  }))
					  .appendTo($studentsList);
				}
				$('#students-container').html($studentsList);
			},
			error: function () {
				$errorMessage
				  .html("Error happened.")
				  .show()
				  .fadeOut(2000);
			}
		});
	};

	DELETEstudent = function (id) {
		$.ajax({
			url: resourceUrl + id,
			type: 'POST',
			data: {
				_method: 'delete'
			},
			success: function (data) {
				$successMessage
				  .html('successfully deleted')
				  .show()
				  .fadeOut(2000);
				GETstudents();
			},
			error: function () {
				$errorMessage
				  .html('Error happened.')
				  .show()
				  .fadeOut(2000);
			}
		});
	}

	return {
	    POSTstudent: POSTstudent,
	    GETstudents: GETstudents,
	    DELETEstudent: DELETEstudent
	}

}());

