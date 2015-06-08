/*
 Problem 1. Make person
 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

function createPerson(firstname, lastname, age, gender) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        gender: gender
    };
}

var people = [
    createPerson('Henrietta', 'Coleman', 67, true),
    createPerson('Alfonso', 'Schwartz', 35, false),
    createPerson('Juan', 'Padilla', 91, false),
    createPerson('Beverly', 'Frank', 81, false),
    createPerson('Sheryl', 'Snyder', 56, true),
    createPerson('Antonio', 'Beck', 4, false),
    createPerson('Dan', 'Sutton', 75, false),
    createPerson('Lucy', 'Rivera', 12, true),
    createPerson('Cristina', 'Porter', 9, true),
    createPerson('Jacquelyn', 'Day', 33, false)
];

console.log(people);


/*
 Problem 2. People of age
 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */

function isGreaterThan18(person) {
    return person.age >= 18;
}

console.log('\nAre all people greater than 18? ' + people.every(isGreaterThan18));


/*
 Problem 3. Underage people
 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

function isUnderaged(person) {
    return person.age < 18;
}

var underaged = people.filter(isUnderaged);
console.log('\nUnderaged persons:');
underaged.forEach(function (person) {
    console.log(person.firstname + ' ' + person.lastname + ' - ' + person.age);
});


/*
 Problem 4. Average age of females
 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */

function averageAge(person) {
    var count = 0;
    return person.reduce(function (sum, num) {
            count += 1;
            return sum + num.age;
        }, 0) / count;
}

var females = people.filter(function (isFemale) {
    return isFemale.gender === true;
});

console.log('\nAverage age of all females: ' + averageAge(females));


/*
 Problem 5. Youngest person
 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

function youngestMale(people) {
    people.sort(function (a, b) {
        return a.age - b.age;
    });
    return people.find(function (person) {
        return person.gender === false;
    });
}

console.log('\nYoungest male person: ' + youngestMale(people).firstname + ' ' + youngestMale(people).lastname);


/*
 Problem 6. Group people
 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */

var result = people.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log();
console.log(result);