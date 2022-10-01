namespace LeetCodeCSharpApp.SortThePeople01;

public class Solution
{
    private readonly List<(string Name, int Height)> _people = new();
    
    public string[] SortPeople(string[] names, int[] heights)
    {
        for (var i = 0; i < names.Length; i++)
            _people.Add(new ValueTuple<string, int>(names[i], heights[i]));

        return _people.OrderByDescending(p => p.Height).Select(p => p.Name).ToArray();
    }
}
