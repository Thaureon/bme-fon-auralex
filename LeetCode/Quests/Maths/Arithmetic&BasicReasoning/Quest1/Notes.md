# LeetCode Arithmetic & Basic Reasoning
## Quest 1
Can Make Arithmetic Progression From Sequence
- Input: int[] arr
- Output: bool

## Thought Process
- Input of arr does not have to be in order sort can be considered
- Problem makes arithmetic progression sound like the difference between any 2 numbers has to be the same for all pairs of elements
- 3,5,1 returns true because 1,3,5 each has a difference of 2
- 1,2,4 returns false because 1,2 has difference of 1 and 2,4 has difference of 2
- Sorting may be easies way then just start comparing neighbor digits until difference appears
- Without sort, every number would have to be compared to every other number
- With sort only neighbors would be compared bringing complexity down from O(n^2) to O(n) + O(n log(n))

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Using a sorted array made the solution simple with just a single loop.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 3 MS
    - Memory - 44.11 MB
