namespace LeetCodeCSharpApp.SubtractTheProductAndSumOfDigitsOfAnInteger01;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var arr = n.ToString().ToCharArray().Select(c => c - '0').ToArray();
        return arr.Aggregate(1, (a, b) => a * b) - arr.Sum();
    }
}
