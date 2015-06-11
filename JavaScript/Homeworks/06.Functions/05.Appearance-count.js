/*
 Problem 5. Appearance count
 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
*/

var numArray = [6, 7, 14, 5, 6, 10, 2, 6, 5];

function countOccurrences(value) {
    var count = 0;
    for (var i in numArray) {
        if (numArray[i] === value) count += 1;
    }
    return count;
}

console.log(countOccurrences(6));