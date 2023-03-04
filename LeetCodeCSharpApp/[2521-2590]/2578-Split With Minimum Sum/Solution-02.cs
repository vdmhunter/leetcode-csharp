namespace LeetCodeCSharpApp.SplitWithMinimumSum02;

public class Solution
{
    public int SplitNum(int num)
    {
        var s = new string(num.ToString().OrderBy(c => c).ToArray());

        return int.Parse(new string(s.Where((_, i) => i % 2 != 0).ToArray()))
               + int.Parse(new string(s.Where((_, i) => i % 2 == 0).ToArray()));
    }
}
