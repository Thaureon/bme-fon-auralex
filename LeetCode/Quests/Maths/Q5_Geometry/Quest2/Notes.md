# LeetCode Geometry
## Quest 2
Largets Triangle Area
- Input: int[][] points
- Output: double

## Thought Process
- Given a list of points, we need to get the 3 that have the largest size and return that size.
- First question is how do we get the area of a triangle with 3 points
- points [1,1], [2,4], [4,2]
    - The line slopes are 3/1, 1/3, and -2/2
    - Total area covered by a square is 9.
    - 3 can be removed for left and down from [1,1] - [2,4] and [1,1] - [4,2]
    - 2 can be remoed for top right from [2,4] - [4,2]
    - This gives this triangle a total area of 4
- Simple brute force solution would be to check every triple of points to see what triangle they make
- After that just return the area that was the most
- This solution would be O(n^3) though

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - I expected this to time out since I was just comparing every 3 pairs of points.
        - I did not know how to get the area of a triangle based on 3 points, this is not something that I would have figured out without looking it up.
        - In the end I found the "Shoelace formula"
        - This is a way to compare each of the points with the next point to get the final value for the area.
        - I'm still not sure exactly how it works, but it is simple.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 2 MS
    - Memory - 42.45 MB
