namespace LeetCodeCSharpApp.FruitIntoBaskets01;

public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        int result = 0, current = 0, countB = 0, a = 0, b = 0;

        foreach (var c in fruits)
        {
            current = c == a || c == b ? current + 1 : countB + 1;
            countB = c == b ? countB + 1 : 1;

            if (b != c)
            {
                a = b;
                b = c;
            }

            result = Math.Max(result, current);
        }

        return result;
    }
}
