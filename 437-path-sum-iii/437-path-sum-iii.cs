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
    
    public Dictionary<int,int> prefixSum = new Dictionary<int,int>();
    public int cnt = 0;
    
    public int PathSum(TreeNode root, int targetSum) {
        
        if(root == null)
            return 0;
        
        prefixSum.Add(0,1);
        dfs(root, 0, targetSum);
        return cnt;
    }
    
    private void dfs(TreeNode node, int currSum, int targetSum)
    {
        if(node == null)
            return;
        
        currSum += node.val;
        
        if(prefixSum.ContainsKey(currSum - targetSum))
            cnt += prefixSum[currSum - targetSum];     
        
        if(prefixSum.ContainsKey(currSum))
            prefixSum[currSum]++;
        else
            prefixSum.Add(currSum,1);
        
        dfs(node.left, currSum, targetSum);
        dfs(node.right, currSum, targetSum);
        
        prefixSum[currSum]--;
    }
}