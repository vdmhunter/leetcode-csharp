namespace LeetCodeCSharpApp.SumOfNumberAndItsReverse01;

public class Solution
{
    public bool SumOfNumberAndReverse(int num)
    {
        for (var n = num / 2; n <= num; n++)
            if (n + Reverse(n) == num)
                return true;

        return false;
    }
    
    private static int Reverse(int n)
    {
        var result = 0;
        
        while (n > 0)
        {
            var remainder = n % 10;
            result = result * 10 + remainder;
            n /= 10;
        }

        return result;
    }
}
