public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {        
        int max = 0;
        foreach(int c in candies){
            if (c > max) max = c;
        }
        
        List<bool> res = new List<bool>();
        foreach(int c in candies){
            res.Add(c + extraCandies >= max);
        }
        return res;
    }
}