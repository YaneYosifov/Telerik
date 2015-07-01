/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    return (function () {
        var Course = {
            init: function (title, presentations) {
                this.title = title;
                this.presentations = presentations;
                this.students = [];

                return this;
            },
            addStudent: function (name) {
                if (!isValidName(name)) {
                    throw 'Invalid name';
                }

                var names = name.split(' '),
                    studentID = this.students.length + 1;
                this.students.push({
                    firstname: names[0],
                    lastname: names[1],
                    id: studentID
                });

                return studentID;
            },
            getAllStudents: function () {
                return this.students;
            },
            submitHomework: function (studentID, homeworkID) {
                if (!isValidID(this.students, studentID)) {
                    throw 'Invalid student ID';
                }

                if (!isValidID(this.presentations, homeworkID)) {
                    throw 'Invalid homework ID';
                }
            },
            pushExamResults: function (results) {
                if (!Array.isArray(results)) {
                    throw 'Exams must be an array of objects';
                }

                var studentIDs = [],
                    studentID;

                for (var i = 0, len = results.length; i < len; i += 1) {
                    studentID = results[i].StudentID - 1;
                    studentIDs.forEach(function (element) {
                        if (studentIDs[element] == studentID) {
                            throw 'Students with same ID';
                        }
                    });
                    studentIDs.push(studentID);

                    if (studentID !== this.students.indexOf(this.students[studentID])) {
                        throw 'Invalid student ID';
                    }

                    if (isNaN(results[i].score)) {
                        throw 'Invalid score';
                    }
                }
            },
            getTopStudents: function () {
            }
        };

        Object.defineProperty(Course, 'title', {
            get: function () {
                return Course._title;
            },
            set: function (title) {
                if (!isValidTitle(title)) {
                    throw 'Invalid title';
                }
                Course._title = title;
            }
        });

        Object.defineProperty(Course, 'presentations', {
            get: function () {
                return Course._presentations;
            },
            set: function (presentations) {
                if (!presentations.length) {
                    throw 'There is no presentations';
                }

                presentations.forEach(function (element) {
                    if (!isValidTitle(element)) {
                        throw 'Invalid presentation title';
                    }
                });

                Course._presentations = presentations;
            }
        });

        function isValidTitle(title) {
            return /^[\w`~!@#$%^&*()\-_=+<>?,./;:'"{}\[\]\\|]+(\s[\w`~!@#$%^&*()\-_=+<>?,./;:'"{}\[\]\\|]+)*$/.test(title) &&
                /[^\s]{2}/.test(title);
        }

        function isValidName(name) {
            return /^[A-Z][-'a-zA-Z]*,?\s[A-Z][-'a-zA-Z]*$/.test(name);
        }

        function isValidID(arr, ID) {
            return arr[ID - 1];
        }

        return Course;
    }());
}

module.exports = solve;