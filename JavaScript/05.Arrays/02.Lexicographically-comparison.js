/*
 Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */

var charArr1 = 'Lexicographically comparison'.split(''),
    charArr2 = '(letter by letter)'.split(''),
    len;

charArr1.length > charArr2.length ? len = charArr1.length : len = charArr2.length;
for (var i = 0; i < len; i += 1) {
    if (charArr1[i] > charArr2[i]) {
        console.log('"' + charArr1[i] + '" > "' + charArr2[i] + '"');
    } else if (charArr1[i] < charArr2[i]) {
        console.log('"' + charArr1[i] + '" < "' + charArr2[i] + '"');
    } else if (charArr1[i] == charArr2[i]) {
        console.log('"' + charArr1[i] + '" = "' + charArr2[i] + '"');
    } else {
        console.log('"' + charArr1[i] + '" != "' + charArr2[i] + '"');
    }
}