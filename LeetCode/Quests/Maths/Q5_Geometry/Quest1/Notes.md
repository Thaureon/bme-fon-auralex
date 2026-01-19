# LeetCode Geometry
## Quest 1
Projection Area of 3D Shapes
- Input: int[][] grid
- Output: int

## Thought Process
- This is a square grid
- We want 3 different projections top, front, and side.
- The return should be the total areas of these 3 projections.
- For each of the projections we can check different pieces.
    - Top down total we check if each position is 0 or not.  If it is 0, we do nothing, otherwise we add it to the top down total.
    - For the front and side, they are the same logic of just going through each row/column to get the highest for each one.
- This is complexity of O(n^2)

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - There wasn't any custom logic needed for this
        - We needed to check every cell for top to see how many squares existed.
        - For front we needed to check each column to see what the largest value was.
        - For side we needed to check each row to see what the largest value was.
        - With each of these needs we needed to go through the entire grid every time.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 1 MS
    - Memory - 43.04 MB
