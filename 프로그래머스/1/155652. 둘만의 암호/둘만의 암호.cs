using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";

        for(int i = 0; i < s.Length; i++){
            char val = s[i];
            
            int cnt = 0;
            while(cnt < index){
                val++;
                if(val == 'z' + 1) val = 'a';
                
                while(skip.IndexOf(val.ToString()) > -1){
                    val++;
                    if(val == 'z' + 1) val = 'a';
                }
                
                cnt++;
            }
            
            answer += val.ToString();
        }
        
        return answer;
    }
}