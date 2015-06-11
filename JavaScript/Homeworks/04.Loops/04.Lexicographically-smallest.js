/*
 Problem 4. Lexicographically smallest
 Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */

function smallestProperty(object) {
    var smallest = 'z',
        biggest = 'a';
    for (var property in object) {
        if (property < smallest) {
            smallest = property;
        }
    }
    return smallest;
}

function biggestProperty(object) {
    var smallest = 'z',
        biggest = 'a';
    for (var property in object) {
        if (property > biggest) {
            biggest = property;
        }
    }
    return biggest;
}

console.log('Lexicographically smallest property in document is ' + smallestProperty(document));
console.log('Lexicographically biggest property in document is ' + biggestProperty(document));
console.log('Lexicographically smallest property in window is ' + smallestProperty(window));
console.log('Lexicographically biggest property in window is ' + biggestProperty(window));
console.log('Lexicographically smallest property in navigator is ' + smallestProperty(navigator));
console.log('Lexicographically biggest property in navigator is ' + biggestProperty(navigator));
