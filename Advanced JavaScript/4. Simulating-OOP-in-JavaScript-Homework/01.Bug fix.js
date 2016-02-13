function Person(firstName, lastName) {
    this._firstName = firstName;
    this._lastName = lastName;
    //1st variant
    this._name = this._firstName + " " + this._lastName;
    //2nd variant
    Person.prototype.name = function () {
        return this._firstName + " " + this._lastName;

    }
    return this;
}

var peter = new Person("Peter", "Jackson");
//1st variant
console.log(peter._name);
console.log(peter._firstName);
console.log(peter._lastName);
//2nd variant
console.log(peter.name())
