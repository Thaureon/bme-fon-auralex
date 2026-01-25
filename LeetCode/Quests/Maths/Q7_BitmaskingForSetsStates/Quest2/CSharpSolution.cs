public class Solution
{
	public int CountDigitOne(int n)
	{
		var ones = 0;
		var multiplier = 1;
		while (n >= multiplier)
		{
			var possibleOnes = (n / (multiplier * 10)) + 1;
			var remainder = n % (multiplier * 10);
			var extraOnes = 0;
			if (remainder / multiplier <= 1)
			{
				possibleOnes--;
			}

			if (remainder / multiplier == 1)
			{
				extraOnes = (n % multiplier) + 1;
			}

			ones += possibleOnes * multiplier + extraOnes;

			multiplier *= 10;
		}
		return ones;
	}
}