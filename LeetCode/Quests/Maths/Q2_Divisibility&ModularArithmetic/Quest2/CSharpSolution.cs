public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if(k % 2 == 0 || k % 5 == 0)
        {
            return -1;
        }

        var totalDigits = 1;
        var rem = 1;

        while (rem % k != 0)
        {
            totalDigits++;
            rem = (rem * 10 + 1) % k;
        }

        return totalDigits;
    }

    public bool IsPrime(int k)
    {
        return true;
    }
}