$('body').append('<ul>');
for (var i = 0; i < 5; i++) {
    $('ul').append('<li>');
}
$('li').each(function () {
    var currentItem = $(this);
    currentItem.append('SubMenu item ' + Number(currentItem.index() + 1))
});
$('ul').parent().prepend('<h1>');
$('h1').text('Menu Header');
$('ul').parent().append('<div>');
$('div').text('footer');