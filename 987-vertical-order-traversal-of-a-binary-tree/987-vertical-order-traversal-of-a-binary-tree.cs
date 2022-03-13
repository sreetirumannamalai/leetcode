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
    
    public class Node
    {
        public TreeNode treeNode;
        public int x;
        public int y;
        public Node(TreeNode node, int x, int y)
        {
            this.treeNode = node;
            this.x = x;
            this.y = y;
        }
    }
    
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        
        List<IList<int>> res = new List<IList<int>>();
        if(root == null)
            return res;
        
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(new Node(root, 0, 0));
        Dictionary<int,List<Node>> dic = new Dictionary<int,List<Node>>();
        int minX = 0, maxX = 0;
        
        while(queue.Count > 0)
        {
            var curr = queue.Dequeue();
            minX = Math.Min(minX, curr.x);
            maxX = Math.Max(maxX, curr.x);
            
            if(dic.ContainsKey(curr.x))
                dic[curr.x].Add(curr);
            else
                dic.Add(curr.x, new List<Node>(){curr});
            
            if(curr.treeNode.left != null)
                queue.Enqueue(new Node(curr.treeNode.left, curr.x - 1, curr.y - 1));
            
            if(curr.treeNode.right != null)
                queue.Enqueue(new Node(curr.treeNode.right, curr.x + 1, curr.y - 1));
        }
        
        for(int i = minX; i <= maxX; i++)
        {
            var nodeList = dic[i];
            
            nodeList.Sort((node1, node2) =>
                          {
                             if(node1.y == node2.y)
                                 return node1.treeNode.val - node2.treeNode.val;
                             else
                                 return node2.y - node1.y;
                          });
            
            List<int> temp = new List<int>();
            foreach(var node in nodeList)
                temp.Add(node.treeNode.val);
            
            res.Add(temp);
        }

        return res;
    }
}