/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */

function solve() {
    return library = (function () {
        var books = [],
            categories = [];

        function isNotUniqueParam(book, prop, arr) {
            if (typeof arr[0] === 'object') {
                return arr.some(function (item) {
                    return item[prop] === book[prop];
                });
            } else {
                return arr.some(function (item) {
                    return item === book[prop];
                });
            }
        }

        function invalidTitleOrCategory(value) {
            if (value.length < 2 || value.length > 100) {
                return true;
            }
        }

        function listBooks(listBy) {
            if (listBy === undefined) {
                return books;
            }

            var listedBooks = [];
            for (var prop in listBy) {
                for (var i = 0; i < books.length; i++) {
                    if (books[i][prop] === listBy[prop]) {
                        listedBooks.push(books[i]);
                    }
                }
            }
            return listedBooks;
        }

        function addBook(book) {
            if (isNotUniqueParam(book, 'title', books)) {
                throw new Error('Book title must be unique');
            }
            if (isNotUniqueParam(book, 'isbn', books)) {
                throw new Error('Book ISBN must be unique');
            }
            if (!book.author) {
                throw new Error('Book author cannot be empty');
            }
            if (book.isbn.length !== 10 && book.isbn.length !== 13 || isNaN(book.isbn)) {
                throw new Error('Book ISBN must be either 10 or 13 digits');
            }
            if (invalidTitleOrCategory(book.title)) {
                throw new Error('Book title must be between 2 and 100 characters (letters, digits and special characters)');
            }
            if (invalidTitleOrCategory(book.category)) {
                throw new Error('Book category must be between 2 and 100 characters (letters, digits and special characters)');
            }

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            books.forEach(function (book) {
                if (!isNotUniqueParam(book, 'category', categories)) {
                    categories.push(book.category);
                }
            });
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
}

module.exports = solve;