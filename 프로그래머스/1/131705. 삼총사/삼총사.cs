using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        
        for(int i = 0; i < number.Length; i++){
            int sum = number[i];
            
            for(int j = (i + 1); j < number.Length; j++){
                sum += number[j];
                
                for(int k = (j + 1); k < number.Length; k++){
                    sum += number[k];
                    if(sum == 0) answer++;
                    sum -= number[k];
                }
                
                sum -= number[j];
            }
        }
        
        return answer;
    }
}