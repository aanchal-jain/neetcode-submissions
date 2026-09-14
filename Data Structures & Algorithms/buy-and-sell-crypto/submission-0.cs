public class Solution {
    public int MaxProfit(int[] prices) {
        var profits = new int[prices.Length];
        for (int i = 0; i < prices.Length; i++)
        {
            int buyPrice = prices[i];
            int profit = 0;
            for(int j = i+1; j < prices.Length; j++)
            {
                profit = Math.Max(profit, prices[j] - buyPrice);
            }
            profits[i] = profit;
        }

        return profits.Max();
    }
}
