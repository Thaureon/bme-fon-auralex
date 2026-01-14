public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var selfDividingList = new List<int>();

        for(var value = left; value <= right; value++)
        {
            var remainingValue = value;
            while (remainingValue != 0)
            {
                var digit = remainingValue % 10;

                if(digit == 0 || value % digit != 0)
                {
                    break;
                }
                remainingValue /= 10;
            }
            if(remainingValue == 0)
            {
                selfDividingList.Add(value);
            }
        }

        return selfDividingList;
    }
}