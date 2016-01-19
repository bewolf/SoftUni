function sortLetters(input, order){
    var arr = input.split('');

    arr.sort(
        function(a, b){
            if (a.toLowerCase() < b.toLowerCase()) return -1;
            if (a.toLowerCase() > b.toLowerCase()) return 1;
            return 0;
        }
    );

    if(order === true){
        arr = arr.join('');
        console.log(arr);
    } else {
        arr = arr.reverse().join('');
        console.log(arr);
    }
}
sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);