/*
 Problem 4. Sort 3 numbers
 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.
*/

var a = -1.1,
    b = -0.5,
    c = -0.1;

if (a >= b && a >= c) {
    if (b >= c) {
        console.log(a + ' ' + b + ' ' + c);
    } else {
        console.log(a + ' ' + c + ' ' + b);
    }
} else if (b >= a && b >= c) {
    if (a >= c) {
        console.log(b + ' ' + a + ' ' + c);
    } else {
        console.log(b + ' ' + c + ' ' + a);
    }
} else {
    if (a >= b) {
        console.log(c + ' ' + a + ' ' + b);
    } else {
        console.log(c + ' ' + b + ' ' + a);
    }
}