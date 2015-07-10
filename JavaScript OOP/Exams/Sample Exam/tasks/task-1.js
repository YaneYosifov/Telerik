function solve() {
    if (!Array.prototype.findIndex) {
        Array.prototype.findIndex = function (predicate) {
            if (this == null) {
                throw new TypeError('Array.prototype.findIndex called on null or undefined');
            }
            if (typeof predicate !== 'function') {
                throw new TypeError('predicate must be a function');
            }
            var list = Object(this);
            var length = list.length >>> 0;
            var thisArg = arguments[1];
            var value;

            for (var i = 0; i < length; i++) {
                value = list[i];
                if (predicate.call(thisArg, value, i, list)) {
                    return i;
                }
            }
            return -1;
        };
    }

    function isValidString(str) {
        return typeof str === 'string' && (3 <= str.length && str.length <= 25);
    }

    function convertToValidId(id) {
        if (isNaN(id)) {
            id = id.id;
        }
        return id;
    }

    var player = function () {
        var id = 0;
        var player = {
            init: function (name) {
                this.id = id += 1;
                this.name = name;
                this.playlists = [];
                return this;
            },

            get name() {
                return this._name;
            },
            set name(newName) {
                if (!isValidString(newName)) {
                    throw new Error('Invalid player name');
                }
                this._name = newName;
            },

            addPlaylist: function (playlistToAdd) {
                this.playlists.push(playlistToAdd);
                return this;
            },

            getPlaylistById: function (id) {
                var index = this.playlists.findIndex(function (playlist) {
                    return playlist.id === id;
                });

                if (index < 0) {
                    return null;
                }

                return this.playlists[index];
            },

            removePlaylist: function (id) {
                if (isNaN(id)) {
                    throw new Error('Invalid playlist ID');
                }

                var index = this.playlists.findIndex(function (playlist) {
                    return playlist.id === id;
                });

                if (index < 0) {
                    throw new Error('Invalid playlist to remove');
                }

                this.playlists.splice(index, 1);
                return this;
            },

            listPlaylists: function (page, size) {
                throw new Error('Not implemented');
            },

            contains: function (playable, playlist) {
                //return true;
            },

            search: function (pattern) {
                //return [];
            }
        };

        return player;
    }();

    var playlist = function () {
        var id = 0;
        var playlist = {
            init: function (name) {
                this.id = id += 1;
                this.name = name;
                this.playables = [];
                return this;
            },

            get name() {
                return this._name;
            },
            set name(newName) {
                if (!isValidString(newName)) {
                    throw new Error('Invalid playlist name');
                }
                this._name = newName;
            },

            addPlayable: function (playable) {
                this.playables.push(playable);
                return this;
            },

            getPlayableById: function (id) {
                id = convertToValidId(id);

                var index = this.playables.findIndex(function (playable) {
                    return playable.id === id;
                });

                if (index < 0) {
                    return null;
                }

                return this.playables[index];
            },

            removePlayable: function (id) {
                id = convertToValidId(id);

                var index = this.playables.findIndex(function (playable) {
                    return playable.id === id;
                });

                if (index < 0) {
                    throw new Error('Invalid playable ID');
                }

                this.playables.splice(index, 1);
                return this;
            },

            listPlayables: function (page, size) {
                throw new Error('Not implemented');
            }
        };

        return playlist;
    }();

    var playable = function () {
        var id = 0;
        var playable = {
            init: function (title, author) {
                this.id = id += 1;
                this.title = title;
                this.author = author;
                return this;
            },

            get title() {
                return this._title;
            },
            set title(newTitle) {
                if (!isValidString(newTitle)) {
                    throw new Error('Invalid playable title');
                }
                this._title = newTitle;
            },

            get author() {
                return this._author;
            },
            set author(newAuthor) {
                if (!isValidString(newAuthor)) {
                    throw new Error('Invalid playable author');
                }
                this._author = newAuthor;
            },

            play: function () {
                return this.id + '. ' + this.title + ' - ' + this.author;
            }
        };

        return playable;
    }();

    var audio = function (parent) {
        var audio = Object.create(parent);

        audio.init = function (title, author, length) {
            parent.init.call(this, title, author);
            this.length = length;
            return this;
        };

        audio.play = function () {
            return parent.play.call(this) + ' - ' + this.length;
        };

        Object.defineProperty(audio, 'length', {
            get: function () {
                return this._length;
            },
            set: function (newLength) {
                if (isNaN(newLength) || newLength <= 0) {
                    throw new Error('Invalid audio length');
                }
                this._length = newLength;
            }
        })
    }(playable);

    var video = function (parent) {
        var video = Object.create(parent);

        video.init = function (title, author, imdbRating) {
            parent.init.call(this, title, author);
            this.imdbRating = imdbRating;
            return this;
        };

        video.play = function () {
            return parent.play.call(this) + ' - ' + this.imdbRating;
        };

        Object.defineProperty(video, 'imdbRating', {
            get: function () {
                return this._imdbRating;
            },
            set: function (newImdbRating) {
                if (isNaN(newImdbRating) || newImdbRating < 1 || 5 < newImdbRating) {
                    throw new Error('Invalid IMDb rating');
                }
                this._imdbRating = newImdbRating;
            }
        })
    }(playable);

    var module = {
        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };

    return module;
}

module.exports = solve;