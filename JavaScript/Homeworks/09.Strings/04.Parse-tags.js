/*
 Problem 4. Parse tags
 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */

var string = 'We are <mixcase>living</mixcase> in a <upcase>yellow <mixcase>nested</mixcase> submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYTHING</lowcase> else.';

function parseTags(inputStr) {
    inputStr = inputStr.replace(/<upcase>\w*(\s*\w*[.,?!()']*)*</g, function (match) {
        return match.toUpperCase();
    }).replace(/>\w*(\s*\w*[.,?!()']*)*<\/upcase>/g, function (match) {
        return match.toUpperCase();
    });

    inputStr = inputStr.replace(/<lowcase>\w*(\s*\w*[.,?!()']*)*</g, function (match) {
        return match.toLowerCase();
    }).replace(/>\w*(\s*\w*[.,?!()']*)*<\/lowcase>/g, function (match) {
        return match.toLowerCase();
    });

    inputStr = inputStr.replace(/<mixcase>\w*(\s*\w*[.,?!()']*)*</g, function (toMixCase) {
        for (var i = 0; i < toMixCase.length; i++) {
            if (Math.round(Math.random())) {
                toMixCase = toMixCase.substr(0, i) + toMixCase[i].toUpperCase() + toMixCase.substr(i + 1);
            } else {
                toMixCase = toMixCase.substr(0, i) + toMixCase[i].toLowerCase() + toMixCase.substr(i + 1);
            }
        }
        return toMixCase;
    }).replace(/>\w*(\s*\w*[.,?!()']*)*<\/mixcase>/g, function (toMixCase) {
        for (var i = 0; i < toMixCase.length; i++) {
            if (Math.round(Math.random())) {
                toMixCase = toMixCase.substr(0, i) + toMixCase[i].toUpperCase() + toMixCase.substr(i + 1);
            } else {
                toMixCase = toMixCase.substr(0, i) + toMixCase[i].toLowerCase() + toMixCase.substr(i + 1);
            }
        }
        return toMixCase;
    });

    inputStr = inputStr.replace(/<.*?>/g, '');
    return inputStr;
}

console.log(parseTags(string));