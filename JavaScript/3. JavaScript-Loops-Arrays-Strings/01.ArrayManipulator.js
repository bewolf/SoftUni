'use strict';
var input = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", {bunniesCount: 10}, [10, 20, 30, 40]];
var minNumber, maxNumber, mostFrequentNumber ;
var counter = 1;
var currentCount = 1;
var output = [];
//Поради незнайни за мен причини тази функция не разпознава нула като число и съотведно не я добавя към масива Output.
/*function filterNumbers(input) {
    if (!isNaN(input) ) {
        return input;
    }
}
var output = input.filter(filterNumbers); */
for(var i =0; i < input.length; i++){
    if(!isNaN(input[i])){
     output.push(input[i]);
    }
}

function orderBy(a, b) {
    return a - b;
};
output.sort(orderBy);
minNumber = output[0];
maxNumber = output[output.length - 1];

for (var i = 1; i < output.length - 1; i++) {
    if (output[i] === output[i - 1]) {
        currentCount++;
        if (currentCount > counter && output[i] !== output[i + 1]) {
            counter = currentCount;
            currentCount = 1;
            mostFrequentNumber = output[i];
        }
    }
}

console.log('Min number: ' + minNumber);
console.log('Max number: ' + maxNumber);
console.log('Most frequent number: ' + mostFrequentNumber);
console.log(output.reverse());