# LeetCode Arithmetic & Basic Reasoning
## Quiz
Reverse Integer
- Input: int x
- Output: int

## Thought Process
- Input for x can be positive or negative
- Simple solution would be to start at back and create new number by shifting digits with x10 and /10.
- if input is negative output needs to be negative as well
- Missed instruction saying to set result to 0 if the output would be outside of the int range.
    - This change was fixed by converting the result to a long and seeing if it was outside of int.MaxValue and int.MinValue.

## Solutions
This problem was done before in LeetCode/Problems/Problem9, but trying to solve it using only math.
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Simple math was used to migrate from input to output using ida from above.
        - Multiple issues appeared when dealing with negative input.
        - The %10 to get the last digit would return a negative number when input was negative, so switching the input to positive was required.
        - While string conversion may be better, the math approach felt more appropriate and simpler.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 34.62 MB
