/* Task Description */
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
    var Course = {

        init: function(title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },

        addStudent: function(name) {
            this.name = name;

            var firstName = this.name.split(' ')[0],
                lastName = this.name.split(' ')[1];

            student = {
                firstname: firstName,
                lastname: lastName,
                score: 0,
                id: this.students.length + 1
            };

            this.students.push(student);
            return student.id;
        },

        getAllStudents: function() {
            return this.students.slice(0);
        },

        submitHomework: function(studentID, homeworkID) {
            this.studentID = studentID;
            this.homeworkID = homeworkID;
        },

        pushExamResults: function(results) {

        },

        getTopStudents: function() {

        }
    };

    Object.defineProperty(Course, 'title', {
        get: function() {
            return this._title;
        },
        set: function(title) {
            if (isTypeValid(title)) {
                this._title = title;
            }
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function() {
            return this._presentations;
        },
        set: function(presentations) {
            var lastHomeworkId = 0;
            if (presentations === undefined || presentations.length === 0) {
                throw new Error('One presentation need to present!');
            }
            presentations.forEach(function(title) {
                if (/^\s|\s$|\s{2,}/.test(title) || title.length < 1) {
                    throw new Error('Invalid presentation name');
                }
            });
            presentations.forEach(function(title) {
                presentation = {
                    title: title,
                    id: ++lastHomeworkId
                };
                presentations.push(presentation);
            });
            this._presentations = presentations;
        }
    });

    Object.defineProperty(Course, 'name', {
        get: function() {
            return this._name;
        },
        set: function(name) {
            if (isNameValid(name)) {
                this._name = name;
            }
        }
    });

    Object.defineProperty(Course, 'studentID', {
        get: function() {
            return this._studentID;
        },
        set: function(studentID) {
            var totalStudents = this.students.length || 1;
            if (isNaN(studentID) || (studentID < 1) || (studentID > totalStudents) || (studentID !== (studentID | 0))) {
                throw new Error('Student ID is not valid!');
            }
            this._studentID = studentID;
        }
    });

    Object.defineProperty(Course, 'homeworkID', {
        get: function() {
            return this._homeworkID;
        },
        set: function(homeworkID) {
            var totalPresentations = this.presentations.lenght || 1;
            if (isNaN(homeworkID) || (homeworkID < 1) || (homeworkID > totalPresentations) || (homeworkID !== (homeworkID | 0))) {
                throw new Error('Homework ID is not valid!');
            }
            this._homeworkID = homeworkID;
        }
    });


    function isTypeValid(title) {
        if (!title) {
            throw new Error("Title can not be empty!");
        }

        var re = /^ | $|  +/g;

        if (re.test(title)) {
            throw new Error("Title can not start, end or have more than 1 'space'!");
        }
        return true;
    }

    function isNameValid(name) {
        if (!name) {
            throw new Error('Name can not be empty!');
        }

        var re = /^[A-Z][a-z]*\s([A-Z]{1}[a-z]*)$/g;

        if (!re.test(name)) {
            throw new Error('Name of the student contains bad characters!');
        }

        return true;
    }

    return Course;
}


module.exports = solve;
