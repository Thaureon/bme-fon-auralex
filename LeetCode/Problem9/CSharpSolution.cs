public class Solution {
    public bool IsPalindrome(int x) {
        var isPalindrome = true;
        var strX = x.ToString();

        for(var pos = 0; pos < strX.Length / 2; pos++)
        {
            var end = strX.Length - pos - 1;
            if(strX[pos] != strX[end])
            {
                return false;
            }
        }

        return isPalindrome;
    }
}