namespace LeetCodeCSharpApp.CountSpecialIntegers01;

public class Solution
{
    public int CountSpecialNumbers(int n)
    {
        // Transform n + 1 to List
        var list = (n + 1).ToString().ToCharArray().Select(c => c - '0').ToList();

        // Count the number with digits < n
        var result = 0;

        for (var i = 1; i < list.Count; ++i)
            result += 9 * A(9, i - 1);

        // Count the number with same prefix
        result += CountOfNumbersWithSamePrefix(list);

        return result;
    }

    private static int CountOfNumbersWithSamePrefix(IReadOnlyList<int> list)
    {
        var result = 0;
        var seen = new HashSet<int>();

        for (var i = 0; i < list.Count; ++i)
        {
            for (var j = i > 0 ? 0 : 1; j < list[i]; ++j)
                if (!seen.Contains(j))
                    result += A(9 - i, list.Count - i - 1);

            if (seen.Contains(list[i]))
                break;

            seen.Add(list[i]);
        }

        return result;
    }

    private static int A(int m, int n)
    {
        return n == 0 ? 1 : A(m, n - 1) * (m - n + 1);
    }
}
