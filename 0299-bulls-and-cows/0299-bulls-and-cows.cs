public class Solution {
    public string GetHint(string secret, string guess) {
        
        int bulls = 0;
        int cows = 0;
        int [] secretCount = new int[10];
        int [] guessCount = new int[10];
        
        for(int i=0; i < secret.Length; i++){
            char secretChar = secret[i];
            char guessChar = guess[i];
            
            if(secretChar == guessChar){
                bulls++;
            }else{
                secretCount[secretChar - '0']++;
                guessCount[guessChar - '0']++;
            }
        }
        
        for(int i=0; i < 10; i++){
            cows += Math.Min(secretCount[i], guessCount[i]);
        }
        return bulls + "A" + cows + "B";
    }
}