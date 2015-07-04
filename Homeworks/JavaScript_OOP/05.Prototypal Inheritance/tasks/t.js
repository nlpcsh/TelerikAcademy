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
        removeAttribute: function(attribute) {
            if (!this.attributes[attribute]) {
                throw new Error('No such attribute!');
            }
            delete this.attributes[attribute];
            return this;
        },
        get innerHTML() {
            var page, atr;

            page = '<' + this.type;
            if (this.attributes) {
                var currentAttr = this.attributes;
                // for (atr in this.attributes) {
                //     page += ' ' + atr + '="' + this.attributes[atr] + '"';
                // }
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
            var name = attribute.name,
                value = attribute.value;
            if (isAttributeValid(attribute)) {
                this._attributes = this._attributes || {};
                this._attributes[name] = value;
            }
        }
    });

    // Object.defineProperty(domElement, 'attributes', {
    //     get: function() {
    //         return this._attributes;

    //     },
    //     set: function(attribute) {
    //         var name = attribute.name;
    //         var value = attribute.value;
    //         if (!(/^[A-Za-z0-9-]{1,}$/i).test(name)) {
    //             throw new Error('Valid attribute name must contain only Latin letters, digits or dashes and must not be an empty string!');
    //         }
    //         this._attributes = this._attributes || [];
    //         this._attributes[name] = value;
    //     }
    // });

    Object.defineProperty(domElement, 'content', {
        get: function() {
            return this._content || '';
        },
        set: function(content) {
            if (this.children) {
                content = '';
            }
            if (typeof content !== 'string') {
                throw new Error('Content must be string!');
            }
            this._content = content;
        }
    });

    Object.defineProperty(domElement, 'children', {
        get: function() {
            return this._children;
        },
        set: function(child) {
            if (typeof child !== 'string' && typeof(child._type) === 'undefined') {
                throw new Error('Type of child is not valid');
            }
            if (typeof(child._type) !== 'undefined') {
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
            if (attribute.name.length !== name.length
                //|| attribute.value.length !== value.length
            ) {
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

        keys = keys.sort(function(a, b) {
            return a > b;
        });
        for (key in keys) {
            result += ' ' + keys[key] + '="' + tmpAttributes[keys[key]] + '"';
        }
        return result;
    }

    return domElement;

}());

// var meta = Object.create(domElement)
//     .init('meta')
//     .addAttribute('charset', 'utf-8');

// console.log(meta.innerHTML);

var root = Object.create(domElement)
                .init('whateverTag')
                .addAttribute('something', 42);
console.log(root.innerHTML);
/*
var head = Object.create(domElement)
    .init('head')
    .appendChild(meta);

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
*/
