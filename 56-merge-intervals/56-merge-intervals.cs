public class Solution {
    public int[][] Merge(int[][] intervals) {
       List<int[]> result = new List<int[]>();
        
        if(intervals.Length == 0)
            return result.ToArray();
        
        //Sort on start intervals
        Array.Sort(intervals, (x,y)=>x[0].CompareTo(y[0]));
        
        int start = intervals[0][0];
        int end = intervals[0][1];
        
        for(int i=1;i<intervals.Length;i++)
        {
            if(end < intervals[i][0])
            {
                result.Add(new int[]{start, end});
                start = intervals[i][0];
                end = intervals[i][1];
            }
            else
            {
                end = Math.Max(end, intervals[i][1]);
            }
        }
        result.Add(new int[]{start, end});
       return result.ToArray();
    }
}