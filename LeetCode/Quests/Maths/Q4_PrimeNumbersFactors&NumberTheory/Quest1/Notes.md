# LeetCode Prime numbers, factors & number theory
## Quest 1
Count Primes
- Input: int n
- Output: int

## Thought Process
- we need to get the number of primes from 0 to n
- inputs of 0, 1 return 0.
- every value after that we should check if it is divisible by any of our current primes.  If it isn't we can just add it to the list.
- We can use sqrt to get the max prime we want to use, but I want to avoid that.
- First iteration caused timeout with large number of primes due to unnecessary checking.
- to move to sqrt lets start with i/2
- even with math.Sqrt the solution is still giving a timeout.
- This current logic is O(n^2) as I am checking over all values of n, and looping over all values of n inside each of those.
- with 30, we have the primes 2,3,5,7,11,13,17,19,23,29
- 5*5 = 25, and 6*6 = 36, so once we get anything over 6 do we have to check against it?
- Missed rule strictly less than n.
    - This rule makes anything less than 2 return 0
    - This makes all primes return less than 1 of their value.
- My current solution works, but is timing out when submitting.
- Hint recommendds using the Sieve of Eratohthenes, which is a way to limit the amount from the entire list.
- Trying this, lets see what happens when we go through each of the primes from the initial list.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - While this is not the fastest way to handle it, it keeps the simple limit the remaining list of possible primes only to what we have until we get to the sqrt of the original number.  Anything past that we can guarantee are primes.
        - This limits the original list from 5000000 to 2500000 just by removing multiples of 2.
        - This continues for each of the digits in the list until all of the primes before sqrt(n) have been handled.
        - This pattern also deals with multiples of composite numbers like 6 where that is removed immediately with its first prime of 2. 

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1666 MS
    - Memory - 153.14 MB
