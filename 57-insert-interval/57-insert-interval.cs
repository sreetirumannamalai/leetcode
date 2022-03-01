public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if(intervals == null || intervals.Length == 0)
            return new int[][] {newInterval};
        
        List<int[]> result = new List<int[]>();
        int i = 0;
        while(i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }
        
        while(i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            i++;
        }
        result.Add(newInterval);
        
        while(i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }
        return result.ToArray();
    }
}
  