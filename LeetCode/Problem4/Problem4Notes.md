# LeetCode Problem 4
## Problem
Median of Two Sorted Arrays
- Input: int[] nums1, int[] nums2
- Output: double

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Total time 1 hr 30 min.
        - Initial thoughts got stuck on how to navigate from middle of each list to the median. This thought wasted 30+ minutes trying to figure it out.  This may be a valid solution, but not the best way to do it.
        - Multiple situations handled differently
            - Empty arrays -> return 0
            - One empty array -> return median of other array
            - One array completely before other array -> find middle when arrays combined
            - Random order between arrays -> left and right need to move inward together to find common middle.
        - Some Issues I ran into
            - Odd total length vs Even total Length
                - This was handled by treating the middle 2 digits of even and the middle 1 digit of odd as a left and right, then calculating the median.
            - Some edge cases were not thought out before developing solution.  So submission to LeetCode failed with these cases.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 2ms
    - Memory - 55.70 MB
