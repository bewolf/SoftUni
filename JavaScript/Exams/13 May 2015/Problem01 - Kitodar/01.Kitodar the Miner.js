function kitodar(input) {
    var gold = 0;
    var silver = 0;
    var diamonds = 0;
    var goldPatern = 'gold.*:';
    var silverPatern = 'silver.*:';
    var diamondsPatern = 'diamonds.*:';
    for (var i = 0; i < input.length; i++) {
        if (input[i].indexOf('mine') > -1) {
            if (input[i].match(goldPatern)) {
                gold += Number(input[i].replace(/.*?(\d+)[^\d]*$/, '$1'));
            }
            if (input[i].match(silverPatern)) {
                silver += Number(input[i].replace(/.*?(\d+)[^\d]*$/, '$1'));
            }
            if (input[i].match(diamondsPatern)) {
                diamonds += Number(input[i].replace(/.*?(\d+)[^\d]*$/, '$1'));
            }
        }
    }
    console.log('*Silver: ' + silver);
    console.log('*Gold: ' + gold);
    console.log('*Diamonds: ' + diamonds);
}

var input = [
    '  mine mina - gold-  5',
    'mine mina - silver - 5',
    ' mine mina - diamonds : 5',
    'mine mina - gold :5'
];

kitodar(input);