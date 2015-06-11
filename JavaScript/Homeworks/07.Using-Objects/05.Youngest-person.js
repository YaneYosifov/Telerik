/*
 Problem 5. Youngest person
 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.
 */

function person(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age
    };
}

var people = [person('Ivan', 'Petrov', 28),
        person('Marti', 'Bubolechkata', 12),
        person('Mihaela', 'Fileva', 24)],
    youngestAge = 999,
    youngestPerson;

for (var item in people) {
    if (people[item].age < youngestAge) {
        youngestAge = people[item].age;
        youngestPerson = people[item];
    }
}

console.log(youngestPerson);