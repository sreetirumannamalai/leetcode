public class Solution {
    //Tok k frequent elements
    //TC O(n) SC O(N)
   public int[] TopKFrequent(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k == 0)
            return new int[] { };
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (var item in nums)
        {
            if (!dict.ContainsKey(item))
                dict.Add(item, 0);
            
            dict[item] += 1;
        }
        
        return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList<int>().ToArray();
    }
}
 