public class Solution {
    public int TrailingZeroes(int n) {
        var trailingZeros = 0;

        for(var fivePow = 5; fivePow <= n; fivePow *= 5)
        {
            trailingZeros += n / fivePow;
        }

        return trailingZeros;
    }
}