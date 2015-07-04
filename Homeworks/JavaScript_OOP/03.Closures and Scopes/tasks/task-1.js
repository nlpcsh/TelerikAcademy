/* Task Description */
/* 
*   Create a module for working with books
    -   The module must provide the following functionalities:
        *   Add a new book to category
            *   Each book has unique title, author and ISBN
            *   It must return the newly created book with assigned ID
            *   If the category is missing, it must be automatically created
        *   List all books
            *   Books are sorted by ID
            *   This can be done by author, by category or all
        *   List all categories
            *   Categories are sorted by ID
    -   Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
        *   When adding a book/category, the ID is generated automatically
    -   Add validation everywhere, where possible
        *   Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
        *   Author is any non-empty string
        *   Unique params are Book title and Book ISBN
        *   Book ISBN is an unique code that contains either 10 or 13 digits
        *   If something is not valid - throw Error
*/
function solve() {

    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(arg) {
            var i,
                len = books.length,
                arg = arg || '',
                sorted = [];

            if (!arg) {
                return books;
            }

            sorted = books.filter(function(obj) {
                return obj.category === arg.category;
            });

            return sorted;
        }

        function addBook(book) {
            var i, len = books.length;

            if (!book.category) {
                book.category = 'Generic';
            }

            if (book.title.length < 2 || book.author.length > 100) {
                throw new Error('Title is not valid!');
            }

            for (i = 0; i < len; i += 1) {
                if (book.title === books[i].title) {
                    throw new Error('Book TITLE already exists in the library!');
                }
            }

            if (!book.author) {
                throw new Error('Author is not valid!');
            }

            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error('ISBN is not valid!');
            }

            for (i = 0; i < len; i += 1) {
                if (book.isbn === books[i].isbn) {
                    throw new Error('Book ISBN already exists in the library!');
                }
            }

            book.ID = books.length + 1;
            books.push(book);

            return book;
        }

        function listCategories(category) {
            var i,
                len,
                allCategoures = [],
                result = [];

            if (!books.length) {
                return books;
            }

            for (i = 0, len = books.length; i < len; i += 1) {
                allCategoures[i] = books[i].category;
            }

            result = allCategoures.filter(function(elem, index, self) {
                return index == self.indexOf(elem);
            });

            return result;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}

module.exports = solve;
