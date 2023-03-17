namespace LeetCodeCSharpApp.RomanToInteger03;

public class Solution
{
    private readonly Dictionary<char, int> _map = new()
    {
        { 'I', 1    },
        { 'V', 5    },
        { 'X', 10   },
        { 'L', 50   },
        { 'C', 100  },
        { 'D', 500  },
        { 'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        var result = 0;
        var last = 0;

        for (var i = s.Length - 1; i >= 0; i--) 
        {
            var current = _map[s[i]];
            result = current < last ? result - current : result + current;
            last = current;
        }
        
        return result;
    }
}
