namespace LeetCodeCSharpApp.CanMakeArithmeticProgressionFromSequence02;

public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        var seen = new HashSet<int>();
        int mi = int.MaxValue, mx = int.MinValue, n = arr.Length;
        
        foreach (var a in arr)
        {
            mi = Math.Min(mi, a);
            mx = Math.Max(mx, a);
            seen.Add(a);
        }

        var diff = mx - mi;
        
        if (diff % (n - 1) != 0)
            return false;
        
        diff /= n - 1;
        
        while (--n > 0)
        {
            if (!seen.Contains(mi))
                return false;
            
            mi += diff;
        }

        return true;
    }
}
