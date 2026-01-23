# LeetCode Basic Bit Operations
## Quest 1
Number of 1 Bits
- Input: int n
- Output: int

## Thought Process
- We need to get the number of bits that are 1 from the number provided.
- I was initially thinking of moving from the right to the left and doing calclulations from that bit.
- But a better solution would be
    - if odd -1 and +1 to bitCount
    - if even /2
- This solution would work, but I want to try and do it using bit math instead.
- To do that we need to get the last bit number
- Then we can do bit shifting to move the number down.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - For this I know how to do bit shifting, but wasn't sure the best way to get the last digit until I found that bitwise AND would do exactly that.
        - With that I was able to figure out a similar solution to what was above with only using bitwise operations.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 29.52 MB
