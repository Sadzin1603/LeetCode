public class RomanToInteger {
    public int RomanToInt(string s) {
        int sum=0;
        for(int i=0;i<s.Length-1;i++)
        {
            if(ToNum(s[i]) < ToNum(s[i+1]) )
            {
                sum-=ToNum(s[i]);
            }else
            {
                sum+=ToNum(s[i]);
            }
        }
        sum+=ToNum(s[s.Length-1]);
        return sum;
      
    } 
    public int ToNum(char roman)
    {
        switch (roman)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
