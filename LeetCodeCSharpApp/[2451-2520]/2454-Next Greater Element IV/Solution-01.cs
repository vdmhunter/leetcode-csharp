namespace LeetCodeCSharpApp.NextGreaterElementIV01;

public class Solution
{
    public int[] SecondGreaterElement(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        
        Array.Fill(result, -1);
        
        Stack<int> s1 = new(), s2 = new(), tmp = new();
        
        for (var i = 0; i < n; i++)
        {
            while (s2.Count != 0 && nums[s2.Peek()] < nums[i])
                result[s2.Pop()] = nums[i];
            
            while (s1.Count != 0 && nums[s1.Peek()] < nums[i])
                tmp.Push(s1.Pop());
            
            while (tmp.Count != 0)
                s2.Push(tmp.Pop());
            
            s1.Push(i);
        }

        return result;
    }
}
