/*
 Problem 2. Correct brackets
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

var correct = '((a+b)/5-d)',
    incorrect = ')(a+b))';

function correctBrackets(expression) {
    var opened = 0;
    for (var i = 0; i < expression.length; i++) {
        if (expression.charAt(i) === '(') {
            opened++;
        } else if (expression.charAt(i) === ')') {
            opened--;
        }

        if (opened < 0) {
            return 'Brackets in "' + expression + '" are incorrect';
        }
    }
    return 'Brackets in "' + expression + '" are correct';
}

console.log(correctBrackets(correct));
console.log(correctBrackets(incorrect));