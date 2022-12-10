public class Solution {
    public string IntToRoman(int num) {
        string[] M = new string[] { "", "M", "MM", "MMM" };
        string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        return M[num / 1000 % 10] + C[num / 100 % 10] + X[num / 10 % 10] + I[num % 10];
    }
}
