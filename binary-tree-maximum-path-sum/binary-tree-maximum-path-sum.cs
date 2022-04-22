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
    int max_sum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        if(root == null) return 0;
        
        MaxPathSum_Helper(root);
        return max_sum;
    }
    
    public int MaxPathSum_Helper(TreeNode node)
    {
        if(node == null) return 0;
        //maximum sum of left and right sub trees
        int leftSum = Math.Max(MaxPathSum_Helper(node.left), 0);
        int rightSum = Math.Max(MaxPathSum_Helper(node.right), 0);
        int newPath = leftSum + rightSum + node.val;
        
        //update max_sum if newPath is greater than max_sum
        max_sum = Math.Max(max_sum, newPath);
        
        return node.val + Math.Max(leftSum, rightSum);
    }
}