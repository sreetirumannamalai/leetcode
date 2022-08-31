/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
         int low = 0;
         int high = n;
        while(low < high)
        {
            int mid = low + (high - low)/2;
            bool isVersion = IsBadVersion(mid);
            if(!isVersion)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return low;
    }
}