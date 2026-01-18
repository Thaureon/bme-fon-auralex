# LeetCode Prime numbers, factors & number theory
## Quest 3
Closest Prime Numbers in Range
- Input: int left, int right
- Output: int[]

## Thought Process
- We need to go through every digit from left to right and see which ones are primes.
- From that list we need to get the first one with the smallest distance to the next one.
- Getting the smallest is easy as we would just go from the left on primes and move right if we hit the "smallest" we can just return that.
- The smallest is either 2-3, or a distance of 2.  Anything past that we would have to see if there is anything smaller.
- We can shortcut the check by verifying if a value is prime and then checking it against the distance between it and the last prime.
- If the distance is less than the current distance we have a new pair.
- This could be done similar to Quest1 from this section, but I want to see if there is a better way to do it.
- I wanted to avoid using the Sieve of Eratosthenes, but solution recommended it.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Even with trying to do the Sieve of Eratosthenes this is not exactly a simple solution.
        - We start with getting primes that from left to right.
        - We don't care about 1, so we can just move left to 2 if it starts at 1.
        - We also need to make sure that we don't remove the same value for its prime IE the check for multiples of 2 doesn't remove 2.
        - After we get the list of primes we just need to go through it and get the smallest set, which we can escape immediately if we have have a pair of size 1 or 2 as 2,3 is the only pair of distance 1 and all other prime pairs would be length 2 or more.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1764 MS
    - Memory - 47.20 MB
