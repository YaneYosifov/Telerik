/*
 Problem 9. Point in Circle and outside Rectangle
 Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

var pointX = 1,
    pointY = 4,
    inCircle = Math.pow(pointX - 1, 2) + Math.pow(pointY - 1, 2) <= Math.pow(3, 2),
    inRectangle = pointX >= -1 && pointX <= 5 && pointY >= -1 && pointY <= 1;

if (inCircle && !inRectangle) {
    console.log('Inside K & outside of R: YES');
}
else {
    console.log('Inside K & outside of R: NO');
}