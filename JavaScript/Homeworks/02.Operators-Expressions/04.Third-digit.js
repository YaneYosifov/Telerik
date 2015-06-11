/*
 Problem 4. Third digit
 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
*/

var number = 1732;
if (Math.floor(number / 100) % 10 === 7) {
    console.log('Third digit is 7');
} else {
    console.log('Third digit is not 7');
}