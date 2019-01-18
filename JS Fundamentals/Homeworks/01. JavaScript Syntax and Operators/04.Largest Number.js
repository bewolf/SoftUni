function solve(num1, num2, num3) {
    let fNum = Number(num1);
    let sNum = Number(num2);
    let tNum = Number(num3);

    let largestNum = Math.max(Math.max(fNum,sNum),tNum);

    console.log(`The largest number is ${largestNum}.`)
}

solve('5',2,3)