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
    private List<int> left_leaves = new List<int>();
    private List<int> right = new List<int>();
    public IList<int> BoundaryOfBinaryTree(TreeNode root) {
       if(root == null)
           return new List<int>();
        
        DFS(root, "root");
        
        for(int i= right.Count - 1; i > -1 ; i--)
            left_leaves.Add(right[i]);
        
        return left_leaves;
    }
    
    private void DFS(TreeNode node, string nodeType)
    {
        if(nodeType == "left" || nodeType == "root")
            left_leaves.Add(node.val);
        else if(nodeType == "right")
            right.Add(node.val);
        else if(node.left == null && node.right == null)
            left_leaves.Add(node.val);
        if(node.left != null)
        {
            DFS(node.left, nodeType == "left" ||nodeType == "root" ? "left" : nodeType == "right" && node.right == null ? "right" : string.Empty);
        }
        
        if(node.right != null)
        {
            DFS(node.right, nodeType == "right" || nodeType == "root" ? "right" : nodeType == "left" && node.left == null ? "left" : string.Empty);
        }
    } 
}