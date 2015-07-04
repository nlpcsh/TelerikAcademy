function sum(arr) {
    var i, len = arr.length , result = 0;
    if (len === 0) {
    	return null;
    }

    for (i = 0; i < len; i += 1) {
    	if (isNaN(+arr[i])) {
    		throw new Error('Not a number in the array!');
    	}
        result += +arr[i];
    }
    //console.log(result);
    return result;
}

// var arr = [1,2,3];
// sum(arr);
module.exports = sum;
