namespace LeetCodeCSharpApp.TimeNeededToRearrangeABinaryString01;

public class Solution
{
    public int SecondsToRemoveOccurrences(string s)
    {
        var result = 0;

        while (s.Split("01").Length - 1 != 0)
        {
            s = s.Replace("01", "10");
            result++;
        }

        return result;
    }
}
