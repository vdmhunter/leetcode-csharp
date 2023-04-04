namespace LeetCodeCSharpApp.OptimalPartitionOfString01;

public class Solution
{
    public int PartitionString(string s)
    {
        var result = 1;
        var hs = new HashSet<char>();
        
        foreach (var c in s)
        {
            if (hs.Contains(c))
            {
                result++;
                hs.Clear();
            }

            hs.Add(c);
        }

        return result;
    }
}

