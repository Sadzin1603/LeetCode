public class MaxProfit {
    public int MaxProfit(int[] prices) {

        int maior_saldo= 0;
        int menor_valor = int.MaxValue;
        for(int i=0;i<prices.Length;i++)
        {
            if(prices[i]< menor_valor)
            {
                menor_valor = prices[i];
            }
            int lucro = prices[i] - menor_valor;
            if(lucro > maior_saldo)
            {
                maior_saldo = lucro;
            }
        }
        return maior_saldo;
    }
}