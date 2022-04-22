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
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root, root);
    }
    
    public bool IsMirror(TreeNode t1, TreeNode t2)
    {
        if(t1==null && t2==null)
            return true;
        
        if(t1==null || t2==null)
            return false;
        
        if(t1.val == t2.val && 
           IsMirror(t1.right, t2.left) &&
           IsMirror(t1.left, t2.right))
        {
            return true;
        }
        return false;
    }
}