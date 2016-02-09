function add(a) {
    var add = a;

    function f(b) {
        add += b;
        return f;
    }
    f.toString = function() { return add};
    return f;
}
console.log(add(1).toString());             // 1
console.log(add(2)(3).toString());          // 5
console.log(add(1)(1)(1)(1)(1).toString()); // 5
console.log(add(1)(0)(-1)(-1).toString()); // -1