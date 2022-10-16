namespace LeetCodeCSharpApp.NumberOfValidClockTimes02;

public class Solution
{
    public int CountTime(string time)
    {
        var result = 0;
        var start = new TimeOnly(0, 0);
        var regex = new System.Text.RegularExpressions.Regex(time.Replace('?', '.'));

        for (var i = 0; i < 24 * 60; i++)
        {
            if (regex.IsMatch(start.ToString("HH:mm")))
                result++;

            start = start.AddMinutes(1);
        }

        return result;
    }
}
