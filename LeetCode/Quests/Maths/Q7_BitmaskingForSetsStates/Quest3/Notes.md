# LeetCode Bitmasking for Sets/States
## Quest 3
Single Number II
- Input: int[] a
- Output: int

## Thought Process
- This is a similar problem to Single Number I, but each duplicate appears 3 times.
- The previous problem was easier because of bit flipping, where the first number would turn on the value, and the second would turn off the value.
- Since there are 3 number a different approach will be needed.
- A simple way would be to create a dictionary and add every digit to that while counting only returning the value that has 1 value left.
- At the same time we can check to see which value has 3 and just remove it from the list.
- This will work, but can have larger memory issues than desired.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This solution did work and was relatively quick.
        - Looking at other solutions I found that they thought about it like a 3 bit binary check.
        - Basically increasing each binary counter for first and second bit to show if 3 have been verified.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 43.69 MB
