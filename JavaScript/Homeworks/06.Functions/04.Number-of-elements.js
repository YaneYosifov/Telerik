/*
 Problem 4. Number of elements
 Write a function to count the number of div elements on the web page
*/

function countElements() {
    return document.getElementsByTagName('div').length;
}

console.log(countElements());