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
    public bool IsValidBST(TreeNode root)
    {
        return ValidateBST(root, long.MinValue, long.MaxValue);
    }
    
    private bool ValidateBST(TreeNode root, long min, long max)
    {
        if(root == null) return true;
        if(min < root.val && root.val < max)
        {
            var leftResult = ValidateBST(root.left, min, root.val);
            var rightResult = ValidateBST(root.right, root.val, max);
            
            if(leftResult && rightResult)
            {
                return true;
            }
        }
        return false;
    }
}
