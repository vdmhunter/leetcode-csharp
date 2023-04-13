namespace LeetCodeCSharpApp.ValidateStackSequences01;

public class Solution
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        var st = new Stack<int>();
        var j = 0;

        foreach (var val in pushed)
        {
            st.Push(val);

            while (st.Count > 0 && st.Peek() == popped[j])
            {
                st.Pop();
                j++;
            }
        }

        return st.Count == 0;
    }
}
