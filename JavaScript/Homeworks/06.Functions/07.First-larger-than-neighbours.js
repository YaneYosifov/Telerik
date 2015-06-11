/*
 Problem 7. First larger than neighbours
 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */

var numArray = [6, 3, 8, 2, 7, 9, 14, 1];

function isLargerThanNeighbours() {
    for (var i = 0; i < numArray.length; i += 1) {
        if (numArray[i] > numArray[i - 1] && numArray[i] > numArray[i + 1]) {
            return i;
        }
    }
    return -1;
}

console.log(isLargerThanNeighbours());