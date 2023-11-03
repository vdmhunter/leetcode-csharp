namespace LeetCodeCSharpApp.BuildAnArrayWithStackOperations01;

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var index = 0;
        var result = new List<string>(2 * n);

        for (var i = 1; i <= n; i++)
        {
            result.Add("Push");

            if (target[index] == i)
                index++;
            else
                result.Add("Pop");

            if (index == target.Length)
                break;
        }

        return result;
    }
}
