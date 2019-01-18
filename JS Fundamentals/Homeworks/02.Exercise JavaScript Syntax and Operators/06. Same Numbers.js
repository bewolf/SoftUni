function solve(number) {
    let isTheSame = 'true';
    let digits = number.toString().split('');
    for (let i = 1; i < digits.length; i++) {

        if (digits[i] != digits[0]) {
            isTheSame = 'false';
            break;
        }

    }
    let sum = digits
        .map(Number)
        .reduce(function (a, b) {
            return a + b;
        }, 0);
    console.log(isTheSame);

    console.log(sum);
}

solve(2227)