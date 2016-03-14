$('.submit').on('click', function () {
    var radios = $('input[type=radio]'), i;

    for (i = 0; i < radios.length; i++) {
        if (radios[i].checked) {
            $('#results').append(radios[i].value + '</br>');
            localStorage.setItem(radios[i].name, radios[i].value)
        }
    }
});
(function () {
    if (localStorage.getItem('age-range') ||
        localStorage.getItem('liveCity') ||
        localStorage.getItem('programmingLang')) {

    }
    for (i = 0; i < localStorage.length; i++) {
        console.log(radios.hasClass(localStorage.key(i)))

    }
})();