namespace LeetCodeCSharpApp.ValidAnagram01;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var arr1 = t.ToCharArray();
        Array.Sort(arr1);

        var arr2 = s.ToCharArray();
        Array.Sort(arr2);

        var x = new string(arr1);
        var y = new string(arr2);
        
        return y.Equals(x);
    }
}
