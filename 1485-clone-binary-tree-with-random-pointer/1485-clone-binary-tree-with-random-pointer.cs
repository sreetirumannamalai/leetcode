/**
 * Definition for Node.
 * public class Node {
 *     public int val;
 *     public Node left;
 *     public Node right;
 *     public Node random;
 *     public Node(int val=0, Node left=null, Node right=null, Node random=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *         this.random = random;
 *     }
 * }
 */

public class Solution {
     public NodeCopy CopyRandomBinaryTree(Node root) {
        
        if(root == null)
            return null;
        
        Dictionary<Node,NodeCopy> dic = new Dictionary<Node,NodeCopy>();
        dic.Add(root, new NodeCopy(root.val));
        
        dfs(root, dic);
        return dic[root];
    }
    
    private void dfs(Node root, Dictionary<Node,NodeCopy> dic)
    {
        if(root == null)
            return;
        
        if(root.left != null)
        {
            if(!dic.ContainsKey(root.left))
                dic.Add(root.left, new NodeCopy(root.left.val));
            dic[root].left = dic[root.left];
        }
        
        if(root.right != null)
        {
            if(!dic.ContainsKey(root.right))
                dic.Add(root.right, new NodeCopy(root.right.val));
            dic[root].right = dic[root.right];
        }
        
        if(root.random != null)
        {
            if(!dic.ContainsKey(root.random))
                dic.Add(root.random, new NodeCopy(root.random.val));
            dic[root].random = dic[root.random];
        }
        
        dfs(root.left, dic);
        dfs(root.right, dic);
    }
}
