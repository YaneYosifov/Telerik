/*
 Problem 1. English digit
 Write a function that returns the last digit of given integer as an English word.
*/

function lastDigitAsWord(number) {
    var lastDigit = number % 10;
    switch (lastDigit) {
        case 0: lastDigit = 'zero'; break;
        case 1: lastDigit = 'one'; break;
        case 2: lastDigit = 'two'; break;
        case 3: lastDigit = 'three'; break;
        case 4: lastDigit = 'four'; break;
        case 5: lastDigit = 'five'; break;
        case 6: lastDigit = 'six'; break;
        case 7: lastDigit = 'seven'; break;
        case 8: lastDigit = 'eight'; break;
        case 9: lastDigit = 'nine'; break;
    }
    return lastDigit;
}

console.log(lastDigitAsWord(12309));