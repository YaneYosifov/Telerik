/*
 Problem 7. Is prime
 Write an expression that checks if given positive integer number n (n ? 100) is prime.
*/

var number = 37;
var isPrime = 'not prime';
if (number > 1) {
    isPrime = 'prime';
    for (var i = 2; i <= Math.sqrt(number); i += 1) {
        if (number % i == 0) {
            isPrime = 'not prime';
            break;
        }
    }
}
console.log(number + ' is ' + isPrime);