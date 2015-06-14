/*
 Problem 2. Reverse number
 Write a function that reverses the digits of given decimal number.
*/

function reverseNumber(number) {
    return number.toString().split('').reverse().join('');
}

console.log(reverseNumber(123.45));