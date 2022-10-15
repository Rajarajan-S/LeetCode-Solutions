public class Solution {
    public int ClimbStairs(int n) {    
        int [] op = new int[n+1];
        op[0] = 1;
        op[1] = 1;
        for(int i = 2; i <= n; i++){
            op[i] = op[i-1] + op[i-2];
        }
        return op[n];
    }
}