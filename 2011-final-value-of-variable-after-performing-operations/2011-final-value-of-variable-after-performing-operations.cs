public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        
        if(operations.Length == 0) return 0;
        
        int op = 0;
        
        for(int i = 0; i < operations.Length; i++){
            if(operations[i] == "++X" || operations[i] == "X++")  op = op + 1;
            else  op = op - 1;
        }
        return op;
    }
}