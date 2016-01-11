function getResult() {
    var input = parseInt(document.getElementById("input").value);
    var kmH = input;
    var knots = (kmH / 1.852).toFixed(2);
    document.getElementById("output").innerHTML = knots;

}