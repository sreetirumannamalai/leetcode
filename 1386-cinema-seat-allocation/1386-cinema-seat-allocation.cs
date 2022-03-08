public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        int count = 0;
        bool[] seats;
        Dictionary<int, bool[]> map = new Dictionary<int, bool[]>();
        
       for (int i = 0; i < reservedSeats.Length; i++) {
				    int row=reservedSeats[i][0];
				    int s=reservedSeats[i][1];
				    if(s==1 || s==10) {
						  continue;
					}
				
				   if (map.ContainsKey(row)) {
					     seats=map[row];
				   }else {
					    seats=new bool[3];
					    seats[0]=true;
					    seats[1]=true;
					    seats[2]=true;
				   }
					
					if(s==2 || s==3) {
						seats[0]=false;
					}else if(s==8 || s==9) {
						seats[2]=false;
					}else if(s==4 || s==5) {
						seats[0]=false;
						seats[1]=false;
					}else if(s==6 || s==7) {
						seats[1]=false;
						seats[2]=false;
					}
                   if(!map.ContainsKey(row))
                   {
                         map.Add(row, seats);
                   }
			}
			
			foreach (var entry in map)
            {  
				     bool[] seatsAvlble=entry.Value;
				     if((seatsAvlble[0] && seatsAvlble[1] && seatsAvlble[2]) || seatsAvlble[0] && seatsAvlble[2]) {
				    	   count+=2;
				     }else if((seatsAvlble[0] && seatsAvlble[2]) || seatsAvlble[0] || seatsAvlble[1]) {
				    	 count++;
				     }else if((seatsAvlble[1] && seatsAvlble[2]) || seatsAvlble[1] || seatsAvlble[2]) {
				    	 count++;
				     }
			}
			
			count=count + (n-map.Count) *2;

		return count;
	}
}