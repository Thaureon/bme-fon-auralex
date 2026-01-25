public class Solution
{
	public IList<int> GrayCode(int n)
	{
		var code = new List<int> { 0 };

		var newValue = 1;
		for (var i = 0; i < n; i++)
		{
			for(var j = code.Count - 1; j >= 0; j--)
			{
				var nextValue = code[j] + newValue;
				code.Add(nextValue);
			}
			
			newValue *= 2;
		}

		return code;
	}
}