function greatestDivisor(firstNum, secondNum) {
    let bigNum = Math.max(firstNum, secondNum);
    let smallerNum = Math.min(firstNum, secondNum);

    for (let i = smallerNum; i >= 1; i--) {

        if ((bigNum % i === 0) && (smallerNum % i ==0)) {
            console.log(i)
            break;
        }
    }
}

greatestDivisor(2154, 458)