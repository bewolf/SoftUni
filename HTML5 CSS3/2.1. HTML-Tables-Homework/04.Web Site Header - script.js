$('.sub-menu').hide();

$("ul:has(li)").click(function () {

    $("ul", this).toggle('slow');
});