namespace LeetCodeCSharpApp.CountAsterisks01;

public class Solution
{
    public int CountAsterisks(string s)
    {
        var asterisksCount = 0;
        var startIndex = 0;
        var endIndex = s.IndexOf('|');
        var count = s.ToCharArray().Count(c => c == '|');

        if (count == 0)
            return s.ToCharArray().Count(c => c == '*');
        
        for (var i = 0; i < count + 1; i++)
        {
            var substring = s.Substring(startIndex, endIndex - startIndex);
            
            if (i != count)
            {
                startIndex = endIndex + 1;
                endIndex = s.IndexOf('|', startIndex);
                endIndex = endIndex == -1 ? s.Length : endIndex;
            }
            
            if (i % 2 != 0)
                continue;
            
            asterisksCount += substring.ToCharArray().Count(c => c == '*');
        }

        return asterisksCount;
    }
}
