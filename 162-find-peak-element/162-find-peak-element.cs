public class Solution {
    //Find Peak Element
    //Time complexity :O(log2(n)). We reduce the search space in half at every step. Thus, the total search space will be consumed in log2(n) steps. Here, n refers to the size of nums array.
    //Space complexity : O(1). Constant extra space is used. 
    public int FindPeakElement(int[] nums) {
       int low = 0;
       int high = nums.Length - 1;
      while(low < high)
      {
          int mid = (low + high)/2;
          if(nums[mid]>nums[mid+1])
          {
              high = mid;
          }
          else
          {
              low = mid + 1;
          }
      }
        return low;
    }
}