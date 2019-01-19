function solve(steps, stepLenght, speed) {

    let totalLenght = steps * stepLenght;
    let addMinutes = Math.floor((totalLenght / 1000) / 0.5);
    let speedInMS = speed * (5 / 18)


    let time = totalLenght / speedInMS;
    let hours = (Math.floor(time / 3600));
    if (hours.toString().length < 2) {
        hours = `0${hours}`;
    }
    let minutes = Math.floor(time / 60) + addMinutes;
    if (minutes.toString().length < 2) {
        minutes = `0${minutes}`;
    }
    let seconds = Math.round(time % 60);

    console.log(`${hours}:${minutes}:${seconds}`);

}

solve(4000, 0.6, 5);