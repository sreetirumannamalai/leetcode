public class Solution {
    public int FindRadius(int[] houses, int[] heaters)
     {
          int n= houses.Length;
        int m = heaters.Length;
        Array.Sort(houses);
        Array.Sort(heaters);
        int j = 0;
        int max = 0;
        for(int i=0; i< n;i++)
        {
            //move right until the next heater is closer or equal distance to current heater
            while(j + 1 < m && Math.Abs(houses[i] - heaters[j+1]) <= Math.Abs(heaters[j] - houses[i]))
            {
                j++;
            }
            max = Math.Max(max, Math.Abs(heaters[j] - houses[i]));
        }
        return max;
    }
}

 