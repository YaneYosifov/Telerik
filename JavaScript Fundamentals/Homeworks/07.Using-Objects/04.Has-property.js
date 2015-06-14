/*
 Problem 4. Has property
 Write a function that checks if a given object contains a given property.
 */

var book = {
    title: 'JavaScript: The Definitive Guide',
    subtitle: 'Activate Your Web Pages',
    edition: '6th Edition',
    author: 'David Flanagan',
    publisher: 'O\'Reilly Media',
    releaseDate: new Date('April 2011'),
    pages: 1096,
    isbn: undefined
};

function hasProperty(obj, hasProp) {
    for (var prop in obj) {
        if (prop === hasProp) {
            return true;
        }
    }
    return false;
}

console.log(hasProperty(book, 'isbn'));