namespace LeetCodeCSharpApp.TheNumberOfWeakCharactersInTheGame01;

public class Solution
{
    public int NumberOfWeakCharacters(int[][] properties)
    {
        var n = properties.Length;
        var count = 0;

        Array.Sort(properties, (a, b) => b[0] == a[0] ? a[1] - b[1] : b[0] - a[0]);

        var max = 0;

        for (var i = 0; i < n; i++)
        {
            if (properties[i][1] < max)
                count++;

            max = Math.Max(max, properties[i][1]);
        }

        return count;
    }
}
