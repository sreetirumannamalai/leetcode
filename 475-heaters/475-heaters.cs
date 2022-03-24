public class Solution {
    //O(nlogn + mlogm)
    public int FindRadius(int[] houses, int[] heaters) {
        Array.Sort(houses);
        Array.Sort(heaters);
        int j =0;
        int max = 0;
        for(int i=0;i<houses.Length;i++)
        {
            //move right until the next heater is closer or equal distance to current heater
            while(j+1 < heaters.Length && Math.Abs(houses[i] - heaters[j+1]) <= Math.Abs(heaters[j] - houses[i]))
            {
                j++;
            }
            max = Math.Max(max, Math.Abs(heaters[j] - houses[i]));
        }
        return max;
    }
}
         