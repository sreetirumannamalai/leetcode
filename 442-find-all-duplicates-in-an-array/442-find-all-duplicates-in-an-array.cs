public class Solution {
    //O(n) no extra space required
    public IList<int> FindDuplicates(int[] nums) {
        List<int> ans = new List<int>();
        
        foreach(int num in nums)
        {
            if(nums[Math.Abs(num) - 1] < 0)
            {
                ans.Add(Math.Abs(num));
            }
            nums[Math.Abs(num) - 1] *= -1;
        }
        return ans;
    }
}