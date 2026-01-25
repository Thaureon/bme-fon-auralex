# LeetCode Bitmasking for Sets/States
## Quest 1
Gray Code
- Input: int n
- Output: `IList<int>`

## Thought Process
- Given the length of the bits
- Starting with zero each value must differ by one bit
- I was initially thinking of using a stack to go back and forth over the values
- Each loop can easily be transfered back and forth by just adding a power of 2 to the previous list.
- I just need to figure out how to get the back and forth logic working correctly.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - The stack style ran into an issue when trying to move from one stack to another to flip back and forth.
        - After that I realized that just going from the back of the list to the front would do the exact same thing that I was trying to do with the stack.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 56.08 MB
