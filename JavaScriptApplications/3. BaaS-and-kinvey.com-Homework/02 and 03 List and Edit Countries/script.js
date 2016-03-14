(function () {
    var baseURL = 'https://baas.kinvey.com/appdata/kid_bJgPi-X6Cx/',

        collectionName = 'Country',
        query = '?query=',
        countries,
        data,
        input,
        haveCountry = false,
        xmlHttp = new XMLHttpRequest();

    function retrieveCountries() {
        xmlHttp.open('GET', baseURL + collectionName, false);
        xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
        xmlHttp.setRequestHeader('Content-Type', 'application/json');
        xmlHttp.send(null);
        countries = JSON.parse(xmlHttp.responseText);

        $('#countries').css('border', '1px solid black').empty();
        $.each(countries, function (i) {
            $('#countries').append('<p>' + countries[i].name + '</p>');
        });
    };

    function addCountry() {
        xmlHttp.open('GET', baseURL + collectionName, false);
        xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
        xmlHttp.setRequestHeader('Content-Type', 'application/json');
        xmlHttp.send(null);
        countries = JSON.parse(xmlHttp.responseText);
        input = $('#input-country').val();

        //Check if there have such country
        $.each(countries, function (i) {
                if (countries[i].name === input) {
                    return haveCountry = true;
                }
            }
        );
        //TODO check for valid string
        if (!haveCountry) {
            xmlHttp.open('POST', baseURL + collectionName, false);
            xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
            xmlHttp.setRequestHeader('Content-Type', 'application/json');
            data = JSON.stringify({"name": input});
            xmlHttp.send(data);

            $('#countries')
                .css('border', '1px solid black')
                .css('width', '300px')
                .empty()
                .append('Successfully added' + ' <span> ' + input + '</span>' + ' to database. Press Show Countries button to see new list.');
        } else {
            $('#countries').empty().append('<p>' + 'There have such country ' + ' <span> ' + input + '</span>' + '</p>');
            haveCountry = false;
        }
    };

    function deleteCountry() {
        xmlHttp.open('GET', baseURL + collectionName, false);
        xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
        xmlHttp.setRequestHeader('Content-Type', 'application/json');
        xmlHttp.send(null);
        countries = JSON.parse(xmlHttp.responseText);
        input = $('#input-country').val();

        //Check if there have such country
        $.each(countries, function (i) {
                if (countries[i].name === input) {
                    return haveCountry = true;
                }
            }
        );
        if (haveCountry) {
            data = {
                'name': input
            }
            data = JSON.stringify(data);
            xmlHttp.open('DELETE', baseURL + collectionName + query + data, false);
            xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
            xmlHttp.send();

            $('#countries')
                .css('border', '1px solid black')
                .css('width', '300px')
                .empty()
                .append('Successfully deleted ' + '<strong>' + input + '</strong>' + ' from database. Press Show Countries button to see new list.');
        } else {
            $('#countries').empty().append('<p>' + 'Need to enter text value or there no such country' + '</p>');
            haveCountry = false;
        }
    };

    function editCountry() {
        xmlHttp.open('GET', baseURL + collectionName, false);
        xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
        xmlHttp.setRequestHeader('Content-Type', 'application/json');
        xmlHttp.send(null);
        countries = JSON.parse(xmlHttp.responseText);
        input = $('#input-country').val();

        //Check if there have such country
        $.each(countries, function (i) {
                if (countries[i].name === input) {
                    return haveCountry = true;
                }
            }
        );

        //TODO
        if (haveCountry) {
            data = {
                'name': input
            }
            data = JSON.stringify(data);
            xmlHttp.open('PUT', baseURL + collectionName , false);
            xmlHttp.setRequestHeader('Authorization', 'Basic VGVzdDp0ZXN0');
            xmlHttp.send();

            $('#countries')
                .css('border', '1px solid black')
                .css('width', '300px')
                .empty()
                .append('Successfully deleted ' + '<strong>' + input + '</strong>' + ' from database. Press Show Countries button to see new list.');
        } else {
            $('#countries').empty().append('<p>' + 'Need to enter text value or there no such country' + '</p>');
            haveCountry = false;
        }
    };
    $('#showCountries').on('click', retrieveCountries);
    $('#addCountry').on('click', addCountry);
    $('#deleteCountry').on('click', deleteCountry);
    $('#editCountry').on('click', editCountry);

})();