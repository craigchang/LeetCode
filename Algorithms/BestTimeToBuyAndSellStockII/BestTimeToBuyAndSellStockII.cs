public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0 || prices.Length == 1) return 0;
        
        int totalProfit = 0;
        bool canBuy = true;
        
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (canBuy) // can start buying again
            {
                if (prices[i] < prices[i + 1])
                {
                    totalProfit -= prices[i];
                    canBuy = false;
                }
            }
            else  // can only sell 
            {
                if (prices[i] > prices[i + 1])
                {
                    totalProfit += prices[i];
                    canBuy = true;
                }
            }
        }
        
        if (prices[prices.Length - 1] >= prices[prices.Length - 2] && !canBuy)
            totalProfit += prices[prices.Length - 1];

        return totalProfit;
    }
}