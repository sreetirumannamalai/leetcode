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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;
        BSTZigZagLevelOrder_Helper(root, result);
        return result;
    }
    
    public void BSTZigZagLevelOrder_Helper(TreeNode root, List<IList<int>> result)
    {
        bool zigzag = false;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        int level = 0;
        while(queue.Count > 0)
        {
           List<int> child = new List<int>();
            int size = queue.Count;
            for(int i=0;i<size;i++)
            {
                TreeNode node = queue.Dequeue();
                child.Add(node.val);
                
                if(node.left != null)
                    queue.Enqueue(node.left);
                
                if(node.right != null)
                    queue.Enqueue(node.right);
            }
            if(zigzag)
                child.Reverse();
            
            zigzag = !zigzag;
            result.Add(child);
        }
    }
}