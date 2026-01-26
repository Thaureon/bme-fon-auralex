public class Solution
{
	public const int aVal = ((int)'a' - 1);
	public int MaxLength(IList<string> arr)
	{
		var validStrings = new Dictionary<int, int>();
		foreach (var str in arr)
		{
			var len = str.Length;
			var val = 0;
			foreach (var letter in str)
			{
				var charVal = 1 << (letter - aVal);
				if ((val & charVal) != 0)
				{
					val = 0;
					break;
				}
				val ^= charVal;
			}
			if (val != 0)
			{
				validStrings.TryAdd(val, len);
			}
		}
		if (!validStrings.Any())
		{
			return 0;
		}
		if (validStrings.Count == 1)
		{
			return validStrings.Single().Value;
		}
		var maxLength = 0;
		var validConcats = new List<(int Value, int Length)>();
		foreach(var validString in validStrings)
		{
			var validValue = validString.Key;
			var validLength = validString.Value;
			validConcats.Add((validValue, validLength));
            if (validLength > maxLength)
			{
				maxLength = validLength;
			}
			for(var i = validConcats.Count - 1; i >= 0; i--)
			{
				if((validValue & validConcats[i].Value) == 0)
				{
					var newValue = validValue | validConcats[i].Value;
					var newLength = validLength + validConcats[i].Length;
					validConcats.Add((newValue, newLength));
					
					if(newLength > maxLength)
					{
						maxLength = newLength;
					}
				}
			}
		}
		
		return maxLength;
	}
}