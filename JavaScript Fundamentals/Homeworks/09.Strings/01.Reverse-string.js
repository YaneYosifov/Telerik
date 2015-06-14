/*
 Problem 1. Reverse string
 Write a JavaScript function that reverses a string and returns it.
 */

var input = 'sample';

function reverse(toReverse) {
    return toReverse.split('').reverse().join('');
}

console.log(reverse(input));