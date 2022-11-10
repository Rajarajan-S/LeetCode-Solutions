public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0;
        int product = 1;
        var num = n.ToString();
        for(var i = 0; i < num.Length; i++){
            sum += int.Parse(num.Substring(i,1));
            product *= int.Parse(num.Substring(i,1));
        }
        int difference = product - sum;
        return difference;
    }
}