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
    //O(n) sc O(d), d is depth of the tree
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        
        TreeNode left = root;
        TreeNode right = root;
        
        int height_left = 0;
        int height_right = 0;
        while(left != null)
        {
            height_left++;
            left = left.left;
        }
        while(right != null)
        {
            height_right++;
            right = right.right;
        }
        
        if(height_left == height_right)
             return (1 << height_left ) - 1;
        else
            return 1 + CountNodes(root.left) + CountNodes(root.right);      
    }
}