/*
 Problem 6.
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)
 */

var people = [{fname: 'Dino', lname: 'Yanev', age: 12},
    {fname: 'Stamat', lname: 'Borisov', age: 51},
    {fname: 'Iliyan', lname: 'Petrov', age: 30},
    {fname: 'Maria', lname: 'Avramova', age: 24}];

function deepCopy(obj) {
    if (Object.prototype.toString.call(obj) === '[object Array]') {
        var out = [], i = 0, len = obj.length;
        for (; i < len; i++) {
            out[i] = arguments.callee(obj[i]);
        }
        return out;
    }
    if (typeof obj === 'object') {
        var out = {}, i;
        for (i in obj) {
            out[i] = arguments.callee(obj[i]);
        }
        return out;
    }
    return obj;
}

function group(people, firstname, lastname, age) {
    function groupByFirstName() {
        return deepCopy(people.sort(function (a, b) {
            return a.fname > b.fname;
        }))
    }

    function groupByLastName() {
        return deepCopy(people.sort(function (a, b) {
            return a.lname > b.lname;
        }))
    }

    function groupByAge() {
        return deepCopy(people.sort(function (a, b) {
            return a.age - b.age;
        }))
    }

    switch (arguments[1]) {
        case 'firstname':
            return groupByFirstName();
        case 'lastname':
            return groupByLastName();
        case 'age':
            return groupByAge();
    }
}

function allGroups() {
    return {
        groupedByFname: group(people, 'firstname'),
        groupedByLname: group(people, 'lastname'),
        groupedByAge: group(people, 'age')
    }
}

console.log(allGroups());