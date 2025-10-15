using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        
        int len = 0, val = section[0];
        for(int i = 1; i < section.Length; i++){
            len = section[i] - val + 1;
            if(len > m) {
                answer++;
                val = section[i];
                len = 0;
            }

            if(i == (section.Length - 1)) answer++;
        }
        
        if(answer == 0) answer++;
        
        return answer;
    }
}