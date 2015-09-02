/* globals $ */

/* 
Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    return function(selector, count) {
        var domRoot, list, i, len ;

        if (typeof(selector) !== 'string')  {
            throw new Error('Input error of the selector!');
        }
        if (isNaN(count) || count < 1){
            throw new Error('Input error of the counter!');
        }

        domRoot = $(selector);
        list = $('<ul />').addClass('items-list');

        for (i = 0, len = count; i < len; i += 1) {
            list.append('<li class="list-item">List item #'+ i +'</li>');
        }
        domRoot.append(list);
    };
}

module.exports = solve;
