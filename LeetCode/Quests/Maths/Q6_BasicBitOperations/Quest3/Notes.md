# LeetCode Basic Bit Operations
## Quest 3
Sum of Two Integers
- Input: int a, int b
- Output: int

## Thought Process
- We need to add two numbers without using + or -.
- To get the sum we need to add both digits at each bit position
- We also care about if both bits are 1 then we need to increment the next value, IE a carry over.
- If we have a carry over we now care about 3 bits.
- For the carry over we need to know if a & b or a & carryOver or b& carryOver as we only need two of them.
- a simple calculation would be (a&b)|(a&c)|(b&c)
- if we have 3 we can just to a&b&c, but for 2, we need to check for each pair.  I don't know a better way to do it.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This was rather annoying to  try and figure out the entire process.
        - Basic bitwise checking was easy, but when I got to the annoying ammounts some issues started to arrise.
        - -1 is always nothing but 1s so all negative numbers will never run out of zeros.
            - This requires the number of shifts to be set at a max of in length (32).
        - This was unnecessarily complex as another solution used XOR and AND to get the sum/carry over.
        - This approach simplifies the code significantly.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 29.15 MB
