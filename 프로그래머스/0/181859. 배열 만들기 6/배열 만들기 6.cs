using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        
        int i = 0;
        while(i < arr.Length){
            if(answer.Count == 0) answer.Add(arr[i]);
            else{
                if(arr[i] == answer[answer.Count - 1]){
                    answer.RemoveAt(answer.Count - 1);
                }else{
                    answer.Add(arr[i]);
                }
            }
            i++;
        }
        
        if(answer.Count == 0) answer.Add(-1);
        
        return answer.ToArray();
    }
}