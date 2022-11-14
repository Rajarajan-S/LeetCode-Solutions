public class Solution {
    public double[] ConvertTemperature(double celsius) {
        
        double [] ans = new double[2];
        ans[0] = celsius + 273.15;
        ans[1] = celsius * 1.8 + 32.00;
        
        return ans;        
    }
}