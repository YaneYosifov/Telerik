/*
 Problem 6. Larger than neighbours
 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
*/

var numArray = [6, 3, 8, 2, 7, 9, 14, 1];

function isLargerThanNeighbours(index) {
    var result;
    if (numArray[index] > numArray[index - 1] && numArray[index] > numArray[index + 1]) {
        result = console.log(numArray[index] + ' at position ' + index + ' is bigger than its two neighbours');
    } else if (numArray[index - 1] == undefined && numArray[index] > numArray[index + 1]) {
        result = console.log(numArray[index] + ' at position ' + index + ' is bigger than its right neighbour');
    } else if (numArray[index] > numArray[index + - 1] && numArray[index + 1] == undefined) {
        result = console.log(numArray[index] + ' at position ' + index + ' is bigger than its left neighbour');
    } else {
        result = console.log(numArray[index] + ' at position ' + index + ' is not bigger than its two neighbours');
    }
    return result;
}

isLargerThanNeighbours(3);