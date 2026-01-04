class Solution {
    public boolean isPalindrome(int x) {
        String s = String.valueOf(x);
        for(int pos = 0; pos < s.length() / 2; pos++)
        {
            int end = s.length() - pos - 1;
            if(s.charAt(pos) != s.charAt(end))
            {
                return false;
            }
        }
        return true;
    }
}