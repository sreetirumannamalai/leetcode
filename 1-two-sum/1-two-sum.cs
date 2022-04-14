public class Solution {
    //O(n) sc O(1)
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        for(int i =0;i<nums.Length;i++)
        {
            int entry = target - nums[i];
            if(dict.ContainsKey(entry))
            {
                return new int[] {(int)dict[entry], i};
            }
            else if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
       return null;
    }
}