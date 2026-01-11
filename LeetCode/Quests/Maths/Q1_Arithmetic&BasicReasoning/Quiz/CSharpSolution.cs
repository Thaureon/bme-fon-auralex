public class Solution {
    public int Reverse(int x) {
        var isNegative = x < 0;
        long result = 0;

        if(isNegative)
        {
            x *= -1;
        }

        while(x != 0)
        {
            var digit = x % 10;

            result = result * 10 + digit;
            x /= 10;
        }

        if(isNegative)
        {
            result *= -1;
        }
        if(result > int.MaxValue || result < int.MinValue)
        {
            result = 0;
        }
        return (int)result;
    }
}