using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach(char c in my_string){
            if(answer.IndexOf(c) == -1){
                answer += c.ToString();
            }
        }
        
        return answer;
    }
}