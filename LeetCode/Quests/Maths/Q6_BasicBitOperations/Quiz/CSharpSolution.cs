public class Solution {
    public int[] FindArray(int[] pref) {
        var xorArray = new int[pref.Length];
        xorArray[0] = pref[0];

        for(var i = 1; i < pref.Length; i++)
        {
            xorArray[i] = pref[i] ^ pref[i - 1];
        }

        return xorArray;
    }
}