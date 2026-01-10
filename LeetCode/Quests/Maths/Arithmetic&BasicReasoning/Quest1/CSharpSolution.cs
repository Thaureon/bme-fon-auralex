public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);

        var isArithmetic = true;
        var difference = arr[1] - arr[0];
        for(var i = 2; i < arr.Length; i++)
        {
            if(arr[i] - arr[i - 1] != difference)
            {
                isArithmetic = false;
                break;
            }
        }
        return isArithmetic;
    }
}