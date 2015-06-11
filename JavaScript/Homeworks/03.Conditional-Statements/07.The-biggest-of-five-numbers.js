/*
 Problem 7. The biggest of five numbers
 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
*/

var a = -3,
    b = -0.5,
    c = -1.1,
    d = -2,
    e = -0.1,
    bigger1,
    bigger2,
    biggest;

if (a >= b) {
    bigger1 = a;
} else {
    bigger1 = b;
}

if (c >= d) {
    bigger2 = c;
} else {
    bigger2 = d;
}

if (bigger1 >= bigger2) {
    if (bigger1 >= e) {
        biggest = bigger1;
    } else {
        biggest = e;
    }
} else {
    if (bigger2 >= e) {
        biggest = bigger2;
    } else {
        biggest = e;
    }
}

console.log(biggest);