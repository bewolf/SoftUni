function teteven(input) {
    var carModel = '';
    var carFuelType = '';
    var route = '';
    var weight = 0;
    var consumption = 0;
    var extraSnowConsumption = 0;
    var baseConsumption = 10;
    for (var i = 0; i < input.length; i++) {
        var carInfo = input[i].split(' ');
        carModel = carInfo[0];
        carFuelType = carInfo[1];
        route = carInfo[2];
        weight = Number(carInfo[3]);

        if (carFuelType === 'gas') {
            baseConsumption *= 1.2;
        }
        if (carFuelType === 'diesel') {
            baseConsumption *= 0.8;
        }

        consumption = baseConsumption + weight * 0.01;

        if (route === '1') {
            extraSnowConsumption = (consumption * 0.3)* 0.1;
            consumption *= 1.1;
            consumption += extraSnowConsumption;
        }
        if (route === '2'){
            extraSnowConsumption = (consumption * 0.3)* 0.3;
            consumption *= 0.95;
            consumption += extraSnowConsumption;
        }

            console.log(carModel + ' ' + carFuelType + ' ' + route + ' ' + Math.round(consumption));
        baseConsumption = 10;
    }
}

var input = ['BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'];

teteven(input);