# LeetCode Basic Bit Operations
## Quest 2
Single Number
- Input: int[] nums
- Output: int

## Thought Process
- They are asking for linear runtime and constant space usage.
- We are given a list of nums
- Every number is in that list twice except for 1 which only appears once.
- I am thinking of doing a bit flip.
- Every number flips its bits in the final number.
- If there are 2 numbers they would flip to have that number and then flip to remove that number.
- This would leave just the number with the single instance left.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - The function I wanted was ^ which is to be used for xor.
        - xor is a function that will only flip the bit if it exists in the new number.
        - This functionallity is exactly what is needed to make sure that a number is added the first time and removed the second time.
        - This is because x^3 sets the bits as 11
        - Next if x^5 happens this sets the bits as 11^101 = 110 fliping only the bits from the 5.
        - Next if x^3 happens again this sets the bits as 110^11 = 101 flipping the bits of the 3 returning the final value to 5.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 46.81 MB
