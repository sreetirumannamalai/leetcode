public class Solution {
    public int ArraySign(int[] nums) {
        if(nums.Length == 0) return 0;
     
        int sign = 1;
        foreach(int num in nums)
        {
            if(num == 0)
                return 0;
            else if(num < 0)
            {
                sign = -sign;
                Console.WriteLine(sign);
            }
        }
        
        return sign;
    }
}