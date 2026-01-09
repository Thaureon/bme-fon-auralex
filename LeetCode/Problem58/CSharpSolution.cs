public class Solution
{
	public int LengthOfLastWord(string s)
	{
		var lastWord = s.Split(' ').Where(x => x.Length > 0).LastOrDefault();

		return lastWord.Length;
	}
}