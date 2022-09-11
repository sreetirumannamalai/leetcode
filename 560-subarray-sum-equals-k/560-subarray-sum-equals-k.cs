public class Solution {
    //Subarray sum equals k
    //TC O(n2) SC O(1)
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        for(int start=0;start<nums.Length;start++)
        {
            int sum =0;
            for(int end = start; end < nums.Length; end++)
            {
                sum += nums[end];
                if(sum == k)
                    count++;
            }
        }
        return count;
    }
}