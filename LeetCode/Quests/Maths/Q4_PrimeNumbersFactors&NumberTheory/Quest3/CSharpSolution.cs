public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        if(left == 1)
        {
            left++;
        }
        var maxRoot = (int)Math.Sqrt(right) + 1;
        var primeFactors = new bool[maxRoot];
        Array.Fill(primeFactors, true);

        var closestPrimes = new bool[right - left + 1];
        Array.Fill(closestPrimes, true);

        for(var i = 2; i < primeFactors.Length; i++)
        {
            if(!primeFactors[i])
            {
                continue;
            }
            for(var j = i + 1; j < primeFactors.Length; j++)
            {
                if(!primeFactors[j])
                {
                    continue;
                }
                if(j % i == 0)
                {
                    primeFactors[j] = false;
                }
            }
            for (var j = 0; j < closestPrimes.Length; j++)
			{
				var closetPrimeValue = j + left;
				
				if (!closestPrimes[j] || closetPrimeValue <= i)
				{
					continue;
				}
				if (closetPrimeValue % i == 0)
				{
					closestPrimes[j] = false;
				}
			}
        }
        var possiblePrimes = new List<int>();
        for(var i = 0; i < closestPrimes.Length; i++)
        {
            if(closestPrimes[i])
            {
                possiblePrimes.Add(i + left);
            }
        }
        if(possiblePrimes.Count <= 1)
        {
            return new int[2] {-1, -1};
        }

        var smallestPair = new int[2];
        var currentDistance = int.MaxValue;

        for(var i = 1; i < possiblePrimes.Count; i++)
        {
            var distance = possiblePrimes[i] - possiblePrimes[i-1];
            if(distance < currentDistance)
            {
                smallestPair[0] = possiblePrimes[i-1];
                smallestPair[1] = possiblePrimes[i];
                currentDistance = distance;
            }
            if(currentDistance <= 2)
            {
                break;
            }
        }
        return smallestPair;
    }
}