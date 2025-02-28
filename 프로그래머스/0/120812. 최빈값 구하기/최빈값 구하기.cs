using System;

public class Solution {
    public int solution(int[] array) { 
        int answer = -1;
        
        int count = 0;
        for(int i = 0; i < array.Length; i++){
            int subCount = 0;
            int comVal = array[i];
            if(comVal == answer) continue;
                
            for(int j = i; j < array.Length; j++){
                if(comVal == array[j]) subCount++;
            }
            
            if(subCount > count) {
                answer = comVal;  
                count = subCount;
            } 
            else if(subCount == count){
                answer = -1;
            }
        }
        
        return answer;
    }
}