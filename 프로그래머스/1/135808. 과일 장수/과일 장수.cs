using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        Array.Sort(score);
        
        for(int i = (score.Length - 1); i >= 0; i -= m){
            if(i - (m - 1) >= 0) answer += score[i - (m - 1)] * m;
            else break;
        }
        
        return answer;
    }
}