public class Solution {
    //https://leetcode.com/problems/sliding-window-maximum/discuss/1194867/C-solution-(Monoqueue-)
    //O(n) sc O(n)
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        if(nums == null || nums.Length == 0)
            return new int[0];
        
        int n = nums.Length, idx = 0;
        int[] res = new int[n - k + 1];
        LinkedList<int> monoQueue = new LinkedList<int>();
        for(int i = 0; i < n; i++)
        {
            // maintain the sliding window has size k
            while(monoQueue.Count > 0 && monoQueue.First.Value < i - k + 1)
                monoQueue.RemoveFirst();
            
            // maintain the numbers in monoQueue in ascending order
            while(monoQueue.Count > 0 && nums[monoQueue.Last.Value] < nums[i])
                monoQueue.RemoveLast();     
            monoQueue.AddLast(i);
            
            // build the res
            if(i - k + 1 >= 0)
            {
                res[idx] = nums[monoQueue.First.Value];
                idx++;
            }
        }
        
        return res;
    }
}