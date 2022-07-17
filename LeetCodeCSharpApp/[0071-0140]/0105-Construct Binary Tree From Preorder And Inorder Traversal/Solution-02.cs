using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConstructBinaryTreeFromPreorderAndInorderTraversal02;

/// <summary>
/// Say we have 2 arrays, PRE and IN.
/// Preorder traversing implies that PRE[0] is the root node.
/// Then we can find this PRE[0] in IN, say it's IN[5].
/// Now we know that IN[5] is root, so we know that IN[0] - IN[4] 
/// is on the left side, IN[6] to the end is on the right side.
/// Recursively doing this on subarrays, we can build a tree out of it :)
/// T: O(n), S: O(n)
/// </summary>
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return Helper(0, 0, preorder.Length - 1, preorder, inorder);
    }
    
    private static TreeNode Helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
    {
        // exit case - null boundary check
        if (preStart > preorder.Length - 1 || inStart > inEnd)
            return null!;

        // create node
        var node = new TreeNode(preorder[preStart]); //first idx is root
        
        // find idx for inorder
        var inRoot = 0; // inorder current index
        for (var i = inStart; i <= inEnd; i++)
            if (inorder[i] == node.val) // example: 'F'
                inRoot = i;

        // recursive
        // preorder - move to next node
        node.left = Helper(preStart + 1, inStart, inRoot - 1, preorder, inorder);

        // See explanation below**
        // In short, left subtree's root index = preStart + numsOnLeft + 1
        // In inorder, numsOnleft = root index - start index;
        preStart = preStart + inRoot - inStart + 1;

        node.right = Helper(preStart, inRoot + 1, inEnd, preorder, inorder);

        return node;
    }
    /*
               s      s'   
        pre = [3 9 20 15 7]
        in =  [9 3 15 20 7]
               s r       e 
    */
}

/*
** explanation of how to get right tree root in preorder
- Our aim is to find out the index of right child for current node in the preorder array
We know the index of current node in the preorder array - preStart (or whatever your call it), it's the root of a subtree
- Remember pre order traversal always visit all the node on left branch before going to the right ( root -> left -> ... -> right), therefore, we can get the immediate right child index by skipping all the node on the left branches/subtrees of current node
- The inorder array has this information exactly. Remember when we found the root in "inorder" array we immediately know how many nodes are on the left subtree and how many are on the right subtree
- Therefore the immediate right child index is preStart + numsOnLeft + 1 (remember in preorder traversal array root is always ahead of children nodes but you don't know which one is the left child which one is the right, and this is why we need inorder array)
numsOnLeft = root - inStart.
*/
