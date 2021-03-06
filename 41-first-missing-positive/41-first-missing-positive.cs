public class Solution {
    //O(n) sc O(1)
    public int FirstMissingPositive(int[] nums) {
       if(nums.Length == 0) return 0;
       
        int n = nums.Length;
        int containsOne = 0;
        
        //step 1
        for(int i=0;i<n;i++)
        {
            if(nums[i] == 1)
                containsOne = 1;
            else if(nums[i] <= 0 || nums[i] > n)
                nums[i] = 1;
        }
        
        if(containsOne == 0)
            return 1;
        
        //step 2
        for(int i=0;i<n;i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if(nums[index] > 0)
                nums[index] = -1 * nums[index];
        }
        
        //step 3
        for(int i=0;i<n;i++)
        {
            if(nums[i] > 0)
                return i + 1;
        }
        
        //incase of [1,2,3] return 4
        return n + 1;
    }
}