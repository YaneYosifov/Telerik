/*
 Problem 5. nbsp
 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

var text = '\t Write a function that     \n replaces non breaking white-spaces in a text with &nbsp;';

function replaceSpaces (input) {
    return input.replace(/[ \t]/g, '&nbsp;');
}

console.log(replaceSpaces(text));