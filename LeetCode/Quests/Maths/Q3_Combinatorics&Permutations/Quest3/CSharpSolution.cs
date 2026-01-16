
public class Solution {
    public int RearrangeSticks(int n, int k) {
		if(n == k)
		{
			return 1;
		}
		if(k == 1)
		{
			return (int)RightPerms(n, k);
		}
		
		var permList = new int[n][];
		for(var i = 0; i < n; i++)
		{
			permList[i] = new int[k];
			for(int j = 0; j < k; j++)
			{
				long permValue = 1;
				if (i == j)
				{
					permValue = 1;
				}
				else if (j == 0)
				{
					permValue = (int)RightPerms(i + 1, j + 1);
				}
				else if (j > i)
				{
					permValue = 0;
				}
				else
				{
					permValue = permList[i - 1][j - 1] + i * (long)permList[i - 1][j];
				}
				permValue %= 1000000007;
				permList[i][j] = (int)permValue;
			}
		}

        return permList[n - 1][k - 1];
	}
	
	public long RightPerms(int n, int k)
	{
		long perms = 1;
		for(var i = n - 1; i >= k; i--)
		{
			perms *= i;
			perms %= 1000000007;
		}		
		return perms;
	}
}