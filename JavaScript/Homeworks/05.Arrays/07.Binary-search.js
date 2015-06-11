/*
 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
*/

var sortedArr = [1, 4, 6, 7, 12, 13, 15, 18, 19, 20, 22, 24],
    toFind = 18,
    start = 0,
    end = sortedArr.length - 1,
    middle;

while (true) {
    if (middle == Math.floor((start + end) / 2)) {
        console.log('Element with value ' + toFind + ' doesn\'t exist');
        break;
    } else if (start + 1 == sortedArr.length - 1) {
        middle = end;
    } else {
        middle = Math.floor((start + end) / 2);
    }

    if (sortedArr[middle] > toFind) {
        end = middle;
    } else if (sortedArr[middle] < toFind) {
        start = middle;
    } else {
        console.log('Index of ' + toFind + ' is ' + middle);
        break;
    }
}