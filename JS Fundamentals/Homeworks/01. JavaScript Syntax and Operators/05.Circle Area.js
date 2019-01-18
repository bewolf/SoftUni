function circleArea(radius) {
    let circleRadius = 0;

    if (isNaN(radius)) {
        let theType = typeof (radius);
        console.log(`We can not calculate the circle area, because we receive a ${theType}.`);
    } else {
        circleRadius = Math.PI *( radius * radius);
        console.log(circleRadius.toFixed(2));
    }
}
circleArea(5)