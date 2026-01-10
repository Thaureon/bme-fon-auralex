class Solution {
public:
    int lengthOfLastWord(string s) {
        int length = 0;
        for(int i = s.length() - 1; i >= 0; i--)
        {
            if(s.at(i) == ' ')
            {
                if(length != 0)
                {
                    break;
                }
                continue;
            }
            length++;
        }
        return length;
    }
};