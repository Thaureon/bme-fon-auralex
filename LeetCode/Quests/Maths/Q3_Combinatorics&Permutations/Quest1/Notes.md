# LeetCode Combinatorics & Permutations
## Quest 1
Permutation Sequence
- Input: int n, int k
- Output: string

## Thought Process
- How many permutations exist for given n input.
    - 4 would have 4! = 24
- Can we use list of remaining digits with placeholder for modulus counter.
    - IE n = 4. which gives 24 total permutations. which gives 6 types of permutations for each.
    - input k = 9 means it starts in the second section of the permutations.
    - 9 mod 6 gives 3 which means it is on the 3rd permutations of the second section of permutations.
- n is between 1 and 9, creating a simple bool array to hold if it has been used is easy.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Solution was basic math, but ran into an issue when processing k.
        - processing logic was basing it on the idea that k is 0 based, while k was initially 1 based.
        - Making this adjustment to the first index allowed the full logic to function correctly.
        - StringBuilder would be more correct for dealing with adding strings together, but for simple strings like this there wasn't much need.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 9 MS
    - Memory - 40.13 MB
