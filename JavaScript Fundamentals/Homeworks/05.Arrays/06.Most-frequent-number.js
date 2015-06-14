/*
 Problem 6. Most frequent number
 Write a script that finds the most frequent number in an array.
*/

var numArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    currentNumCount = 1,
    mostFreqNum = numArr[0],
    mostFreqNumCount = 1;

numArr.sort();
for (var i = 1; i < numArr.length; i += 1) {
    if (numArr[i] == numArr[i - 1]) {
        currentNumCount += 1;
    } else {
        currentNumCount = 1;
    }

    if (currentNumCount > mostFreqNumCount) {
        mostFreqNumCount = currentNumCount;
        mostFreqNum = numArr[i];
    }
}

console.log(mostFreqNum + ' (' + mostFreqNumCount + ' times)');