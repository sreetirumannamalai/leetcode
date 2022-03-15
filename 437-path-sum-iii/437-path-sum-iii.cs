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
    //O(n)
    public Dictionary
        <int, int> dict = new Dictionary<int, int>();
    public int count = 0;
    
    public int PathSum(TreeNode root, int targetSum)
    {
        if(root == null)
            return 0;
        
        dict.Add(0,1);
        dfs(root, 0, targetSum);
        return count;
    }
    
    private void dfs(TreeNode node, int currSum, int targetSum)
    {
        if(node == null)
            return;
        
        currSum += node.val;
        
        if(dict.ContainsKey(currSum - targetSum))
            count += dict[currSum - targetSum];
        
        if(dict.ContainsKey(currSum))
            dict[currSum]++;
        else
            dict.Add(currSum, 1);
        
        dfs(node.left, currSum, targetSum);
        dfs(node.right, currSum, targetSum);
        
        dict[currSum]--;
    }
}