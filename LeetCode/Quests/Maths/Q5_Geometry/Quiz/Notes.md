# LeetCode Geometry
## Quiz
Circle and Rectangle Overlapping
- Input: int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2
- Output: bool

## Thought Process
- We need to check if the circle and square overlap.
- This can be at just a point.
- Initial check will be to see if circle's top, bottom, right, and left are farther out than the square.
- This would basically be checking if two squares don't overlap
- The next check would be if the square covers the circle's center.
- This can be done by just checking if the circles center is between the two points of the rectangle.
- The harder one will be to see if the sqare intersects with any point on the circle.

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - I did not like this problem.
        - This was just a bunch of if checks to see if each parameter was met.
        - Even with this there are some instances I don't think I handled appropriately.
        - Looking at other solutions there was a much simpler way to handle it.  I was not efficient at all with this problem.
        - I used Sin, Cos, and Tan while other solutions just used basic math.  It probably would have been better to use something like that instead of all of my guess and check methods.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 0 MS
    - Memory - 30.80 MB
