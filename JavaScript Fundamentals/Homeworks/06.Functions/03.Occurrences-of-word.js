/*
 Problem 3. Occurrences of word
 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
*/

function getWordCount(string, word, isCaseSensitive) {
    function getWordCountCaseInsensitive(word) {
        var regex = new RegExp('\\b(' + word + ')\\b', 'gi');
        return string.match(regex).length;
    }

    function getWordCountCaseSensitive(word) {
        var regex = new RegExp('\\b(' + word + ')\\b', 'g');
        return string.match(regex).length;
    }

    switch (arguments.length) {
        case 2:
            return getWordCountCaseInsensitive(word);
        case 3:
            return isCaseSensitive ? getWordCountCaseSensitive(word) : getWordCountCaseInsensitive(word);
    }
}

var string = 'This is a string. Ant it IS COOL. Isn\'t it?';
console.log('"' + string + '"');
console.log('"is" --> ' + getWordCount(string, 'is') + ' (case insensitive)');
console.log('"is" --> ' + getWordCount(string, 'is', false) + ' (case insensitive)');
console.log('"is" --> ' + getWordCount(string, 'is', true) + ' (case sensitive)');