/*
 Problem 6. Quadratic equation
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 */

var a = -1,
    b = 3,
    c = 0,
    d = (b * b) - (4 * a * c),
    x1 = (-b - Math.sqrt(d)) / (2 * a),
    x2 = (-b + Math.sqrt(d)) / (2 * a);

if (isNaN(x1) && isNaN(x2)) {
    console.log('no real roots');
} else if (x1 != x2) {
    console.log('x1 = ' + x1 + '; ' + 'x2 = ' + x2);
} else {
    console.log('x1 = x2 = ' + x1);
}