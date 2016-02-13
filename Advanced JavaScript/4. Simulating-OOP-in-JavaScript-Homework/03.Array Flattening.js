Array.prototype.flatten = function() {
    var newArr = [];
    for (var i = 0; i < this.length; ++i) {
        var v = this[i];
        if (v instanceof Array) {
            Array.prototype.push.apply(this, v.flatten());
        } else {
            newArr.push(v);
        }
    }
    return newArr;
};
var array = [1, 2, 3, 4];
console.log(array.flatten());           //[1, 2, 3, 4]

var array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());            //[1, 2, 3, 4, 5, 6]
console.log(array); // Not changed      //[1, 2, [3, 4], [5, 6]]

var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());
//[0, "string", "values", 5.5, 1, 2, true, 3, 4, false, 10]
