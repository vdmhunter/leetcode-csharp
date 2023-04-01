namespace LeetCodeCSharpApp.FindScoreOfAnArrayAfterMarkingAllElements01;

public class Solution
{
    public long FindScore(int[] nums)
    {
        var result = 0L;
        var st = new SortedSet<(int Value, int Index)>();

        for (var i = 0; i < nums.Length; ++i)
            st.Add((nums[i], i));

        foreach (var s in st.Where(s => nums[s.Index] != 0))
        {
            nums[s.Index] = 0;

            if (s.Index - 1 >= 0)
                nums[s.Index - 1] = 0;

            if (s.Index + 1 < nums.Length)
                nums[s.Index + 1] = 0;

            result += s.Value;
        }

        return result;
    }
}
