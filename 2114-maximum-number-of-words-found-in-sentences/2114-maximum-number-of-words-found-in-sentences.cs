public class Solution {

    public int MostWordsFound(string[] sentences) {

        if(sentences == null || sentences.Length == 0)

            return 0;     

        int res = 0;

        foreach(var sentence in sentences)

        {
            string[] words = sentence.Split(new char[]{' '});
            res = Math.Max(res, words.Length);
        }
        return res;
    }
}
        

