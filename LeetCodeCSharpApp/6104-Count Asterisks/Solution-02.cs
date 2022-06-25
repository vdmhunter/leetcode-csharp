namespace LeetCodeCSharpApp.CountAsterisks02;

public class Solution
{
    public int CountAsterisks(string s)
    {
        int barCount = 0, result = 0;

        foreach (var c in s)
            switch (c)
            {
                case '*' when barCount % 2 == 0:
                    result++;
                    break;
                case '|':
                    barCount++;
                    break;
            }

        return result;
    }
}
