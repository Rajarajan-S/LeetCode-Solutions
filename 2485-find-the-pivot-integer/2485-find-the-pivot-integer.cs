public class Solution {
    public int PivotInteger(int n) {
        
        int a = n * (n + 1) / 2;
        int op = (int) Math.Sqrt(a);
        
        if (op * op == a) return op;
        else return -1;       
    }
}