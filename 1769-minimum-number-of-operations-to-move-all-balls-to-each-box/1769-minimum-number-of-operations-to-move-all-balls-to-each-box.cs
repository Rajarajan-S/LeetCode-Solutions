public class Solution {
    public int[] MinOperations(string boxes) {
        
        int [] res = new int[boxes.Length];
        int op = 0, count = 0;
        
        for(int i=0; i<boxes.Length; i++){           
            res[i] += op;
            count += boxes[i] - '0';
            op += count;
        }
        
        op = 0; count = 0;
        
        for(int i=boxes.Length-1; i>-1; i--){           
            res[i] += op;
            count += boxes[i] - '0';
            op += count;
        }
        return res;
    }
}