/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {

    var Person = (function() {

        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = +age;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function() {
                return this._firstname;
            },
            set: function(firstname) {
                if (validateNames(firstname)) {
                    this._firstname = firstname;
                }
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function() {
                return this._lastname;
            },
            set: function(lastname) {
                if (validateNames(lastname)) {
                    this._lastname = lastname;
                }
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function() {
                return this._age;
            },
            set: function(age) {
                if (0 < age && age < 150) {
                    this._age = age;
                } else {
                    throw new Error('Age is not valid!');
                }
                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this.firstname + ' ' + this.lastname;
            },
            set: function(value) {
                var names = value.split(' ');
                this._firstname = names[0];
                this._lastname = names[1];
                return this;
            }
        });

        Person.prototype.introduce = function() {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        function validateNames(name) {

            var validator = true,
                re = /[A-Za-z]/g;

            if (3 > name.length || name.length > 20) {
                throw new Error(name + ' is not valid');
            }

            if (name.match(re).length !== name.length) {
                throw new Error(name + ' is not valid');
            }

            return validator;
        }

        return Person;

    }());

    return Person;
}
module.exports = solve;
