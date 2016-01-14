var input = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];
var output= [];
for(var i=0; i < input.length; i++){
    if(input[i] >= 0 && input[i] <= 400 ){
        output.push(input[i]);
    }
}
for(var i=0; i< output.length; i++){
    output[i] = output[i] - output[i]* 0.2;
}
function orderBy(a, b) {
    return a - b;
};
output.sort(orderBy);
console.log(output);