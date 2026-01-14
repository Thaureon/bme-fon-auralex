public class Solution {
    public string GetPermutation(int n, int k) {
        var inputValues = new List<int>();
        var remainingPermutations = 1;
        for (int i = 0; i < n; i++)
        {
            var value = i + 1;
            remainingPermutations *= value;
            inputValues.Add(value);
        }

        var remainingN = n;
        var kRemainder = k - 1;
        var finalPermutation = "";
        while(inputValues.Any())
        {
            remainingPermutations = remainingPermutations / remainingN;

            // Get first digit
            var digitPos = kRemainder / remainingPermutations;

            var digit = inputValues[digitPos];
            inputValues.RemoveAt(digitPos);

            finalPermutation += digit;

            remainingN--;
            kRemainder = kRemainder % remainingPermutations;
        }
        return finalPermutation;
    }
}