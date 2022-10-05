public class Solution {
    
    Dictionary<char, char[]> LettersDict = new Dictionary<char, char[]>
    {
        { '2', new char[] { 'a', 'b', 'c' } },
        { '3', new char[] { 'd', 'e', 'f' } },
        { '4', new char[] { 'g', 'h', 'i' } },
        { '5', new char[] { 'j', 'k', 'l' } },
        { '6', new char[] { 'm', 'n', 'o' } },
        { '7', new char[] { 'p', 'q', 'r', 's' } },
        { '8', new char[] { 't', 'u', 'v' } },
        { '9', new char[] { 'w', 'x', 'y', 'z' } },
    };
    
    IList<string> finalres = new List<string>();
    
    public IList<string> LetterCombinations(string digits) {
        
        if (string.IsNullOrEmpty(digits)){
            return finalres;
        }
        finalres.Add("");
        
        foreach (char i in digits){
            IList<string> NumsLetter = new List<string>();
            var buttonletters = LettersDict.Where(x => x.Key == i).FirstOrDefault().Value;
            
            foreach (char l in buttonletters){
                foreach(string s in finalres){
                    NumsLetter.Add(s+l);
                }
            }
            finalres = NumsLetter;
        }
        return finalres;
    }
}