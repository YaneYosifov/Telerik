/*
 Problem 4. Maximal increasing sequence
 Write a script that finds the maximal increasing sequence in an array.
*/

var numbers = [3, 2, 3, 4, 2, 2, 4],
    sequence = [],
    maxSequence = [numbers[0]];

for (var i = 1; i < numbers.length; i += 1) {
    if (numbers[i] - 1 == numbers[i - 1]) {
        sequence.push(numbers[i]);
    } else {
        sequence = [numbers[i]];
    }

    if (maxSequence.length < sequence.length) {
        maxSequence = sequence;
    }
}

console.log(maxSequence.join(', '));