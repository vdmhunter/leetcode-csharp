using System.Text;

namespace LeetCodeCSharpApp.LargestPalindromicNumber01;

public class Solution
{
    private readonly Dictionary<int, int> _freq = new();

    public string LargestPalindromic(string num)
    {
        var result = new StringBuilder();

        FillFrequencyDictionary(num);

        while (true)
        {
            var countMoreThanTwo = _freq.Count(x => x.Value >= 2);
            
            if(countMoreThanTwo == 0)
                break;
            
            var max = _freq.Where(x => x.Value >= 2).MaxBy(x => x.Key);
            
            if (result.Length != 0 || max.Key != 0)
                result.Append(max.Key);
            
            _freq[max.Key] -= 2;
        }
        
        var reversePart = ReverseString(result.ToString());

        var count = _freq.Count(x => x.Value >= 1);
        
        if(count >= 1)
            result.Append(_freq.Where(x => x.Value >= 1).MaxBy(x => x.Key).Key);

        result.Append(reversePart);

        if (result.Length == 0)
            result.Append('0');

        return result.ToString();
    }

    private void FillFrequencyDictionary(string num)
    {
        foreach (var i in num.Select(x => Convert.ToInt32(x - '0')))
        {
            if (_freq.ContainsKey(i))
                _freq[i] += 1;
            else
                _freq.Add(i, 1);
        }
    }
    
    private static string ReverseString(string str)
    {
        var charArray = str.ToCharArray();
        Array.Reverse(charArray);
        var reversePart = new string(charArray);
        
        return reversePart;
    }
}
