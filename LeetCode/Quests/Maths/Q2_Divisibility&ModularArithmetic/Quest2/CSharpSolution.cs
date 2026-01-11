public class Solution {
    public int PivotInteger(int n) {
        var pivotN = (n * (n+1))/2;

        var pivotValue = -1;
        for(int i = 1; i <= n; i++)
        {
            var pivotI = (i * (i+1))/2;
            if(pivotI == (pivotN + i)/2.0)
            {
                pivotValue = i;
                break;
            }
        }
        return pivotValue;
    }
}