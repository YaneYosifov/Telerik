/*
 Problem 8. Number as words
 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
*/

var number = 810,
    numberStr = "";

if (number <= 999 && number >= 100) {
    switch (Math.floor(number / 100)) {
        case 1: numberStr = "One hundred"; break;
        case 2: numberStr = "Two hundred"; break;
        case 3: numberStr = "Three hundred"; break;
        case 4: numberStr = "Four hundred"; break;
        case 5: numberStr = "Five hundred"; break;
        case 6: numberStr = "Six hundred"; break;
        case 7: numberStr = "Seven hundred"; break;
        case 8: numberStr = "Eight hundred"; break;
        case 9: numberStr = "Nine hundred"; break;
    }

    if (number % 100 == 0) {
    } else {
        if (Math.floor(number / 10) % 10 == 0) {
            switch (number % 10) {
                case 1: numberStr += " and one"; break;
                case 2: numberStr += " and two"; break;
                case 3: numberStr += " and three"; break;
                case 4: numberStr += " and four"; break;
                case 5: numberStr += " and five"; break;
                case 6: numberStr += " and six"; break;
                case 7: numberStr += " and seven"; break;
                case 8: numberStr += " and eight"; break;
                case 9: numberStr += " and nine"; break;
            }
        } else if (number % 100 >= 10 && number % 100 <= 19) {
            switch (number % 100) {
                case 10: numberStr += " and ten"; break;
                case 11: numberStr += " and eleven"; break;
                case 12: numberStr += " and twelve"; break;
                case 13: numberStr += " and thirteen"; break;
                case 14: numberStr += " and fourteen"; break;
                case 15: numberStr += " and fifteen"; break;
                case 16: numberStr += " and sixteen"; break;
                case 17: numberStr += " and seventeen"; break;
                case 18: numberStr += " and eighteen"; break;
                case 19: numberStr += " and nineteen"; break;
            }
        } else if (number % 100 >= 20 && number % 100 <= 99) {
            switch (Math.floor(number / 10) % 10) {
                case 2: numberStr += " and twenty"; break;
                case 3: numberStr += " and thirty"; break;
                case 4: numberStr += " and fourty"; break;
                case 5: numberStr += " and fifty"; break;
                case 6: numberStr += " and sixty"; break;
                case 7: numberStr += " and seventy"; break;
                case 8: numberStr += " and eighty"; break;
                case 9: numberStr += " and ninety"; break;
            }

            switch (number % 10) {
                case 1: numberStr += " one"; break;
                case 2: numberStr += " two"; break;
                case 3: numberStr += " three"; break;
                case 4: numberStr += " four"; break;
                case 5: numberStr += " five"; break;
                case 6: numberStr += " six"; break;
                case 7: numberStr += " seven"; break;
                case 8: numberStr += " eight"; break;
                case 9: numberStr += " nine"; break;
            }
        }
    }
} else if (number <= 99 && number >= 20) {
    switch (Math.floor(number / 10)) {
        case 2: numberStr = "Twenty"; break;
        case 3: numberStr = "Thirty"; break;
        case 4: numberStr = "Fourty"; break;
        case 5: numberStr = "Fifty"; break;
        case 6: numberStr = "Sixty"; break;
        case 7: numberStr = "Seventy"; break;
        case 8: numberStr = "Eighty"; break;
        case 9: numberStr = "Ninety"; break;
    }

    if (number % 10 == 0) {
    } else {
        switch (number % 10) {
            case 1: numberStr += " one"; break;
            case 2: numberStr += " two"; break;
            case 3: numberStr += " three"; break;
            case 4: numberStr += " four"; break;
            case 5: numberStr += " five"; break;
            case 6: numberStr += " six"; break;
            case 7: numberStr += " seven"; break;
            case 8: numberStr += " eight"; break;
            case 9: numberStr += " nine"; break;
        }
    }
} else if (number <= 19 && number >= 0) {
    switch (number) {
        case 0: numberStr = "Zero"; break;
        case 1: numberStr = "One"; break;
        case 2: numberStr = "Two"; break;
        case 3: numberStr = "Three"; break;
        case 4: numberStr = "Four"; break;
        case 5: numberStr = "Five"; break;
        case 6: numberStr = "Six"; break;
        case 7: numberStr = "Seven"; break;
        case 8: numberStr = "Eight"; break;
        case 9: numberStr = "Nine"; break;
        case 10: numberStr = "Ten"; break;
        case 11: numberStr = "Eleven"; break;
        case 12: numberStr = "Twelve"; break;
        case 13: numberStr = "Thirteen"; break;
        case 14: numberStr = "Fourteen"; break;
        case 15: numberStr = "Fifteen"; break;
        case 16: numberStr = "Sixteen"; break;
        case 17: numberStr = "Seventeen"; break;
        case 18: numberStr = "Eighteen"; break;
        case 19: numberStr = "Nineteen"; break;
    }
}

console.log(numberStr);