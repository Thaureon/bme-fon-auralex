public class Solution
{
	public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
	{
		if (x1 <= xCenter && x2 >= xCenter && y1 <= yCenter && y2 >= yCenter)
		{
			return true;
		}

		if (xCenter + radius < x1 || xCenter - radius > x2 || yCenter + radius < y1 || yCenter - radius > y2)
		{
			return false;
		}
		
		if (xCenter + radius == x1 || xCenter - radius == x2 || yCenter + radius == y1 || yCenter - radius == y2)
		{
			return true;
		}
		
		if(xCenter + radius >= x2 && xCenter - radius <= x1 && yCenter + radius >= y2 && yCenter - radius <= y1)
		{
			return true;
		}

		var slopes = new double[]
		{
			(y1 - yCenter) / (double)(x1 - xCenter),
			(y1 - yCenter) / (double)(x2 - xCenter),
			(y2 - yCenter) / (double)(x1 - xCenter),
			(y2 - yCenter) / (double)(x2 - xCenter),
		};


		for (var i = 0; i < slopes.Length; i++)
		{
			var angle = Math.Atan(slopes[i]);

			var xPos1 = xCenter + radius * Math.Cos(angle);
			var yPos1 = yCenter + radius * Math.Sin(angle);
			var xPos2 = xCenter - radius * Math.Cos(angle);
			var yPos2 = yCenter - radius * Math.Sin(angle);

			if (x1 <= xPos1 && x2 >= xPos1 && y1 <= yPos1 && y2 >= yPos1)
			{
				return true;
			}
			if (x1 <= xPos2 && x2 >= xPos2 && y1 <= yPos2 && y2 >= yPos2)
			{
				return true;
			}
			if (x1 <= xPos1 && x2 >= xPos1 && y1 <= yPos2 && y2 >= yPos2)
			{
				return true;
			}
			if (x1 <= xPos2 && x2 >= xPos2 && y1 <= yPos1 && y2 >= yPos1)
			{
				return true;
			}
		}

		return false;
	}
}