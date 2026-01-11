public class Solution {
    public bool IsUgly(int n) {
        if(n <= 0)
        {
            return false;
        }

        var result = n;
        var primeFactors = new int[] {2, 3, 5};

        foreach(var factor in primeFactors)
        {
            while (result % factor == 0)
            {
                result /= factor;
            }
        }

        return result == 1;
    }
}