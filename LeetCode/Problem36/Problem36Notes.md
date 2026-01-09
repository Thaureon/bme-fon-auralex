# LeetCode Problem 36
## Problem
Valid Soduku
- Input: int[] nums, int target
- Output: `IList<IList<int>>`

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Initial through was doing something similar to a rules engine. 
        - This would allow checking each row, column, and box to be checked separately .
        - This thought would also allow rules to be added or removed with ease.
        - Moving everything over to a char[] for row/column helped to limit the scope with each check, but didn't help when having to check each one again.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 12 MS
    - Memory - 50.70 MB
