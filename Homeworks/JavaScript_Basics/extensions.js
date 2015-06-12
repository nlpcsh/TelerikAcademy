(function() {
//
// String extensions
//
    if (!String.prototype.contains) {
        String.prototype.contains = function(searchPattern) {
            var patternLen = searchPattern.length;
            for (var i = 0, length = this.length - patternLen; i < length; i += 1) {
                var isMatch = true;
                for (var j = 0; j < patternLen; j += 1) {
                    if (searchPattern[j] !== this[i + j]) {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) {
                    return true;
                }
            }
        };
    }

    if (!String.prototype.toCharArray) {
        String.prototype.toCharArray = function() {
            return this.split("");
        };
    }

    if (!String.prototype.trimLeft) {
        String.prototype.trimLeft = function() {
            return this.replace(/^\s+/, "");
        };
    }
    if (!String.prototype.trimRight) {
        String.prototype.trimRight = function() {
            return this.replace(/\s+$/, "");
        };
    }

    if (!String.prototype.trim) {
        String.prototype.trim = function() {
            return this.trimLeft().trimRight();
        };
    }

    if (!String.prototype.trimLeftChars) {
        String.prototype.trimLeftChars = function(chars) {
            var regEx = new RegExp("^[" + chars + "]+");
            return this.replace(regEx, "");
        };
    }

    if (!String.prototype.trimRightChars) {
        String.prototype.trimRightChars = function(chars) {

            var regEx = new RegExp("[" + chars + "]+$");
            return this.replace(regEx, "");
        };
    }

    if (!String.prototype.trimChars) {
        String.prototype.trimChars = function(chars) {
            return this.trimLeftChars(chars).trimRightChars(chars);
        };
    }

    if (!String.prototype.htmlEscape) {
        String.prototype.htmlEscape = function() {
            return this.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;').replace(/"/g, '&quot;').replace(/'/g, "&#39").replace(/ /g, "&nbsp;");
        };
    }

    if (!String.prototype.padLeft) {
        String.prototype.padLeft = function(count, char) {
            char = char || " ";
            if (char.length > 1) {
                return String(this);
            }
            if (this.length >= count) {
                return String(this);
            }
            var str = String(this);
            for (var i = 0, thisLen = str.length; i < count - thisLen; i += 1) {
                str = char + str;
            }
            return str;
        };
    }

    if (!String.prototype.padRight) {
        String.prototype.padRight = function(count, char) {
            char = char || " ";
            if (char.length > 1) {
                return String(this);
            }
            if (this.length >= count) {
                return String(this);
            }
            var str = String(this);
            for (var i = 0, thisLen = this.length; i < count - thisLen; i += 1) {
                str += char;
            }
            return str;
        };
    }
//
// Array extensions
//
    if (!Array.prototype.remove) {
        Array.prototype.remove = function(arg, all) {
            for (var i = 0; i < this.length; i += 1) {
                if (this[i] === arg) {
                    this.splice(i, 1);

                    if (!all)
                        break;
                    else
                        i -= 1;
                }
            }
        };
    }

    //[].removeAt(pos)
    // Removes the element at the position
    if (!Array.prototype.removeAt) {
        Array.prototype.removeAt = function(position) {
            this.splice(position, 1);
        };
    }

    //[].clear()
    // Removes all elements of the array
    if (!Array.prototype.clear) {
        Array.prototype.clear = function() {
            this.length = 0;
        };
    }

    //[].insertAt(arg, pos)
    // Inserts an element at a given position
    if (!Array.prototype.insertAt) {
        Array.prototype.insertAt = function(arg, position) {
            this.splice(position, 0, arg);
        };
    }

    //[].contains(arg)
    // Checks if the array contains the given element
    if (!Array.prototype.contains) {
        Array.prototype.contains = function(arg) {
            for (var i = 0; i < this.length; i += 1)
                if (this[i] === arg)
                    return true;
            return false;
        };
    }

    //[].occurs(arg)
    // Counts the occurrences of a given element in array
    if (!Array.prototype.occurs) {
        Array.prototype.occurs = function(arg) {
            var counter = 0;

            for (var i = 0; i < this.length; i += 1) {
                if (this[i] === arg)
                    counter += 1;
            }

            return counter;
        };
    }

    if (!Array.prototype.find) {
        Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}
})();
