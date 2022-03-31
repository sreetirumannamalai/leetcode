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
    //O(n) sc O(n)
    public int Rob(TreeNode root) {
        
        if(root == null)
            return 0;
        
        int[] res = Helper(root);
        return Math.Max(res[0], res[1]);
    }
    
    private int[] Helper(TreeNode root)
    {
        if(root == null)
            return new int[2];
        
        var left = Helper(root.left);
        var right = Helper(root.right);
        int[] res = new int[2];
        
        // root is not robbed
        res[0] = Math.Max(left[0],left[1]) + Math.Max(right[0],right[1]);
        // root is robbed
        res[1] = root.val + left[0] + right[0];
        
        return res;
    }
}