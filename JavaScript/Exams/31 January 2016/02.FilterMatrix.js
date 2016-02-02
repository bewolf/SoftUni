function matrix(input) {
    var output = [];
    for (var i = 0; i < input.length -1 ; i++) {
        var row = input[i].split(' ').map(Number);
        for (var j = 0; j < row.length; j++) {
            if (row[j] === row[j + 1]) {
                delete row[j];
                delete row[j + 1];
            }
        }
        output = row.filter(Number);
        var outputString = ' ';
        for (var k = 0; k < output.length; k++) {
            outputString += output[k] + ' ';
        }
        console.log(outputString.trim())
    }
}
var input = [
    '3 3 3 2 5 9 9 9 9 1 2',
    '1 1 1 1 1 2 5 8 1 1 7 7',
    '7 1 2 3 5 7 4 4 1 2',
    '2'
];

matrix(input);