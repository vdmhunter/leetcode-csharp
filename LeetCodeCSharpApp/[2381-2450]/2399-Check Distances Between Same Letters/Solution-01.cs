namespace LeetCodeCSharpApp.CheckDistancesBetweenSameLetters01;

public class Solution
{
    public bool CheckDistances(string s, int[] distance)
    {
        var visited = new HashSet<char>();
        
        for (var i = 0; i < s.Length - 1; i++)
        {
            if(visited.Contains(s[i]))
                continue;
            
            var index = s.IndexOf(s[i], i + 1);
            
            if (index - i - 1 != distance[s[i] - 'a'])
                return false;

            visited.Add(s[i]);
        }

        return true;
    }
}