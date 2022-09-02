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
        HashSet<Node> pAncesstors = new HashSet<Node>();
        while(p!=null)
        {
            pAncesstors.Add(p);
            p=p.parent;
        }
        
        while(q!=null)
        {
            if(pAncesstors.Contains(q))
                return q;
            
            q=q.parent;
        }
        return null;
    }
}