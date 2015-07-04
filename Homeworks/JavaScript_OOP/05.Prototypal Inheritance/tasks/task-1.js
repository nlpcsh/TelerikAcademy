/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta)

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'cuki')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function() {
        var domElement = {
            init: function(type) {
                this.type = type;
                return this;
            },
            appendChild: function(child) {
                this.children = child;
                return this;
            },
            addAttribute: function(name, value) {
                this.attributes = {
                    name: name,
                    value: value
                };
                return this;
            },
            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('No such attribute!');
                }
                delete this.attributes[attribute];
                return this;
            },
            get innerHTML() {
                var page, 
                    atr;

                page = '<' + this.type ;
                if (this.attributes) {
                    var currentAttr = this.attributes;
                    page += sortAttributes(currentAttr);
                }
                page += '>';

                if (this.content) {
                    page += this.content;
                }

                // if children present -> make recursion over them
                if (this.children) {
                    for (var child in this.children) {
                        if (typeof this.children[child] == 'string') {
                            page += this.children[child];
                        } else {
                            page += this.children[child].innerHTML;
                        }
                    }
                }
                page += '</' + this.type + '>';

                return page;
            }
        };

        Object.defineProperty(domElement, 'type', {
            get: function() {
                return this._type;
            },
            set: function(type) {
                if (isTypeValid(type)) {
                    this._type = type;
                }
            }
        });

        Object.defineProperty(domElement, 'attributes', {
            get: function() {
                return this._attributes;
            },
            set: function(attribute) {
                var name = attribute.name;
                var value = attribute.value;
                if (isAttributeValid(attribute)) {
                    this._attributes = this._attributes || {};
                    this._attributes[name] = value;
                }
            }
        });

        Object.defineProperty(domElement, 'content', {
            get: function() {
                return this._content || '' ;
            },
            set: function(content) {
                if (this.children) {
                    content = '';
                }
                if (typeof content !== 'string') {
                    throw new Error('Content must be string!');
                }
                this._content = content ;
            }
        });

        Object.defineProperty(domElement, 'children', {
            get: function () {
                return this._children;
            },
            set: function (child) {
                if (typeof child !== 'string' && typeof  (child._type) === 'undefined') {
                    throw new Error('Type of child is not valid');
                }
                if (typeof (child._type) !== 'undefined') {
                    child.parent = this;
                }

                this.content = '';
                this._children = this.children || [];
                this._children.push(child);
            }
        });

        function isTypeValid(text) {
            var re = /([A-Za-z0-9])/g,
                typeSymbol = text.match(re);
            if (text) {
                if (text.length !== typeSymbol.length) {
                    throw new Error('Bad characters in the type');
                }
                return true;
            } else {
                throw new Error('The type is empty');
            }
        }

        function isAttributeValid(attribute) {
            var re = /([A-Za-z0-9-])/g,
                name = attribute.name.match(re),
                value = ('' + attribute.value).match(re);

            if (attribute.name) {
                if (attribute.name.length !== name.length) {
                    throw new Error('Bad characters in the attrubute');
                }
                return true;
            } else {
                throw new Error('The attrubute is empty');
            }
        }

        function sortAttributes(attributes) {
            var result = '',
                key,
                keys = [],
                tmpAttributes = attributes;

            for (key in attributes) {
                keys.push(key);
            }

            keys = keys.sort(function (a, b) {
                return a > b;
            });
            for (key in keys) {
                result += ' ' + keys[key] + '="' + tmpAttributes[keys[key]] + '"';
            }
            return result;
        }

        return domElement;

    }());
    return domElement;
}

module.exports = solve;
