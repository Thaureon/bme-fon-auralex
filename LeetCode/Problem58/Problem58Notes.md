# LeetCode Problem 58
## Problem
Length of Last Word
- Input: string s
- Output: int

## Solutions
Each is a valid solution, but with different 
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Problem needed to get length of last word, this can be done using Linq.
        - Linq allows you to create lists based on conditions and return only when iterated over.
        - Linq is also more readable than other solutions.
        - Instead of having a for loop or trying to get the last item manually, linq allows you to just select through Last/LastOrDefault.
- java
    - FileName: CSharpSolution.java
    - Notes:
        - Linq doesn't exist so a more "manual" way of checking would be needed.
        - Iteration over list of words until a non-empty word is found at the back.
- C++
    - FileName: CppSolution.cpp
    - Notes:
        - Different approach from the previous.
        - Instead of splitting, just checking the string backwords until a word is found and then getting the length of that word.
- Python3
    - FileName: Python3Solution.py
    - Notes:
        - Similar to Java solution, but simplifying it a bit with trimming unnecessary white space from the end of the initial string.
        - This allows to just grab the last item in the list from split instead of trying to find the last word from empty items.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 40.19 MB
- Java
    - Runtime - 1 MS
    - Memory - 42.98 MB
- C++
    - Runtime - 0 MS
    - Memory - 8.86 MB
- Python3
    - Runtime - 0 MS
    - Memory - 19.28 MB
