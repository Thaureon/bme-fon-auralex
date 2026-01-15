# LeetCode Combinatorics & Permutations
## Quest 2
Pascal's Triangle
- Input: int numRows
- Output: `IList<IList<int>>`

## Thought Process
- Pascal's triangle is a simple problem of just adding the 2 above it to get the next value.
- Need to return all rows numRows of the triangle.
- Simple case would be have current row, and previous row and get values from previous row to add to current row.
- Finally adding current row to final list.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Keeping the previous row helped to get the next row easier instead of having to recalculate the value every time.
        - Logic was a bit difficult to fully wrap my head around since I was grabbing the same value and previous value in terms of arrays.
        - But once that logic was fully understood the only 2 values that mattered were the first and last value which only cared about the "next" or "previous" values.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 40.32 MB
