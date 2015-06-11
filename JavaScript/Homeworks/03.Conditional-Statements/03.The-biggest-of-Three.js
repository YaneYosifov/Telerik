/*
 Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
*/

var a = -2,
    b = 4,
    c = 3,
    result = 0;

if (a >= b && a >= c) {
    result = a;
    if (a == b) {
        result += ' ' + b;
    }
    if (a == c) {
        result += ' ' + c;
    }
} else if (b >= a && b >= c) {
    result = b;
    if (b == c) {
        result += ' ' + c;
    }
} else {
    result = c;
}

console.log(result);