public class Solution {
    public int MaxArea(int[] height) {
        int maxSoma=0;
        int inicio=0;
        int fim=height.Length-1;
        
        while(inicio<fim){
            int tam = fim-inicio;
            int area = Math.Min(height[inicio], height[fim]) * tam;
            maxSoma = Math.Max(maxSoma, area);
            if(height[inicio] < height[fim])
            {
                inicio++;
            }else{
                fim--;
            }

        }
        return maxSoma;
    }
}