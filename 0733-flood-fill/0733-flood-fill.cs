public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color)
            return image;
        
        var originalColor = image[sr][sc];
        
        var changeStack = new Stack<(int i, int j)>();
        changeStack.Push((sr, sc));
        
        while(changeStack.Count > 0) {
            var (i, j) = changeStack.Pop();
            
            if (i < 0 || i > image.Length - 1 ||
                j < 0 || j > image[0].Length - 1)
                continue;
            
            if (image[i][j] != originalColor || image[i][j] == color)
                continue;
            
            image[i][j] = color;

            changeStack.Push((i - 1, j)); 
            changeStack.Push((i + 1, j)); 
            changeStack.Push((i, j + 1)); 
            changeStack.Push((i, j - 1)); 
        }
        
        return image;
    }
}