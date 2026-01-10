# LeetCode Problem 18
## Problem
4Sum
- Input: int[] nums, int target
- Output: `IList<IList<int>>`

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Status: Failed in 1 hour
    - Notes:
        - Attempted to use solution while not sorting list.
        - Challenges occurred when trying to get unique list of soluctions.
        - Solutions seems valid but times out with larger list limits.
        - Distinct default behaviour uses a HashSet to determine which objects are distinct.  As objects have unique HashCodes Distinct would not return a unique list.
        - Queues helped with going through entire list, but issues arose when dealing with lists as updating the list with a new num would update the list in the queue.  So new lists would be needed every num for both the current list with and without the num.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - Timeout
