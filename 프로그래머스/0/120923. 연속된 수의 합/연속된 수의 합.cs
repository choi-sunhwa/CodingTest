using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        
        int cal = (num % 2 == 0) ? (num / 2) - 1 : (num / 2);
        int val =  (total / num) - cal;
        
        for(int i = 0; i < num; i++){
            answer[i] = val;
            val++;
        }
        
        return answer;
    }
}