/*
 Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.
 */

var number = 33;
if (typeof number != 'number') {
} else if (number % 2 == 0) {
    console.log(number + ' is even');
} else {
    console.log(number + ' is odd');
}