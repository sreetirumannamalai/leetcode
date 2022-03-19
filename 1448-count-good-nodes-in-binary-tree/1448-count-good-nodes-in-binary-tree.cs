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
    public int GoodNodes(TreeNode root) {
        return GoodNodes(root, int.MinValue);
    }
    
    public int GoodNodes(TreeNode root, int max)
    {
        if(root == null) return 0;
        
        max = Math.Max(max, root.val);
        int count = max <= root.val ? 1 : 0;
        
        return count + GoodNodes(root.left, max) + GoodNodes(root.right, max);
    }
}