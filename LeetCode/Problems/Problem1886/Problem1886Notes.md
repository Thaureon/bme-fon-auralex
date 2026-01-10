# LeetCode Problem 1886
## Problem
Determine Whether Matrix Can Be Obtained By Rotation
- Input: int[][] mat, int[][] target 
- Output: bool

## Solutions
Each is a valid solution, but with a altered solution.
- C# Solution 1
    - FileName: CSharpSolution.cs
    - Notes:
        - The solution I chose was to get the "total" of each of the matrix and compare them.
        - I went about using bitwise but ran into an issue when the matrix size began to get too big.
        - Using bit wise would translate every position to be 2^(rotated position).
        - This is fine until you get into larger sizes as the max size of the matrix is 10x10.
        - With the max size of the matrix the largest position value would be 2^100 which is more bits than both int and long.
- C# Solution 2
    - FileName: CSharpSolution2.cs
    - Notes:
        - After taking solution 1's notes into consideration I looked for an int that would be over 100 bits long which is Int128/UInt128.
        - This allowed me to get rid of the usage of BigInteger as just specifying a UInt128 would save overhead of BigInteger.
        - Along with this I moved to bit shifting instead of using Math.Pow.  This allowed me to just focus on 1 bit instead of the total value of 2.
        - With these 2 changes the time dropped by 3 times, while other solutions may just check the values of the position based on the rotation, checking the value based on the position of the rotation is a different approach.

## Statistics
According to LeetCode Runtime Analysis.
- C# Solution 1
    - Runtime - 17 MS
    - Memory - 46.00 MB
- C# Solution 2
    - Runtime - 6 MS
    - Memory - 44.35 MB
