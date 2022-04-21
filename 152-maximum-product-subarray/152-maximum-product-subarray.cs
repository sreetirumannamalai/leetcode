public class Solution {
    //O(n) sc O(1)
    public int MaxProduct(int[] nums) {
      if (nums.Length == 0) return -1;
            int currentMax = nums[0];
            int currentMin = nums[0];
            int finalMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = currentMax;
                currentMax = Math.Max(Math.Max(currentMax * nums[i], currentMin * nums[i]), nums[i]);
                currentMin = Math.Min(Math.Min(temp * nums[i], currentMin * nums[i]), nums[i]);
                if (currentMax > finalMax)
                {
                    finalMax = currentMax;
                }
            }
            return finalMax;
    }
}
 