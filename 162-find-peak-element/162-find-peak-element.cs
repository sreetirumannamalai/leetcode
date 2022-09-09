public class Solution {
    //Time complexity :O(log2(n)). We reduce the search space in half at every step. Thus, the total search space will be consumed in log2(n) steps. Here, nn refers to the size of numsnums array.
    //Space complexity : O(1). Constant extra space is used. 
    public int FindPeakElement(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        while(l < r)
        {
            int mid = (l + r)/2;
            if(nums[mid] > nums[mid + 1])
                r = mid;
            else
                l = mid + 1;
        }
        return l;
    }
}