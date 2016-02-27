var input = [{"manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family"},
    {"manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport"},
    {"manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family"}];

/*Variant 1*/

for (var i = 0; i < input.length; i++) {
    $('#cars').append(
        '<tr><td> ' + input[i].manufacturer +
        '</td><td>' + input[i].model +
        '</td><td>' + input[i].year +
        '</td><td>' + input[i].price +
        '</td><td>' + input[i].class + '</td></tr>');
};

/*Variant 2*/
$('#cars').append('<tr><td>Variant 2</td></tr>')
$(input).each(function(index, element){
    $('#cars').append(
        '<tr><td> ' + input[index].manufacturer +
        '</td><td>' + input[index].model +
        '</td><td>' + input[index].year +
        '</td><td>' + input[index].price +
        '</td><td>' + input[index].class + '</td></tr>');
})