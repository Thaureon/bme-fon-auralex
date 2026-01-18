public class Solution {
    public int MirrorReflection(int p, int q) {
        if(p == q)
        {
            return 1;
        }
        var qRoot = Math.Sqrt(q);
		for(int i = 2; i <= qRoot; i++)
		{
			if(p % i == 0 && q % i == 0)
			{
				p /= i;
				q /= i;
				i--;
			}
		}
        
        var corner = 0;
        var topBottom = p % q;
        if(topBottom == 0)
        {
            if((p/q) % 2 == 1)
            {
                corner = 1;
            }
            else
            {
                corner = 2;
            }
        }
        else if(q % 2 == 1)
        {
            if(p % 2 == 1)
            {
                corner = 1;
            }
            else
            {
                corner = 2;
            }
        }
        return corner;
    }
}