namespace LeetCodeCSharpApp.PartitioningIntoMinimumNumberOfDeciBinaryNumbers01;

public class Solution
{
    public int MinPartitions(string n)
    {
        var max = 0;

        foreach (var c in n)
        {
            if (c == '9')
                return 9;

            max = Math.Max(max, c - '0');
        }

        return max;
    }
}
