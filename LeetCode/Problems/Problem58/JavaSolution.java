class Solution {
    public int lengthOfLastWord(String s) {
        String[] words = s.split(" ");
        int length = 0;
        for(int i = words.length - 1; i >= 0; i--)
        {
            if(words[i].length() > 0)
            {
                length = words[i].length();
                break;
            }
        }
        return length;
    }
}