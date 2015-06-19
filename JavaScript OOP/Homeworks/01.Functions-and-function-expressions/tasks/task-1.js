/*
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function solve() {
    return function sum(arr) {
        if (!arr.length) {
            return null;
        }
        return arr.reduce(function (sum, currNum) {
            if (isNaN(currNum)) {
                throw new Error();
            }
            return sum + parseInt(currNum);
        }, 0);
    }
}

module.exports = solve();