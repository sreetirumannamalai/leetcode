public class Solution {
    //O(nlogn) sc O(n)
    public int MinMeetingRooms(int[][] intervals) {
        if(intervals.Length == 0) return 0;
        int[] startTimes = new int[intervals.Length];
        int[] endTimes = new int[intervals.Length];
        
        for(int i =0;i<intervals.Length;i++)
        {
            startTimes[i] = intervals[i][0];
            endTimes[i] = intervals[i][1];
        }
        
        Array.Sort(startTimes);
        Array.Sort(endTimes);
        
        int startPtr = 0;
        int endPtr = 0;
        
        for(int i = startPtr; i< startTimes.Length; i++)
        {
            if(startTimes[i] < endTimes[endPtr])
            {
                startPtr++;
            }
            else
            {
                endPtr++;
            }
        }
        return startPtr;
    }
}