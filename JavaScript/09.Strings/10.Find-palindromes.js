/*
 Problem 10. Find palindromes
 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

var text = 'ALULA A part of a bird\'s wing. ANANA The pineapple. CIVIC Pertaining to cities. DEKED From DEKE, to feint in hockey DELED From DELE, to delete. DERED From DERE, to injure. DEWED From DEW, to moisten. KAIAK A light canoe. KAYAK A light canoe. LEMEL Metal filings. LEVEL To even out. MADAM A term of address for a woman. MALAM A Muslim scholar. MINIM A musical note. RADAR A locating device. REFER To attribute to. ROTOR A rotating machine part. SAGAS From SAGA, a series of novels. SAMAS From SAMA, a Japanese title. SEDES A seat (Latin). SELES From SELE, good fortune. SEMES From SEME, an ornamental pattern. SERES From SERE, to burn the surface of. SEXES From SEX, gender. SHAHS From SHAH, an Iranian ruler. SIMIS From SIMI, a type of sword. SIRIS From SIRI, a climbing plant. SOLOS From SOLO, to perform alone. STATS From STAT, a statistic. STETS From STET, to cancel a printing correction. STOTS From STOT, to bounce. SULUS From SULU, a Melanesian skirt. SUSUS From SUSU, a group savings scheme. TENET A principle. TOROT The body of Jewish law.';

function findPalindromes(input) {
    var words = input.split(/[ .,?!]+/);
    for (var i = 0; i < words.length; i++) {
        var currWord = words[i];
        var isPalindrome = true;
        for (var j = 0; j < currWord.length; j++) {
            if (currWord[j] !== currWord[currWord.length - j - 1]) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome) {
            console.log(currWord + ' ');
        }
    }
}

findPalindromes(text);