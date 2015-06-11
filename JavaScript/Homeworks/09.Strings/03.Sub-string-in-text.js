/*
 Problem 3. Sub-string in text
 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

 Example:
 The target sub-string is in
 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
 The result is: 9
 */

var string = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    subString = 'in',
    count = 0;

function findSubstring(str, toFind) {
    for (var i = 0; i < str.length - 1; i++) {
        i = str.indexOf(toFind, i);
        if (i === -1) {
            break;
        }
        count++;
    }
    return count;
}

console.log(findSubstring(string, subString));