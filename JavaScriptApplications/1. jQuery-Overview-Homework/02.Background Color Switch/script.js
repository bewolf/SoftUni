$('body').append('<label>Class: </label>');
$('label').append('<input type="text">');
$('input').attr('id', 'input');

$('body').append('<br/><label>Color: </label>');
$('label:contains("Color")').append('<input type="color"> <br/>');
$('input[type="color"]').attr('id', 'selected-color');

$('body').append('<button>Paint</button>');
$('button')
    .on('click', function () {
        var color = $('#selected-color').val();
        var selectedClass = $('input').val();

        if ($('li').hasClass(selectedClass)) {
            $('.' + selectedClass).css('background', color);
        } else {
            $('body').append('<div>');
            $('div').removeData();
            $('div').append('There is no such class: ' + selectedClass);
        }
    });