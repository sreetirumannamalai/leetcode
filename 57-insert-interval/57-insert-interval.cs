public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if(intervals == null || intervals.Length == 0)
            return new int[][] {newInterval};
        
       List<int[]> result = new List<int[]>();
            int i = 0;

            // Step 1 - add all intervals ending before newInterval starts
            while (i < intervals.Length && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                i++;
            }

            // Step 2 - update the newInterval by merging with all overlapping intervals
            while (i < intervals.Length && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            result.Add(newInterval); // add updated interval

            // Step 3 - add remaining intervals
            while (i < intervals.Length)
                result.Add(intervals[i++]);

            return result.ToArray();
    }
}
  