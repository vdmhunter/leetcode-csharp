namespace LeetCodeCSharpApp.BulbSwitcher02;

public class Solution
{
    public int BulbSwitch(int n)
    {
        if (n <= 1)
            return n;

        var left = 1;
        var right = n;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (mid <= n / mid)
                left = mid + 1;
            else
                right = mid;
        }

        return left - 1;
    }
}
