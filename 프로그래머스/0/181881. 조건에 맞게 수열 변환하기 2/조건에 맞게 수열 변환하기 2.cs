using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int[] arr_prev = new int[arr.Length];
        bool _continue = true;
        int change = 0;
        
        while(_continue){
            change = 0;
            if(answer > 0) arr_prev = (int[])arr.Clone();
            
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] >= 50 && arr[i] % 2 == 0) {
                    arr[i] = arr[i] / 2;
                    change++;
                }
                else if(arr[i] < 50 && arr[i] % 2 == 1) { 
                    change++;
                    arr[i] = arr[i] * 2 + 1;
                }
            }
            
            if(change == 0) break;
            else if(answer > 0){
                for(int i = 0; i < arr.Length; i++){
                    if(arr[i] != arr_prev[i]) break;
                    else if(i == (arr.Length -1)) _continue = false;
                }
            }
            
            if(_continue) answer++;
        }
        
        return answer;
    }
}