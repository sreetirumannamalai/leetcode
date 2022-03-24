public class Solution {
    //O(n)
   public int MinFlips(int a, int b, int c)
   {
      int d = a | b;
       int total = 0;
       int x, y, z;
       for(int i=0;i<32;i++)
       {
           x = a & (1 << i);
           y = b & (1 << i);
           z = c & (1 << i);
           if(z == 0 && x != 0 && y == 0) //both a has !0 ith bit & b has ith bit 0 and c has 0 ith bit
               total++;
           else if(z == 0 && x == 0 && y != 0) // both a has 0 ith bit & b has ith bit !0 and c has 0 ith bit
               total++;
           else if(z == 0 && x != 0 && y != 0) // both a & b has ith bit !0 and c has 0 ith bit
               total+=2;
           else if(z!=0 && x ==0 && y == 0) //both a & b has ith bit 0 and c has !0 ith bit
               total++;
       }
       return total;
   }
}
    