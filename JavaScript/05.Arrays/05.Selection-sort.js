/*
 Problem 5. Selection sort
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */

var numbers = [],
    index,
    sorted = [],
    currentNum;

for (var i = 0; i < 20; i += 1) {
    numbers.push(Math.floor((Math.random() * 100) + 1));
}
var smallest = numbers[0];

console.log('Before sorting');
console.log(numbers);
console.log();

while (numbers.length > 0) {
    for (i = 1; i < numbers.length; i += 1) {
        if (numbers[i] < smallest) {
            smallest = numbers[i];
            index = i;
        }
    }
    currentNum = numbers.splice(index, 1);
    sorted.push(currentNum[0]);
    smallest = numbers[0];
    index = 0;
}

console.log('After sorting');
console.log(sorted);