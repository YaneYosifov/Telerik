/*
 Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

var numbers = [2, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 1],
    sequence = [],
    maxSequence = [numbers[0]];

for (var i = 1; i < numbers.length; i += 1) {
    if (numbers[i] == numbers[i - 1]) {
        sequence.push(numbers[i]);
    } else {
        sequence = [numbers[i]];
    }

    if (maxSequence.length < sequence.length) {
        maxSequence = sequence;
    }
}

console.log(maxSequence.join(', '));