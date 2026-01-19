public class Solution
{
	public double LargestTriangleArea(int[][] points)
	{
		var largestArea = 0.0;

		for (var i = 0; i < points.Length; i++)
		{
			for (var j = i + 1; j < points.Length; j++)
			{
				for (var k = j + 1; k < points.Length; k++)
				{
					var area = CalculateTriangleArea(points[i], points[j], points[k]);
					if (area > largestArea)
					{
						largestArea = area;
					}
				}
			}
		}

		return largestArea;
	}

	public double CalculateTriangleArea(int[] pointA, int[] pointB, int[] pointC)
	{
		var ab = pointA[0] * pointB[1] - pointA[1] * pointB[0];
		var bc = pointB[0] * pointC[1] - pointB[1] * pointC[0];
		var ac = pointC[0] * pointA[1] - pointC[1] * pointA[0];
		var area = (ab + bc + ac) / 2.0;
		if (area < 0)
		{
			area *= -1;
		}
		return area;
	}
}