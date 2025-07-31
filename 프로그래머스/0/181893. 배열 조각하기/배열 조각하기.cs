using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        List<int> answer = arr.ToList();
            
        for(int i = 0; i < query.Length; i++){
            if(i % 2 == 0){
                answer = answer.Take(query[i] + 1).ToList();
            }
            else{
                answer = answer.Skip(query[i]).ToList();
            }
        }
        
        return answer.ToArray();
    }
}