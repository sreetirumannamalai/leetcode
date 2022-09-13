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
    //Binary Tree right side view
    //TC O(n) sc O(d) dis the diameter
    public IList<int> RightSideView(TreeNode root) {
        List<int> visibleValues = new List<int>();
        if(root == null) return visibleValues;
        
        TreeNode current = null;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count() != 0)
        {
            int size = q.Count;
            for(int i =0;i<size;i++)
            {
                current = q.Dequeue();
                if(i==size-1)
                {
                    visibleValues.Add(current.val);
                }
                if(current.left != null)
                {
                    q.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    q.Enqueue(current.right);
                }
            }
        }
        return visibleValues;
    }
}