public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int minDistance = wordsDict.Length;
        int index1 = -1;
        int index2 = -1;
        for(int i =0;i< wordsDict.Length;i++)
        {
            if(wordsDict[i] == word1)
                index1 = i;
            else if(wordsDict[i] == word2)
                index2 = i;
            
            if(index1 != -1 && index2 != -1)
            {
                minDistance = Math.Min(minDistance, Math.Abs(index1 - index2));
            }
        }
        return minDistance;
    }
}
