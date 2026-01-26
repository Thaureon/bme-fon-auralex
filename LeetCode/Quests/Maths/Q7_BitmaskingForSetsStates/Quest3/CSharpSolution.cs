public class Solution {
    public int SingleNumber(int[] nums) {
        var numCounter = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            var keyAdded = numCounter.TryAdd(num, 1);
			if (!keyAdded)
            {
                numCounter[num] += 1;

                if(numCounter[num] == 3)
                {
                    numCounter.Remove(num);
                }
            }
        }

        return numCounter.Single().Key;
    }
}