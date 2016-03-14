function startTimer(duration, display) {
    var timer = duration, minutes, seconds, radios;

    var timerID = setInterval(function () {
        minutes = parseInt(timer / 60, 10);
        seconds = parseInt(timer % 60, 10);

        minutes = minutes < 10 ? "0" + minutes : minutes;
        seconds = seconds < 10 ? "0" + seconds : seconds;

        display.text(minutes + ":" + seconds);

        radios = $('input[type=radio]');

        for (var i = 0; i < radios.length; i++) {
            if (radios[i].checked) {
                localStorage.setItem(radios[i].name, radios[i].value)
            }
        }
        if (--timer < 0) {
            clearInterval(timerID);
            $('input[type=radio]').attr('disabled', 'disabled');
            $('#counter').css('background', 'red');

        }
        $('.submit').on('click', function () {
            clearInterval(timerID);
            $('#counter').css('background', 'red');
            $('input[type=radio]').attr('disabled', 'disabled');

        });
    }, 1000);
}

$(function ($) {
    var fiveMinutes = 60 * 5,
        display = $('#counter');
    startTimer(fiveMinutes, display);
});
