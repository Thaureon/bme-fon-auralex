class Solution {
public:
    bool isPalindrome(int x) {
        std::string s = std::to_string(x);
        for(int pos = 0; pos < s.length() / 2; pos++)
        {
            int end = s.length() - pos - 1;
            if(s[pos] != s[end])
            {
                return false;
            }
        }
        return true;
    }
};