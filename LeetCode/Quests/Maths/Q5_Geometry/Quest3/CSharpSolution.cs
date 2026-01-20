public class Solution {
    public int MaxPoints(int[][] points) {
        var maxPoints = 1;
        if(points.Length == 1)
        {
            return maxPoints;
        }

        for(var i = 0; i < points.Length; i++)
        {
            for(var j = i + 1; j < points.Length; j++)
            {
                var pointsOnLine = 2;

                if(points[j][0] == points[i][0])
                {
                    for(var k = j + 1; k < points.Length; k++)
                    {
                        if(points[k][0] == points[i][0])
                        {
                            pointsOnLine++;
                        }
                    }
                }
                else
                {
					var yDistance = points[j][1] - points[i][1];
					float xDistance = points[j][0] - points[i][0];
					var b = points[i][1] - points[i][0] * yDistance / xDistance;
					for (var k = j + 1; k < points.Length; k++)
					{
						var expectedY = points[k][0] * yDistance / xDistance + b;
						if (points[k][1] == expectedY)
						{
							pointsOnLine++;
						}
					}
                }

                if(pointsOnLine > maxPoints)
                {
                    maxPoints = pointsOnLine;
                }
            }
        }

        return maxPoints;
    }
}