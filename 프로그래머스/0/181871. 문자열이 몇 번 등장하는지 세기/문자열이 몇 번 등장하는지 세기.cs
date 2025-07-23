using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        int idx = 0;
        char[] chars = myString.ToCharArray();
        
        while(idx > -1){
            idx = myString.IndexOf(pat);
            if(idx > -1){
                answer++;
                chars[idx] = ' ';
                myString = new string(chars);
            }
        }
        
        return answer;
    }
}