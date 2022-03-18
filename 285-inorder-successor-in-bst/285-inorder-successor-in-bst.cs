/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
       //O(nP sc O(1)
       if(root == null) return null;
       TreeNode successor = null;
        while(root != null)
        {
            if(p.val >= root.val)
            {
                root = root.right;
            }
            else
            {
                successor = root;
                root = root.left;
            }
        }
       return successor;
    }
}