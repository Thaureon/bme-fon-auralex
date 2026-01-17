# LeetCode Divisbility & Modular Arithmetic
## Quiz
Simple Bank System
- Input: int n, int k
- Output: `IList<IList<int>>`

## Thought Process
- return each permutation from 1 to n of length k.
- Holding each value in a list, only adding those that have a length shorter than k
- if there are still values afterwards that would allow another list of length k, add another value to that list.
    - IE. n=4, k=2: 1 gets added at 1, 2 adds [1,2], [2], and [1] since there is still more digits after 2 that would have a pair with it.
    - This logic would allow [1,2] to be added as [1,2,3] and [1,2] when 3 is there.
- This might be better as a queue or stack since we would constantly be adding and removing from that list to get the final list.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Problem was a simple test of making sure that each set of digits that can be added would be added
        - Copying a list to a new list was not what I thought it was originally, I forgot it was just passing in the old list into a new list as a parameter.
        - I thought list had Length similar to arrays, but it seems they only have Count.  This caused some errors because of this.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 49 MS
    - Memory - 107.20 MB
