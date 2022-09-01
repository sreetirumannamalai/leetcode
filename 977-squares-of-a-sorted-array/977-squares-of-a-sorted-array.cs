public class Solution {
    //TC O(n) SC O(n)
    public int[] SortedSquares(int[] nums) {
        if(nums.Length == 0)
            return new int[0];
        int left = 0;
        int right = nums.Length - 1;
        int[] result = new int[nums.Length];
        for(int i=nums.Length - 1;i>=0;i--)
        {
            int square;
            if(Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                square = nums[right];
                right--;
            }
            else
            {
                square = nums[left];
                left++;
            }
            result[i] = square * square;
        }
        return result;
    }
}