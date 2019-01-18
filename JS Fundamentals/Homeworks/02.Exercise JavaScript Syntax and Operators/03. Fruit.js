function fruit(fruit, weigth, cost) {
    let kgWeight = weigth / 1000;
    let sum = cost * kgWeight;
    console.log(`I need ${sum.toFixed(2)} leva to buy ${kgWeight.toFixed(2)} kilograms ${fruit}.`)
}