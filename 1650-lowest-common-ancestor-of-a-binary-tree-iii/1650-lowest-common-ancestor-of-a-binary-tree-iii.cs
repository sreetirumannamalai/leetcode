/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    //Lowest Common Ancestor of a Binary Tree III
    //TC O(n) SC O(n)
    public Node LowestCommonAncestor(Node p, Node q) {
       if(p == null) return q;
        if(q == null) return p;
        if(p == null && q == null) return null;
        
        HashSet<Node> set = new HashSet<Node>();
        while(p!=null)
        {
            set.Add(p);
            p = p.parent;
        }
        
        while(q!=null)
        {
            if(set.Contains(q))
                return q;
            
            q =q.parent;
        }
        return null;
    }
}