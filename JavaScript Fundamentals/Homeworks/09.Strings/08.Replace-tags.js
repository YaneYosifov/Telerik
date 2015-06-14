/*
 Problem 8. Replace tags
 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(text) {
    return text.replace(/<a href="/g, '[URL=').replace(/">/g, ']').replace(/<\/a>/g, '[/URL]');
}

console.log(replaceTags(input));