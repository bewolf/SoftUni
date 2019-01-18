function solve(number1, number2, operation) {
    let firstNum = Number(number1);
    let secondNum = Number(number2);
    let result;
    switch (operation) {
        case '+':
            result = firstNum + secondNum;
            break;
        case '-':
            result = firstNum - secondNum;
            break;
        case '*':
            result = firstNum * secondNum;
            break;
        case '/':
            result = firstNum / secondNum;
            break;
        case '%':
            result = firstNum % secondNum;
            break;
        case '**':
            result = firstNum** secondNum;
            break;
    }
    console.log(result);
}