public class Solution
{
	public bool FindRotation(int[][] mat, int[][] target)
	{
		var targetTotalCount = 0;
		var matTotalsCount = 0;
		UInt128 targetTotal = 0;
		var matTotals = new Dictionary<int, UInt128>
		{
			{0, 0},
			{1, 0},
			{2, 0},
			{3, 0}
		};
		
		for(var i = 0; i < mat.Length; i++)
		{
			for (var j = 0; j < mat.Length; j++)
			{
				if(target[i][j] != 0)
				{
					targetTotalCount++;
					var position = i * mat.Length + j;
					targetTotal += (UInt128)(1 << position);
				}
				if (mat[i][j] != 0)
				{
					matTotalsCount++;

					var tlPosition = i * mat.Length + j;
					matTotals[0] += (UInt128)(1 << tlPosition);

					var trPosition = mat.Length * mat.Length - ((mat.Length - i) + mat.Length * j);
					matTotals[1] += (UInt128)(1 << trPosition);
					
					var brPosition = mat.Length * mat.Length - (i * mat.Length + j) - 1;
					matTotals[2] += (UInt128)(1 << brPosition);

					var blPosition = (mat.Length - i) + mat.Length * j - 1;
					matTotals[3] += (UInt128)(1 << blPosition);
				}
			}
		}

		return targetTotalCount == matTotalsCount && matTotals.Any(x => x.Value == targetTotal);
	}
}