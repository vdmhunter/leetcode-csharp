using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.NaryTreePreorderTraversal02;

public class Solution
{
    private readonly List<int> _list = new();
    
    public IList<int> Preorder(Node root)
    {
        if (root == null)
            return _list;
        
        _list.Add(root.val);
        
        foreach(var node in root.children)
            Preorder(node);
                
        return _list;
    }
}
