public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        int sum = 0;
        foreach(char i in stones.ToCharArray()){
            if (jewels.Contains(i)) sum++;
        }
        return sum;
    }
}