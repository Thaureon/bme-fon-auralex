# LeetCode Bitmasking for Sets/States
## Quiz
Maximum Length of a Concatenated String with Unique Characters
- Input: `IList<string> arr`
- Output: int

## Thought Process
- We are given a list of strings and need to figure out which ones have unique lengths.
- Since there are only 26 characters each one can have a different bit.
- We need to convert the letter into it's numeric place first.
- We can then do bit shifting to add a 1 to that postion.
- This will give us a length and a value for each string.
- With this we can also check to see which substrings have duplicate letters.
- Only giving the list of valid substrings.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - With a list of valid strings that are permitted, the issue then became how do I get all of the concatenated pairs that would go with it.
        - This made me think of the GrayCode solution(Quest 1 of this section)
        - In that it went through every number and compared it to all of the previous pairs.
        - This was done similar, check every pair and see what values actually remained if any pairs were valid concatenations.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 4 MS
    - Memory - 43.24 MB
