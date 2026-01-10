class Solution:
    def isPalindrome(self, x: int) -> bool:
        s = str(x)
        for pos in range(len(s) // 2):
            end = len(s) - pos - 1
            if(s[pos] != s[end]):
                return False
        return True