/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `string`
 3) it must throw an Error if any of the range params is missing
 */

function solve() {
    return function findPrimes(start, end) {
        start = Math.max(parseInt(start), 2);
        end = parseInt(end);

        var primes = [],
            isPrime,
            i,
            j,
            divisor;

        if (arguments.length !== 2) {
            throw new Error();
        }

        for (i = start; i <= end; i += 1) {
            isPrime = true;
            for (j = 2, divisor = Math.sqrt(i); j <= divisor; j += 1) {
                if (!(i % j)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                primes.push(i);
            }
        }

        return primes;
    }
}

module.exports = solve();