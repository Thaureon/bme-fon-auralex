public class Solution
{
	public bool IsValidSudoku(char[][] board)
	{
		return AllValidRows(board) && AllValidColumns(board) && AllValidBoxes(board);
	}

	public bool AllValidRows(char[][] board)
	{
		var allRowsValid = true;
		foreach (var row in board)
		{
			allRowsValid &= IsValidSet(row);
		}
		return allRowsValid;
	}

	public bool AllValidColumns(char[][] board)
	{
		var allColumnsValid = true;
		for (var columnNum = 0; columnNum < board.Length; columnNum++)
		{
			var column = new char[9];
			for(var rowNum = 0; rowNum < board.Length; rowNum++)
			{
				column[rowNum] = board[rowNum][columnNum];
			}
			allColumnsValid &= IsValidSet(column);
		}
		return allColumnsValid;
	}

	public bool AllValidBoxes(char[][] board)
	{
		var allBoxesValid = true;
		for (var boxNum = 0; boxNum < 9; boxNum++)
		{
			var box = new char[9];
			for(var cell = 0; cell < 9; cell++)
			{
				var rowNum = cell / 3 + (boxNum / 3) * 3;
				var columnNum = cell % 3 + (boxNum % 3) * 3;
				
				box[cell] = board[rowNum][columnNum];
			}
			allBoxesValid &= IsValidSet(box);
		}
		return allBoxesValid;
	}

	public bool IsValidSet(char[] set)
	{
		var validSodukuCells = set.Where(x => x != '.');
		return validSodukuCells.Count() == validSodukuCells.Distinct().Count();
	}
}