# LeetCode Divisbility & Modular Arithmetic
## Quest 3
Self Dividing Numbers
- Input: int left, int right
- Output: `IList<int>`

## Thought Process
- Need to iterate from left to right
- Only values that divide by all digits would stay
- Some shortcuts may be helpful, but useless. IE 1-9 are valid, values with only the same digit are valid.
- need to get each digit, can use math with %10 to get each digit.
- value % each digit is 0, then it is valid.
- digit of 0 will always not be valid, so any value with a 0 in it will never be in the final list.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - This solution was pretty simple outside of the missing 0 instance.
        - Checking each digit and shifting the value to get the next value allowed simple processing.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 4 MS
    - Memory - 36.31 MB
