function solve() {
    var item = function () {
        var id = 0;
        var item = {
            init: function (description, name) {
                this.id = id += 1;
                this.description = description;
                this.name = name;
                return this;
            },

            get description() {
                return this._description;
            },
            set description(newDescription) {
                if (typeof newDescription !== 'string' || !newDescription.length) {
                    throw new Error('Invalid description');
                }
                this._description = newDescription;
            },

            get name() {
                return this._name;
            },
            set name(newName) {
                if (typeof newName !== 'string' || (newName.length < 2 && newName.length > 40)) {
                    throw new Error('Invalid Item-name');
                }
                this._name = newName;
            }
        };

        return item;
    }();

    var book = function (parent) {
        var book = Object.create(parent);

        book.init = function (name, isbn, genre, description) {
            parent.init.call(this, name, description);
            this.isbn = isbn;
            this.genre = genre;
            return this;
        };

        Object.defineProperty(book, 'isbn', {
            get: function () {
                return this._isbn;
            },
            set: function (newIsbn) {
                if (isNaN(newIsbn) || (newIsbn.length !== 10 && newIsbn.length !== 13)) {
                    throw new Error('Invalid ISBN');
                }
                this._isbn = newIsbn;
            }
        });

        Object.defineProperty(book, 'genre', {
            get: function () {
                return this._genre;
            },
            set: function (newGenre) {
                if (typeof newGenre !== 'string' || (newGenre.length < 2 && newGenre.length > 20)) {
                    throw new Error('Invalid genre');
                }
                this._genre = newGenre;
            }
        });

        return book;
    }(item);

    var media = function (parent) {
        var media = Object.create(parent);

        media.init = function (description, name, duration, rating) {
            parent.init.call(this, description, name);
            this.duration = duration;
            this.rating = rating;
            return this;
        };

        Object.defineProperty(media, 'duration', {
            get: function () {
                return this._duration;
            },
            set: function (newDuration) {
                if (isNaN(newDuration) || newDuration < 0) {
                    throw new Error('Ivalid duration');
                }
                this._duration = newDuration;
            }
        });

        Object.defineProperty(media, 'rating', {
            get: function () {
                return this._rating;
            },
            set: function (newRating) {
                if (isNaN(newRating) || (newRating < 1 && newRating > 5)) {
                    throw new Error('Ivalid rating');
                }
                this._rating = newRating;
            }
        })
    }(item);

    var catalog = function () {
        var id = 0;
        var catalog = {
            init: function (name) {
                this.id = id += 1;
                this.name = name;
                this.items = [];
                return this;
            },

            get name() {
                return this._name;
            },
            set name(newName) {
                if (typeof newName !== 'string' || (newName.length < 2 && newName.length > 40)) {
                    throw new Error('Invalid Catalog-name');
                }
                this._name = newName;
            },

            add: function (items) {
                this.items.push.apply(this.items, items);
                return this;
            },

            find: function () {

            },

            search: function () {
                
            }
        };

        return catalog;
    }();

    var bookCatalog = function (parent) {
        var bookCatalog = Object.create(parent);

        bookCatalog.init = function (name) {
            parent.init.call(this, name);
            return this;
        };

        bookCatalog.add = function () {
            if (arguments.length === 1 && Array.isArray(arguments[0])) {
                parent.add.call(this, arguments);
            } else if (arguments.length) {
                var books = Array.prototype.slice.call(arguments);
                parent.add.call(this, books);
            } else {
                throw new Error('Invalid book to add');
            }
            return this;
        };

        bookCatalog.getGenres = function () {

        };

        bookCatalog.find = function () {

        };

        return bookCatalog;
    }(catalog);

    var mediaCatalog = function (parent) {
        var mediaCatalog = Object.create(parent);

        mediaCatalog.init = function (name) {
            parent.init.call(this, name);
            return this;
        };

        mediaCatalog.add = function () {

        };

        mediaCatalog.getTop = function () {

        };

        mediaCatalog.getSortedByDuration = function () {
            
        }
    }(catalog);

    return {
        getBook: function (name, isbn, genre, description) {
            return Object.create(book).init(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return Object.create(media).init(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return Object.create(bookCatalog).init(name);
        },
        getMediaCatalog: function (name) {
            return Object.create(mediaCatalog).init(name);
        }
    };
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add([book1, book2]);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1