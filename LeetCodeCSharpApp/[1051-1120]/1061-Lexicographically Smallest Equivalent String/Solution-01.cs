namespace LeetCodeCSharpApp.LexicographicallySmallestEquivalentString01;

public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var arr = new char[26];

        for (ushort i = 0; i < 26; i++)
            arr[i] = (char)('a' + i);

        for (var i = 0; i < s1.Length; i++)
        {
            var min = arr[s1[i] - 'a'];
            var max = arr[s2[i] - 'a'];

            if (max < min)
                (max, min) = (min, max);

            for (var j = 0; j < arr.Length; j++)
                if (arr[j] == max)
                    arr[j] = min;
        }

        return new string(baseStr.Select(x => arr[x - 'a']).ToArray());
    }
}
