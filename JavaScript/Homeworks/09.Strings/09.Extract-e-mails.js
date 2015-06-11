/*
 Problem 9. Extract e-mails
 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */

var text = 'Lorem ipsum dolor sit amet, eruditi Mook1970@armyspy.com definiebas usu id. Duo eu veri debitis. At eruditi Plithere1987@cuvox.de senserit consectetuer ius, duo at mutat officiis patrioque. Choro alterum in his. Eu per Plesn1945@fleckens.hu melius maluisset conceptam, no Seesser1960@cuvox.de explicari conclusionemque ius.';

function extractEmail(input) {
    return input.match(/[A-z0-9_.-]+@[A-z0-9_.-]+/g);
}

console.log(extractEmail(text));