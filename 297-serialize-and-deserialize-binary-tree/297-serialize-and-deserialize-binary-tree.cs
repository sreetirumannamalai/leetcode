/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        //use BFS to traverse the binary tree.
        //use '#' to represent a null node if its parent node is not null and use ',' as delimiter
        if(root == null) return "";
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        StringBuilder sb = new StringBuilder();
        while(q.Count > 0)
        {
            TreeNode current = q.Dequeue();
            if(current != null)
            {
                sb.Append(current.val + ",");
                q.Enqueue(current.left);
                q.Enqueue(current.right);
            }
            else
                sb.Append("#,");
        }
        return sb.ToString();
    }
        
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == "") return null;
        string[] comma = new string[] {","};
        string[] nodes = data.Split(comma, StringSplitOptions.RemoveEmptyEntries);
        Queue<TreeNode> q = new Queue<TreeNode>();
        TreeNode root = new TreeNode(int.Parse(nodes[0]));
        q.Enqueue(root);
        for(int i=1;i<nodes.Length;i++)
        {
            TreeNode current = q.Dequeue();
            if(nodes[i] != "#")
            {
                TreeNode left = new TreeNode(int.Parse(nodes[i]));
                current.left = left;
                q.Enqueue(left);
            }
            i++;
            if(nodes[i] != "#")
            {
                TreeNode right = new TreeNode(int.Parse(nodes[i]));
                current.right = right;
                q.Enqueue(right);
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
    