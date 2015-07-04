function findPrimes(from, to) {
    var i, len, divisor, primes = [],
        isPrime, maxDevisor;
    if (typeof(from) === 'undefined' || typeof(to) === 'undefined') {
        throw new Error('The findPrimes() must have arguments!');
    }
    from = +from;
    to = +to;

    for (i = from; i <= to; i += 1) {
        maxDevisor = Math.sqrt(i);
        isPrime = true;
        for (divisor = 2; divisor <= maxDevisor; divisor += 1) {
            if (!(i % divisor)) {
                isPrime = false;
                break;
            }
        }
        if (isPrime && i > 1) {
            primes.push(i);
        }
    }
    //console.log(primes);
    return primes;
}

//findPrimes(1,5);

module.exports = findPrimes;
