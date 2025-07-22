using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++){
            if(s.IndexOf(s[i]) == s.LastIndexOf(s[i])){
                answer += s[i];
            }
        }
        
        answer = new string(answer.OrderBy(x => x).ToArray());
        
        return answer;
    }
}