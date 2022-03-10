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
   public IList<IList<int>> LevelOrder(TreeNode root)
        {
       List<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);//add root to queue

            int level = 0;
            while (queue.Count != 0)
            {
                result.Add(new List<int>());
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    result[level].Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                level++;
            }
            return result;
        }
}