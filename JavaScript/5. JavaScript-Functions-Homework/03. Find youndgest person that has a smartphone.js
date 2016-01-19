var people = [
    {firstname: 'George', lastname: 'Kolev', age: 32, hasSmartphone: false},
    {firstname: 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true},
    {firstname: 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true},
    {firstname: 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false}];
var youngest = [];
var smallestAge = 150;

findYoungestPerson(people);

function findYoungestPerson(peoples) {

    for (var i = 0; i < peoples.length; i++) {
        var age = parseInt(peoples[i].age);
        if (age < smallestAge && peoples[i].hasSmartphone) {
            smallestAge = age;
            youngest = peoples[i];
        }
    }
    return console.log('The youngest person is %s %s', youngest.firstname, youngest.lastname);
}

