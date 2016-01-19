function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;

}
var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];
groupBy('firstName');
console.log();
groupBy('lastName');
console.log();
groupBy('age');
console.log();

function groupBy(criteria) {
    var strings = [];
    var counter = 0;

    for (var i = 0; i < people.length; i++) {
        if (criteria === "firstName") {
            var currentItem = people[i].firstName;
            var previousItem = i > 0 ? people[i - 1].firstName : '';
        }
        if (criteria === "lastName") {
            var currentItem = people[i].lastName;
            var previousItem = i > 0 ? people[i - 1].lastName : '';
        }
        if (criteria === "age") {
            var currentItem = people[i].age;
            var previousItem = i > 0 ? people[i - 1].age : '' ;
        }

        strings[counter] = "Group " + currentItem +" : [" + people[i].firstName + " " + people[i].lastName + " (age " + people[i].age + ")]";

        if (i > 0 && currentItem === previousItem) {
            strings[counter - 1] = strings[counter -1].toString().substring(0, strings[counter - 1].length - 1)
                + ", " + people[i].firstName + " " + people[i].lastName + " (age " + people[i].age + ")]";
            counter--;
        }
        counter++;
    }

    for (var i = 0; i < strings.length; i++) {
        console.log(strings[i]);
    }
}