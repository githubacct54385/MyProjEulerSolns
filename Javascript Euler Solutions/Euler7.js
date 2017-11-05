
// NOTE: Work in progress...
function FindNthPrime(n) {
    var primesList =  SieveEratosthenes(n, -1);
    
    
    
    for(var i = 0; i < primesList.length; i++) {
        print(i + 1 + "th prime: " + primesList[i]);
    }
}

// Params: 
// 1) maxBound - Finds primes under maxBound
// 2) numPrimes - If set <= 0, finds all primes under maxBound.  Otherwise, finds this many primes.
function SieveEratosthenes(maxBound, numPrimes) {
    
    var primes = [];
    var upperLimit = Math.sqrt(maxBound);
    var output = [];
    for(var i = 2; i < maxBound; i++){
        primes.push(true);
    }
    
    for(var i = 2; i <= upperLimit; i++) {
        if(primes[i]) {
            for(var j = i * i; j < maxBound; j += i) {
                primes[j] = false;
            }
        }
    }
    if(numPrimes >= 0) {
        for(var i = 2; i < primes.length && output.length < numPrimes; i++) {
            if(primes[i]) {
                output.push(i);
            }
        }    
    } else {
        for(var i = 2; i < primes.length; i++) {
            if(primes[i]) {
                output.push(i);
            }
        }
    }
    
    return output;
}

FindNthPrime(4000000);
