public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();

        for(var i = 1; i <= n; i++)
        {
            var remainingDigits = n - i;
            for(var j = result.Count - 1; j >= 0; j--)
            {
                var currentList = result[j];
                if(currentList.Count == k)
                {
                    continue;
                }
                if(remainingDigits >= k - currentList.Count) {
                    var recycledList = new List<int>(currentList);
                    result.Add(recycledList);
                }
                currentList.Add(i);
            }
            
            if(remainingDigits >= k - 1) {
                result.Add(new List<int> {i});
            }
        }

        return result.Where(x => x.Count == k).ToList();
    }
}