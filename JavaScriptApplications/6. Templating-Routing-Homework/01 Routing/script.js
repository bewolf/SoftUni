var app = app || {};

(function () {
    app.router = Sammy(function () {
        var selector = '#wrapper';
        this.get('#/', function () {
            $(selector).html('Select name')
        })

        this.get('#/Pesho', function () {
            $(selector).html('Hello Pesho');
        });

        this.get('#/Gosho', function () {
            $(selector).html('Hello Gosho');
        });

        this.get('#/Minka', function () {
            $(selector).html('Hello Minka');
        });
    });

    app.router.run('#/');
}());