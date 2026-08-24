public class MaxProfitII {
    
    public int MaxProfit(int[] prices) {
        
        int saldo = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            int lucro = prices[i] - prices[i - 1];
            if (lucro > 0)
            {
                saldo += lucro;
            }
        }

        return saldo;
    }
}
    
