# LeetCode Prime numbers, factors & number theory
## Quiz
Mirror Reflection
- Input: int p, int q
- Output: int

## Thought Process
- We have a square room
- bottom left corner does not have a mirror, every other wall does
- p is length of wall
- q is how far up until it hits the right wall.
- return 0 for bottom right
- return 1 for top right
- return 2 for top left
- logic I am trying
    - p % q = val
    - q / val = top/bot 
        - if even return 0
        - if odd return 1/2
    - p / q = left/right
        - if even return 2
        - if odd return 1

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Some pieces of the solution were not fully thought through
        - There are multiple multiple points for the outputs.
            - if p == q we know that the lazor is going directly 
            - we then need to get p and q down to their lowest values without each having any other common multiples
        - We then can check to see whether we will end at the top or bottom and the left or right to determine what corner we end up at.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 29.00 MB
