public class Solution {
    public int Search(int[] nums, int target) {
        //O(nLogn) , sc O(1)
        int start = 0;
        int end = nums.Length - 1;
        while(start <= end)
        {
            int mid = start + (end - start)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] >= nums[start])
            {
                if(target >= nums[start] && target <= nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            else
            {
                if(target > nums[mid] && target <= nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
        }
        return -1;
    }
}