String.prototype.startsWith = function (substring) {
    var result = !this.indexOf(substring);
    return result;
}

String.prototype.endsWith = function (substring) {
    var result = this.length >= substring.length && this.substr(this.length - substring.length) == substring;
    return result;
}

String.prototype.left = function (count) {
    var result = this.substr(0, count);
    return result;
}

String.prototype.right = function (count) {
    if (count >= this.length) {
        return this.toString();
    } else {
        var result = this.substr(this.length - count);
        return result;
    }
}

String.prototype.padLeft = function (count, character) {
    character = character || ' ';
    if (this.length >= count) {
        return this.toString();
    } else {
        return Array((count + 1 ) - this.length).join(character) + this.toString();
    }
}

String.prototype.padRight = function (count, character) {
    character = character || ' ';
    if (this.length >= count) {
        return this.toString();
    } else {
        return this.toString() + Array((count + 1 ) - this.length).join(character);
    }
}

String.prototype.repeat = function (count) {
    return Array(count + 1).join(this.toString());
}
var example = "This is an example string used only for demonstration purposes.";

console.log(example.startsWith("This"));                //true
console.log(example.startsWith("this"));                //false
console.log(example.startsWith("other"));               //false

console.log(example.endsWith("poses."));                //true
console.log(example.endsWith ("example"));              //false
console.log(example.startsWith("something else"));      //false

console.log(example.left(9));               //This is a
console.log(example.left(90));              //This is an example string used only for
                                            //demonstration purposes.

console.log(example.right(9));              //purposes.
console.log(example.right(90));             //This is an example string used only for
                                            //demonstration purposes.

var example = "abcdefgh";
console.log(example.left(5).right(2));      //de

var hello = "hello";
console.log(hello.padLeft(5));              //hello
console.log(hello.padLeft(10));             //     hello
console.log(hello.padLeft(5, "."));         //hello
console.log(hello.padLeft(10, "."));        //.....hello
console.log(hello.padLeft(2, "."));         //hello

console.log(hello.padRight(5));             //hello
console.log(hello.padRight(10));            //hello     //There are 5 spaces here
console.log(hello.padRight(5, "."));        //hello
console.log(hello.padRight(10, "."));       //hello.....
console.log(hello.padRight(2, "."));        //hello

var character = "*";
console.log(character.repeat(5));                               //*****
console.log("~".repeat(3));                                     //~~~
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+")); //-----*****+++++