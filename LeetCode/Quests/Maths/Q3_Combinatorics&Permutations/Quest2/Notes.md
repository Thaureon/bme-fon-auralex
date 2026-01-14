# LeetCode Divisbility & Modular Arithmetic
## Quest 2
Smallest Integer Divisible by K
- Input: int k
- Output: int

## Thought Process
- Given positive integer
- n is divisbile by k
- n only contains the digit 1.
- This tells me that n will never be even, so all even values can be removed.
- Since 1 is the only digit, all multiples of 5 can be removed.
- 3 and 9 are easy since you just need to add digits together to get to that number
    - IE 111 is just 1+1+1 = 3, so 111 is divisible by 3
    - The same thing works for 9.
- digits that only have 1 in them like 11 and 111 are already there.
- n can be longer than 64 bits
- There should be some pattern that determines if a number is able to multiple into a number with just 1s.
- Can I use primes or previous successes?
    - 3 gives 3, 9 gives 9, 11 gives 2, so would 33 give 6?
    - 7 gives 6 digits
    - primes not having only 1s or 3 have formula of "length = prime - 1", this doesn't feel like it should work though
    - This is wrong as 101 * 11 = 1111 and 37 * 3 == 111
    - is it always true if prime has value then prime factors give result give final value, so 27 would require 27 digits?
- This would work if I had to get all of the primes, but if just given k. This might be excessive.
- I could go up, but it feels like there should be a formula for this.
- It feels like every odd digit except multiples of 5 would give a result.
- Using hint 1 and 2 and looking at the comments helped to understand the math behind it.
- Hint 1 was not very understandable without the comments
- Hint 2 makes sense if you exclude values that will never be able to get to the end like multiples of 2 and 5.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Initial solution with just adding digits to n until solution is found, time limit exceeded issue.
        - This solution does give the correct answers, but can take a while.
        - Initial solution was working, but needed minor tweeks to make sure that the remainer keeps itself down below what would be max.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 29.41 MB
