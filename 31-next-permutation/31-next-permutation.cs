public class Solution {
  public void NextPermutation(int[] nums) {
        int k = nums.Length -2;
        while(k >=0 && nums[k] >= nums[k+1])
        {
            k--;
        }
        if(k == -1)
        {
            reverse(nums, 0, nums.Length -1);
            return;
        }
        for(int i = nums.Length -1;i>k;i--)
        {
            if(nums[i] > nums[k])
            {
                int temp = nums[k];
                nums[k] = nums[i];
                nums[i] = temp;
                break;
            }
        }
        reverse(nums, k+1, nums.Length-1);
    }
    private void reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
            start++;
            end--;
        }
    }
}