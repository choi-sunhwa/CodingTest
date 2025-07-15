using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        string val = "";
        foreach(char ch in my_string){
            if(char.IsDigit(ch)){
                val += ch.ToString();
            }
            else {
                if(val != "") answer += Convert.ToInt32(val);
                val = "";
             }
        }
        
        if(val != "") answer += Convert.ToInt32(val);
        
        return answer;
    }
}