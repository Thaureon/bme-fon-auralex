public class Solution
{
	public int GetSum(int a, int b)
	{
		var bitA = a & 1;
		var bitB = b & 1;
		var sum = bitA ^ bitB;
		var c = 0;
		var position = 1;
		while ((a != 0 || b != 0) && position < 32)
		{
			c = (bitA & bitB) | (bitA & c) | (bitB & c);
			a >>= 1;
			b >>= 1;

			bitA = a & 1;
			bitB = b & 1;

			var bit = bitA ^ bitB ^ c;
			sum = sum | bit << position;
			position++;
		}

		return sum;
	}
}