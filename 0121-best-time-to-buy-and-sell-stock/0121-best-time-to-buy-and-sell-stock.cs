public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0;
        
        if(prices != null && prices.Length > 1){
            
            int best_buying_price = prices[0];
            
            for(int i = 1; i < prices.Length; i++){
                
                profit = Math.Max(profit, prices[i] - best_buying_price);
                best_buying_price = Math.Min(best_buying_price, prices[i]);
            }
            
        }
        return profit;
    }
}