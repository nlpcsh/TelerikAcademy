var Course = {
    init: function(title, presentations) {
        this.title = title;
        this.presentations = presentations;
        this.students = [];
        return this;
    },

    addStudent: function(name) {

    },

    getAllStudents: function() {

    },

    submitHomework: function(studentID, homeworkID) {

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
