namespace LeetCodeCSharpApp.MinimumWindowSubstring01;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        var map = new int[128];
        
        foreach (var c in t)
            map[c]++;
        
        int counter = t.Length, begin = 0, end = 0, d = int.MaxValue, head = 0;
        
        while (end < s.Length)
            end = End();

        int End()
        {
            if (map[s[end++]]-- > 0)
                counter--;

            while (counter == 0)
            {
                if (end - begin < d)
                    d = end - (head = begin);

                if (map[s[begin++]]++ == 0)
                    counter++;
            }

            return end;
        }

        return d == int.MaxValue ? "" : s.Substring(head, d);
    }
}
