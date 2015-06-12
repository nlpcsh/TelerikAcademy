// input data from BGcoder
function solve(params){
    console.log(params);
}

// get input from function args:
var sizes = args[0].split(' ').map(Number),
	rows = sizes[0],
	cols = sizes[1],
	lab = args.slice(1).map(function (line) {
			return line.split(' ');
		});
// n ^ m
function nInPowerM(n,m) {
	var result = 1,
	i;
	for (i = 0; i < m; i += 1) {
		result *= n;
	}
	return result;
}

// set default value
end = end || arr.length;

// concatenate array
console.log('eekDays = ' + weekDays.join(', '));

// (1 << power) <=> Math.pow(2, power)

// get object keys
var keyNames = Object.keys(obj);

// get number of object keys
var len = Object.keys(obj).length;

// sort as numbers
array.sort(function(a, b) {
    return a - b;
});

var pattern = '\\{' + i + '\\}';
var regex = new RegExp(pattern, 'g');

var pattern = / .,!\-/gim;
var text = 'Some, text and s';
var words = text.split(text).filter(function(word) {
    return !!word; // removes all '' elements in the array!!!
})


var pattern = /(\w+)/g;
var text = 'Telerik Academy';
var words = text.replace(pattern, '<span>$1</span>');

console.log(words);
