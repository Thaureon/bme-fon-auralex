# LeetCode Geometry
## Quest 3
Max Points on a Line
- Input: int[][] points
- Output: int

## Thought Process
- Given x,y coords of all points.
- All points are unique
- 1-300 total points
- First thought is get "slope" of two points and see what other points are on that slope
- Slope being purely vertical would only need to check if x is the same for everything.
- Slope being purely horizontal would only need to check if y is the same for everything.
- Simple formula is mx + b = y
- To get m we just take (x2 - x1)/(y2 - y1)
- To get b from that we need to figure out when y would be 0
- [1,1], [2,2] would have a slope of 1 as (2-1)/(2-1) = 1
- [2,1], [1,2] would have a slope of -1 and b would be 3
- you could get b by doing this
    - [2,1] => to get new point at x = 0, y - m(x - x`), this will give you 1 - (-1(2)) => 1--2 => 3.
    - So the way to get b is y - mx = b

## Solutions
- C#
    - FileName: CSharpSolution.cs
    - Notes:
        - With the calculations for a line defined, the issue became getting the pinpoint accuracy needed to make sure m and b were accurate enough to give a correct value.
        - This initially became an issue with a slope of 1/2 which needed decimal places.
        - But with the initial test of calculating m before hand, this caused some issues where the slope would not be accurate for later calculations.
        - With this I moved m calculations into the formula, I got more accuracy since I wasn't dealing with decimals immediately.
        - Moving this new m to the end also helped since this removed the decimal calculations until after multiplication was done allowing decimals only to be handled when necessary.
        - With this there was also another issue with precission that floats didn't allow requiring doubles to be used as a larger decimal handler.


## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 9 MS
    - Memory - 41.67 MB
