function setArea() {
    var r = document.getElementById("input-radius").value;
    var radius = parseInt(r);
    var area = Math.PI*(Math.pow(radius, 2));
    var result =  "radius = " + radius + "; " + "area = " + area + "<br>";
    document.getElementById("circle-area").innerHTML += radius; //Не можах да разбера защо без полседния ред не ми се визуализира този резултат. Ако знаеш как да го визуализирам без последния ред ще се радвам да споделиш.
    document.write(result);
}
