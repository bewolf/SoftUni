function testContext() {
    console.log(this);
}
//Global context
//testContext();


//Inner context
function anotherFunction() {
    function innerFunction() {
        testContext();
    }
    innerFunction();
}
    anotherFunction();


//Obj
var obj = new testContext();

testContext.call(obj)