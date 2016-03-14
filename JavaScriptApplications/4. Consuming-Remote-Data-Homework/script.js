(function () {
    var APP_ID = 'Basic bWF0c292Om1hdHNvdg==',
        baseUrl = 'https://baas.kinvey.com/appdata/kid_bJgPi-X6Cx/',
        counter = 0;
    requestBooks();
    $('#add-book').on('click', function () {
        createBook();
    });

    function requestBooks() {
        $.ajax({
            method: 'GET',
            headers: {
                "Authorization": APP_ID
            },
            url: baseUrl + 'Books',
            success: function (data) {
                showBooksHTML(data);
            },
            error: errorMessage
        });
    }


    function showBooksHTML(data) {
        if (data.length === 0) {
            $('#books').innerText('There is no books.');
        }
        $('#books').empty();
        var listBooks = $('<ul>');
        $(listBooks).append($('<li>').append('<span>Title</span><span>Author</span><span>ISBN</span>'));

        data.forEach(function (item) {
            var deleteButtonId = item._id;
            listBooks
                .append('<li>' +
                    '<span>' + item.title + '</span>' +
                    '<span>' + item.author + '</span>' +
                    '<span>' + item.isbn + '</span>')
                .append(
                    $('<button>' + 'Remove' + '</button>')
                        .on('click', function () {
                            deleteBook(deleteButtonId);
                        })
                )
                .append(
                    $('<button>' + 'Edit book' + '</button>')
                        .on('click', function () {
                            editBook(deleteButtonId, item);
                        })
                )
        });

        $('#books').append(listBooks);
    }

    function createBook() {
        if ($('#input-title').val().length === 0 ||
            $('#input-author').val().length === 0 ||
            $('#input-isbn').val().length === 0) {
            $('#books').empty();
            $('#books').append('<p>Need to fill all fields</p>');
        } else {
            $.ajax({
                method: 'POST',
                headers: {
                    "Authorization": APP_ID,
                    'Content-type': 'application/json'
                },
                url: baseUrl + 'Books',
                data: JSON.stringify({
                    'title': $('#input-title').val(),
                    'author': $('#input-author').val(),
                    'isbn': $('#input-isbn').val()
                }),
                success: function () {
                    requestBooks();
                },
                error: errorMessage
            })
        }
    }

    function deleteBook(bookId) {
        $.ajax({
            method: 'DELETE',
            headers: {
                "Authorization": APP_ID,
            },
            url: baseUrl + 'Books/' + bookId,
            success: function () {
                requestBooks();
            },
            error: errorMessage
        });
    }

    function editBook(bookId, data) {
        if ($('#input-title').val().length === 0 &&
            $('#input-author').val().length === 0 &&
            $('#input-isbn').val().length === 0) {
            $('#books').empty();
            $('#books').append('<p>Need to fill some of fields</p>');
        } else {
            $.ajax({
                method: 'PUT',
                headers: {
                    "Authorization": APP_ID,
                    'Content-type': 'application/json'
                },
                url: baseUrl + 'Books/' + bookId,
                data: JSON.stringify({
                    'title': $('#input-title').val() || data.title,
                    'author': $('#input-author').val() || data.author,
                    'isbn': $('#input-isbn').val() || data.isbn
                }),
                success: function () {
                    requestBooks();
                },
                error: errorMessage
            })
        }
    }

    function errorMessage() {
        return $('<div class="errorMessage">' + 'Cannot load data.' + '</div>');
    }
})();