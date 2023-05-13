namespace LeetCodeCSharpApp.NumberOfSeniorCitizens01;

public class Solution
{
    public int CountSeniors(string[] details)
    {
        return details.Count(passenger => int.Parse(passenger[11..13]) > 60);
    }
}
