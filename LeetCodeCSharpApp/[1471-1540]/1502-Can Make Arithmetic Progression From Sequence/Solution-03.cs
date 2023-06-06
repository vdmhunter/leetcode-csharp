namespace LeetCodeCSharpApp.CanMakeArithmeticProgressionFromSequence03;

public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        var sortedArr = arr.OrderBy(x => x).ToArray();
        var difference = sortedArr[1] - sortedArr[0];

        return sortedArr.Zip(sortedArr.Skip(1), (a, b) => b - a).All(x => x == difference);
    }
}
