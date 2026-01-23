public class Solution {
    public int HammingWeight(int n) {
        var bitCount = 0;
        while(n != 0)
        {
            if((n & 1) == 1)
            {
                bitCount++;
            }
            n = n >> 1;
        }
        return bitCount;
    }
}