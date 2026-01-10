public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
        {
            return false;
        }
        var length = (int)Math.Log10(x) + 1;
        while(length > 0)
        {
            if(x < 0)
            {
                return false;
            }
            var lastDigit = x % 10;
            var firstDigit = (int)Math.Pow(10, length - 1) * lastDigit;
            x -= lastDigit;
            if(length > 1)
            {
                x = (x - firstDigit)/10;
            }

            length -= 2;
        }
        return x == 0;
    }
}