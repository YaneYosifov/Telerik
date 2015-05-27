/*
 Problem 2. Divisible by 7 and 5
 Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */

var number = 140;
if (typeof number != 'number') {
}
else if (number % 5 == 0 && number % 7 == 0) {
    console.log(number + ' is divisible by 5 and 7');
}
else {
    console.log(number + ' is not divisible by 5 and 7');
}