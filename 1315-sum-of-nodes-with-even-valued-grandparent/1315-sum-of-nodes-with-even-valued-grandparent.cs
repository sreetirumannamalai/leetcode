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
    //O(n) sc O(1)
    int sum = 0;
    public int SumEvenGrandparent(TreeNode root) {
        if(root == null) return 0;
        
        return Traverse(root, false, false);
    }
    
    public int Traverse(TreeNode root, bool parent, bool grandParent)
    {
        if(root != null)
        {
            if(grandParent)
            {
                sum += root.val;
            }
            Traverse(root.left, root.val % 2 == 0, parent);
            Traverse(root.right, root.val % 2 == 0, parent);
        }
        return sum;
    }
}