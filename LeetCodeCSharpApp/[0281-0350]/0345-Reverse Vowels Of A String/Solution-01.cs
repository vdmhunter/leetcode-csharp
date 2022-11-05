namespace LeetCodeCSharpApp.ReverseVowelsOfAString01;

public class Solution
{
    public string ReverseVowels(string s)
    {
        var list = s.ToCharArray();
        var hs = new HashSet<char>
        {
            'a',
            'e',
            'i',
            'o',
            'u',
            'A',
            'E',
            'I',
            'O',
            'U'
        };

        for (int i = 0, j = list.Length - 1; i < j;)
        {
            if (!hs.Contains(list[i])) 
            {
                i++;
                continue;
            }

            if (!hs.Contains(list[j]))
            {
                j--;
                continue;
            }

            (list[i], list[j]) = (list[j], list[i]);
            i++;
            j--;
        }

        return new string(list);
    }
}
