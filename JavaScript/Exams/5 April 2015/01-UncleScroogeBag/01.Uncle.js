function uncle(input){
    var totalCoins = 0;
    for(var i = 0; i < input.length; i++){
        var coin = input[i].split(' ')[1];
        if(Number(coin) >= 0 && coin % 1 == 0 && input[i].split(' ')[0].toLowerCase() === 'coin'){
            totalCoins += Number(coin);
        }
    }
    var gold = Math.floor(totalCoins / 100);
    var silver = Math.floor((totalCoins % 100) / 10);
    var bronze = totalCoins % 10;
    console.log('gold : ' + gold);
    console.log('silver : ' + silver);
    console.log('bronze : ' + bronze);

}

//var input = ['coin 1','coin 2', 'coin 5', 'coin 10', 'coin 20', 'coin 50', 'coin 100', 'coin 200', 'coin 500','cigars 1'];

// var input = ['coin one', 'coin two', 'coin five', 'coin ten', 'coin twenty', 'coin fifty', 'coin hundred', 'cigars 1'];

// var input = ['coin 1', 'coin two', 'coin 5', 'coin 10.50', 'coin 20', 'coin 50', 'coin hundred', 'cigars 1'];

uncle(input);