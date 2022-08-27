namespace LeetCodeCSharpApp.ReorderedPowerOf2_01;

public class Solution
{
    public bool ReorderedPowerOf2(int n)
    {
        var c = Counter(n);

        for (var i = 0; i < 32; i++)
            if (Counter(1 << i) == c)
                return true;

        return false;
    }

    private long Counter(int n)
    {
        long res = 0;
        
        for (; n > 0; n /= 10)
            res += (int)Math.Pow(10, n % 10);
        
        return res;
    }
}
