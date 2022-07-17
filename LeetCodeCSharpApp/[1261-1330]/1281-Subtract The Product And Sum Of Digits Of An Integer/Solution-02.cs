namespace LeetCodeCSharpApp.SubtractTheProductAndSumOfDigitsOfAnInteger02;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var p = 1;
        var s = 0;

        while (n > 0)
        {
            var d = n % 10;
            p *= d;
            s += d;
            n /= 10;
        }

        return p - s;
    }
}
