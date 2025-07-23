using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        List<int> answer = new List<int>();
        
        for(int i = 1; i < food.Length; i++){
            int cnt = food[i] / 2;
            for(int j = 0; j < cnt; j++) answer.Add(i);
        }
        
        List<int> answer_reversed = new List<int>(answer);
        answer_reversed.Reverse();
        
        answer.Add(0);
        answer.AddRange(answer_reversed);
        
        return string.Join("", answer);
    }
}