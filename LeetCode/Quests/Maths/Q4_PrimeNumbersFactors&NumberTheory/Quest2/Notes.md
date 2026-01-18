# LeetCode Prime numbers, factors & number theory
## Quest 2
Factorial Trailing Zeros
- Input: int n
- Output: int

## Thought Process
- We need to figure out the number of trailing zeros that appear for n!
- We only get a zero if we have 5 * an even number.
- We can do this simply by dividing n by exponent of 5 until we get past the value
- 5, 10, 15, 20 return 1 zero each
- 25, 50, 75 return 2 zeros each
- 30, 35, 40, 45 should return 1 zero each
- 125 and its multiples return 3 zeros
- using this logic we only need to count each power of 5 until we pass the value of n.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This solution was simple when you can just ignore any number that will never give you a trailing 0, IE any digit ending in 1, 3, 7, or 9.
        - So you would only care about 5 as an odd number.
        - With this there are 2 multiples of 5 that you care about, odd multiples IE 5, and even multiples IE 10.
        - Even multiples you can just add the amount of zeros as this has 5 and the needed even to get to the trailing zero.
        - With odd multiples, you just need an even between the previous odd multiple and the current odd multiple.
        - As this will always be the case base 5 will always give you the even you need.
        - This only becomes an issue when you start getting powers of 5 IE 25.
        - These you need an extra even to balance out the 5s, but with how often they come up, you have run through multiple instances of 5 which give multiple instances of even digits.
        - This logic can be replicated for the remaining powers of 5 like 125, 625 and so on.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 29.34 MB
