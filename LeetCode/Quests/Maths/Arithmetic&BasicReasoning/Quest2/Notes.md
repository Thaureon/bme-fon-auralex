# LeetCode Arithmetic & Basic Reasoning
## Quest 2
Find the Pivot Integer
- Input: int n
- Output: int

## Thought Process
- Pivot point takes total up to pivot and total from pivot to n and compares them.
- n = 8 has 1-6 = 6-8 = 21
- return -1 if no value for pivot exists
- Sum of 8 = 36 (8 * 8 / 2 + 8 / 2) => 8 * 8/2 + 8/2 => 8 * 4 + 4 => 32 + 4 => 36
- Sum of 7 = 28 (7 * 7/2 + 7/2)? => 7 * 7/2 + 7/2 => 7 * 3.5 + 3.5 => 24.5 + 3.5 => 28
- Sum of n = n * n/2 + n/2 => (n^2)/2 + n/2 => (n^2 + n)/2 => (n*(n+1))/2
- Sum of 8 with formula = (8^2 + 8)/2 => (64 + 8)/2 => 72/2 => 36
- Sum of 7 with formula = (7*(7+1))/2 => (7*8)/2 => 56/2 => 28
- Formula to get value at position = (n*(n+1))/2
- To determine if Pivot exists take pivot at (pivot(n) + pivotValue)/2 = pivot(pivotValue)
- Case 4 fails returns 3 Pivot(4) == 10, Pivot(3) = 6, Pivot(4) + 3 = 13 -> 6.5 -> 6 when casting as int.
- Because of case 4's info need to make sure decimal is preserved when comparing pivots.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - With simple math solution as above, the calculation in c# was straight forward.
        - Some pieces were missed, like comparing pivot(pivotValue) to pivot(n) instead of adding the pivot value and dividing by 2.
        - Case 4 was a missed point since C# automatically converts to int when doing calculations on ints.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 29.28 MB
