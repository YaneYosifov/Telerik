/*
 Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers.
*/

var sequence = [5, -7, 12, 90, 43, 1, 8, 63, -13];
console.log(Math.min.apply(Math, sequence));
console.log(Math.max.apply(Math, sequence));