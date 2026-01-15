public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var allPascalRows = new List<IList<int>>();

		var previousRow = new int[1] { 1};
        allPascalRows.Add(previousRow.ToList());

        for(var i = 2; i <= numRows; i++)
        {
            var currentRow = new int[i];
            for(var j = 0; j < i; j++)
            {
                var previous = j - 1;
                var next = j;
                if(previous < 0)
                {
                    currentRow[j] = previousRow[next];
                }
                else if(next >= previousRow.Length)
                {
                    currentRow[j] = previousRow[previous];
                }
                else
				{
					currentRow[j] = previousRow[previous] + previousRow[next];
				}
			}

			previousRow = currentRow;
			allPascalRows.Add(previousRow.ToList());
		}

		return allPascalRows;
	}
}