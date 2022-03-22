public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        Backtracking(nums, new List<int>(), result);
        return result;
    }
    
    private void Backtracking(int[] nums, List<int> list, List<IList<int>> result)
    {
        if(list.Count == nums.Length)
        {
            result.Add(new List<int>(list));
            return;
        }
        else
        {
            for(int i =0;i<nums.Length;i++)
            {
                if(list.Contains(nums[i]))
                    continue;
                
                list.Add(nums[i]);
                Backtracking(nums, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
   