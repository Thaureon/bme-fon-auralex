public class Solution {
    public int ProjectionArea(int[][] grid) {
        var topTotal = 0;
        var frontTotal = 0;
        var sideTotal = 0;

        for(var i = 0; i < grid.Length; i++)
        {
            var frontRowMax = 0;
            var sideRowMax = 0;
            for(var j = 0; j < grid.Length; j++)
            {
                if(grid[i][j] != 0)
                {
                    topTotal++;
                }
                if(frontRowMax < grid[i][j])
                {
                    frontRowMax = grid[i][j];
                }
                if(sideRowMax < grid[j][i])
                {
                    sideRowMax = grid[j][i];
                }
            }
            frontTotal += frontRowMax;
            sideTotal += sideRowMax;
        }

        return topTotal + frontTotal + sideTotal;
    }
}