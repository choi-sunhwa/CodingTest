using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[k];
        int[] arr_distinct = arr.Distinct().ToArray();
        
        if(k == arr_distinct.Length) answer = arr_distinct;
        else{
            for(int i = 0; i < k; i++){
                if(i < arr_distinct.Length) answer[i] = arr_distinct[i];
                else answer[i] = -1;
            } 
        }
        
        return answer;
    }
}