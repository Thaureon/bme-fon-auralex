# LeetCode Divisbility & Modular Arithmetic
## Quest 1
Ugly Number
- Input: int n
- Output: bool

## Thought Process
- Ugly number is a positive integer
- prive factors are only 2, 3, and 5
- easiest way would be keep dividing input by 2, 3, and 5 until none are possible, if final value is 1 then it is ugly.
- Modulus would allow the cycle to keep running until all are removed.
- As 2, 3, and 5 are not multiples of each other, the cycles can be independent.
- LeetCode Test Results give 0 and negative number a false expected value.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - As prime factors are set as 2, 3, and 5 this could just be checking each of them individually.
        - Adding the prime factors to a list allows the code to be simplified and allows expansion if other factors are desired.
        - The final result being checked against 1 will tell you if there are any other primes in the final result.
        - Having 1 after all multiples of 2, 3, and 5 means that they are the only factors.
        - Having 7 or other digits means there are other primes that still exist.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 31.16 MB
