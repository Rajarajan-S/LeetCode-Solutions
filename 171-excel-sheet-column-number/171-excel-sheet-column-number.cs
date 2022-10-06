public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;
        int len = columnTitle.Length-1;
        
        for(int i=0; i <= len; i++)
        {
            int temp = (int)Math.Pow(26,(len-i)) * (columnTitle[i] - 64);   
                        
            result += temp;
        }      
        return result;
    }
}