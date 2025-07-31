using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = arr.ToList();
        
        int i = 0;
        while(true){
            int val = (int)Math.Pow(2,i);
            if(arr.Length == val) break;
            else if(arr.Length < val){
                 for(int j = 0; j < val - arr.Length; j++){
                     answer.Add(0);
                 }   
                break;
            }        

            i++;
        }
        
        return answer.ToArray();
    }
}