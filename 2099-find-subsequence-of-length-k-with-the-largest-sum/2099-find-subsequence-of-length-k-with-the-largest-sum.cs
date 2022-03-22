public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        List<int> n = nums.ToList();
        while (n.Count != k) {
            int mini = 0;
            for (int i = 0; i < n.Count; ++i)
                if (n[i] < n[mini])
                    mini = i;
            n.RemoveAt(mini);
        }
        
        return n.ToArray();;
    }
}