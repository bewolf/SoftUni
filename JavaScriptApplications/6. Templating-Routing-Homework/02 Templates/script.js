(function () {
    var APP_ID = 'Basic bWF0c292Om1hdHNvdg==',
        baseUrl = 'https://baas.kinvey.com/appdata/kid_bJgPi-X6Cx/';

    requestTemplates();

    function requestTemplates() {
        $.ajax({
            method: 'GET',
            headers: {
                "Authorization": APP_ID
            },
            url: baseUrl + 'Templates',
            success: function (data) {
                showTemplatesHTML(data);
            },
            error: errorMessage
        });
    }

    function showTemplatesHTML(data) {
        $.get('template.html', function (templ) {
            var input = {
                'users': data
            }
            var outp = Mustache.render(templ, input);
            $('#users').html(outp);
        })
    }

    function errorMessage() {
        return $('<div class="errorMessage">' + 'Cannot load data.' + '</div>');
    }
})();