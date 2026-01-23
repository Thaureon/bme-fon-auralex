public class Solution {
    public int SingleNumber(int[] nums) {
        var finalNumber = 0;

        for(var i = 0; i < nums.Length; i++)
        {
            finalNumber = finalNumber ^ nums[i];
        }

        return finalNumber;
    }
}