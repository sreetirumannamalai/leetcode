public class Solution {
   public int MinFlips(int a, int b, int c)
        {
             int count = 0;
            while (a != 0 || b != 0 || c != 0)
            {
                if (((a & 1) | (b & 1)) != (c & 1))
                {
                    if (((a & 1) & (b & 1)) == 1)
                        count++;
                    count++;
                }
                a >>= 1;
                b >>= 1;
                c >>= 1;
            }

            return count;
        }
}