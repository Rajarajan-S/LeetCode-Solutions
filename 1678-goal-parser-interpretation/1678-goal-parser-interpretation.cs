public class Solution {
    public string Interpret(string command) {
        
        string s = "";
        
        for(int i=0; i < command.Length; i++){
            
            if(command[i] == '(' && command[i+1] == ')'){
                s += "o";
                i++;
            }
            else if (command[i] == '(' && command[i+1] == 'a'){
                s += "al";
                i += 3;
            }          
            else{
                s += command[i];                
            }  
        }
        return s;
    }
}