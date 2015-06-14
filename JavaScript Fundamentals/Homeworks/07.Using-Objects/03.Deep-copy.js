/*
 Problem 3. Deep copy
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

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

var user1 = {
    firstName: 'John',
    lastName: 'Smith',
    hobbies: ['skiing', 'surfing'],
    marks: {
        JavaScript: 5.5,
        OOP: 4,
        CSS: 6
    }
};

var user2 = deepCopy(user1);
console.log(user2);