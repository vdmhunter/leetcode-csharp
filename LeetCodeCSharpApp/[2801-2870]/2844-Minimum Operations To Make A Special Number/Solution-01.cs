namespace LeetCodeCSharpApp.MinimumOperationsToMakeASpecialNumber01;

public class Solution
{
    public int MinimumOperations(string num)
    {
        var n = num.Length;

        var idxZ = num.LastIndexOf('0');
        var idx5 = num.LastIndexOf('5');

        var opZ = idxZ >= 0 ? Math.Min(n - 1, Check(num, idxZ)) : n;
        var op5 = Check(num, idx5);

        return Math.Min(opZ, op5);
    }

    private static int Check(string num, int i)
    {
        for (var j = i - 1; j >= 0; j--)
        {
            var t = num[i] - '0' + (num[j] - '0') * 10;

            if (t % 25 == 0)
                return num.Length - j - 2;
        }

        return num.Length;
    }
}
