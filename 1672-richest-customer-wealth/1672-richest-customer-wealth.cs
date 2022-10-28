public class Solution {
    public int MaximumWealth(int[][] accounts) {
       
        if (accounts.Length == 0) return 0;
        
        int max = 0;
        for(int i=0; i < accounts.Length; i++){
            int sum = 0;
            for(int j = 0; j < accounts[i].Length; j++){
                sum += accounts[i][j];
            }
            max = Math.Max(sum, max);
        }
        return max;
    }
}