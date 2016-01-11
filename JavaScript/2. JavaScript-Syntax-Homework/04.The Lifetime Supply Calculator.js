function calcSupply(){
    var age = parseInt(document.getElementById("age").value);
    var maxAge = parseInt(document.getElementById("maxAge").value);
    var food = document.getElementById("food").value;
    var foodPerDay = Number(document.getElementById("foodPerDay").value);

    var neededFood = ((maxAge - age)*365) * foodPerDay;
    document.getElementById("output").innerHTML =  neededFood + "kg of " +food + " would be enough until I am " +maxAge +" years old."

}