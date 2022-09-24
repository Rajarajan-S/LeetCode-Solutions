public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> PascalTriangle = new List<IList<int>>();
        
        if (numRows <= 0){
            return PascalTriangle;
        }
     
        List<int> prevRow = new List<int>{1};
        PascalTriangle.Add(prevRow);
        
        for(int i=1; i < numRows; i++){
            List<int> thisRow = new List<int>();
            thisRow.Add(1);
            
            for(int j=0; j < prevRow.Count-1; j++){
                int temp = prevRow[j]+prevRow[j+1];
                thisRow.Add(temp);
            }
            thisRow.Add(1);
            PascalTriangle.Add(thisRow);         
            prevRow = thisRow;
        }
        return PascalTriangle;
    }
}