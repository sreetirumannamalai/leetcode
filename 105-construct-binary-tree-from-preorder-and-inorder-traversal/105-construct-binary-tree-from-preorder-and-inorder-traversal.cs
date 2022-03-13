/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int index = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(inorder.Length == 0 || preorder.Length == 0) return null;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i=0;i<inorder.Length;i++)
        {
            dict.Add(inorder[i], i);
        }
        return Helper(dict, preorder, 0, preorder.Length - 1);
    }
    
    public TreeNode Helper(Dictionary<int,int> dict, int[] preorder, int start, int end)
    {
        if(start > end) return null;
        
        int rootval = preorder[index];
        index++;
        TreeNode node = new TreeNode(rootval);
        
        if(start == end)
            return node;
        
        int inorderIndex = dict[rootval];
        node.left = Helper(dict, preorder, start, inorderIndex - 1);
        node.right= Helper(dict, preorder, inorderIndex + 1, end);
        
        return node;
    }
}