/*
 Problem 6. Point in Circle
 Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
*/

var x = -4,
    y = -3.5,
    r = 5;

console.log(x * x + y * y <= r * r);