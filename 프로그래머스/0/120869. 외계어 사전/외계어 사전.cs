using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        
        int cnt = 0;
        foreach(string di in dic){
            cnt = 0;
            foreach(string sp in spell){
                if(di.IndexOf(sp) > -1) cnt++;
                else continue;
            }
            if(cnt == spell.Length) answer = 1;
        }
        
        return answer;
    }
}