public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var distinctSets = new HashSet<IList<int>>();

		var possibleSets = new Queue<List<int>>();

		foreach (var num in nums)
		{
			var nextLoop = new Queue<List<int>>();
			while(possibleSets.Any())
			{
				var set = possibleSets.Dequeue();
				nextLoop.Enqueue(set.ToList());
				set.Add(num);
				if(set.Count() != 4)
				{
					nextLoop.Enqueue(set);
					continue;
				}
				if(set.Sum() == target)
				{
					distinctSets.Add(set);
				}
			}
			
			nextLoop.Enqueue(new List<int> { num });
			possibleSets = nextLoop;
		}
		
		return distinctSets.DistinctBy(x => string.Join(",", x.OrderBy(y => y))).ToList();
	}
}
