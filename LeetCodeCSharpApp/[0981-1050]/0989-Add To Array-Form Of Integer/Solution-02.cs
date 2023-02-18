namespace LeetCodeCSharpApp.AddToArrayFormOfInteger02;

public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var curry = k;
        var result = new List<int>();
        var pointer = num.Length - 1;

        while (pointer >= 0 || curry > 0)
        {
            if (pointer >= 0)
                curry += num[pointer];

            result.Add(curry % 10);
            curry /= 10;
            pointer--;
        }

        result.Reverse();

        return result;
    }
}
