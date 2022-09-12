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
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        if(root == null)
        {
            return new List<IList<int>>();
        }
        
        SortedDictionary<int, IList<int>> res = new SortedDictionary<int, IList<int>>();
        Queue<(TreeNode, int)> q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, 0));
        
        while(q.Count > 0)
        {
            var cur = q.Dequeue();
            if(!res.ContainsKey(cur.Item2))
            {
                res.Add(cur.Item2, new List<int>());
            }
            res[cur.Item2].Add(cur.Item1.val);
            
            if(cur.Item1.left != null)
            {
                q.Enqueue((cur.Item1.left, cur.Item2 - 1));
            }
            if(cur.Item1.right != null)
            {
                q.Enqueue((cur.Item1.right, cur.Item2 + 1));
            }
        }
        return res.Values.ToList();
    }
}
  
    