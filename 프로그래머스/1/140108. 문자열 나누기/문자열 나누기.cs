using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int idx = 0;
        int[] cntVal = new int[]{1, 0};
        while(true){
            for(int i = (idx + 1); i < s.Length; i++){
                if(s[idx] == s[i]) cntVal[0]++;
                else cntVal[1]++;
                
                if(cntVal[0] == cntVal[1]){
                    answer++;
                    idx = i + 1;
                    cntVal[0] = 1; cntVal[1] = 0;
                    break;
                }
            }

            if(cntVal[0] > 1 || cntVal[1] > 0) {
                answer++;
                break;
            }
            
            if(idx >= (s.Length - 1)) {
                if(idx == (s.Length - 1)) answer++;
                break;
             }
        }
        
        return answer;
    }
}