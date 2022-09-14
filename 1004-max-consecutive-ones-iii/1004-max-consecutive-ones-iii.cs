public class Solution {
    //Max Consecutive Ones III 
    //TC O(n) SC O(1)
    public int LongestOnes(int[] nums, int k) {
        int i =0;
        int j=0;
        while(i < nums.Length)
        {
            if(nums[i] == 0) k--;
            
            if(k < 0)
            {
                if(nums[j] == 0)
                {
                    k++;
                }
                j++;
            }
            i++;
        }
        return i - j;
    }
}

 