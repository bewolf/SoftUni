function solve(firstNum, secondNum) {
    let fNum = Number(firstNum);
    let sNum = Number(secondNum);
    let result = 0;

    for (let i = fNum; i <= sNum; i++) {
        result += i;
    }

    console.log(result);
}

solve(1, 5);