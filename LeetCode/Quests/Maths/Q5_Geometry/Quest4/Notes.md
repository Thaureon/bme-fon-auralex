# LeetCode Geometry
## Quest 4
Rectangle Area
- Input: int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2
- Output: int[]

## Thought Process
- We are given 2 endpoints of 2 rectangles each.
- We need to get the total area covered by the 2 rectangles.
- We are always given the bottom left and top right corners.
- This would be a simple calculation of totalArea = area(a) + area(b) - overlap
- For the overlap we need to get the bottom right corner and the top right corner of the overlap square.
    - An initial check would be to see if the rectangles even overlap.
    - After that we need to get the two corners.
- Starting by getting the area of the two rectangles.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - Creating area of the first two rectangles was easy
        - Trying to figure out the area of the overlap was a bit more difficult
        - After some thought I figured out that I needed to move the top right position into the smallest position for the top right and the largest position for the bottom left.
        - This allowed me to see where exactly the points merged.
        - after this you can see if the area is covering any part of the current square by checking if the top right point is still the top right point. 

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 30.25 MB
