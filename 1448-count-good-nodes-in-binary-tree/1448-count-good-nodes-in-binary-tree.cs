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
    
    private int GoodNodes(TreeNode root, long max)
    {
        if(root == null) return 0;
        
        max = Math.Max(root.val, max);
        int count = max <= root.val ? 1 : 0;
        return count + GoodNodes(root.left, max) + GoodNodes(root.right, max);
    }
}

