public class Solution
{
	public int CountPrimes(int n)
	{
		if (n <= 2)
		{
			return 0;
		}

		var primeList = Enumerable.Range(2, n - 2).ToList();
		var finalPrimes = new List<int>();

		var maxCheckValue = (int)Math.Sqrt(n);

		while(primeList[0] <= maxCheckValue)
		{
			var firstPrime = primeList[0];
			primeList = primeList.Where(x => x % firstPrime != 0).ToList();
			
			finalPrimes.Add(firstPrime);
		}

		return finalPrimes.Count + primeList.Count;
	}
}