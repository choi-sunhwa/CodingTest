using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> answer = new List<int>();
        
        if(l % 5 > 0) l += 5 - (l % 5);
        
        for(int i = l; i <= r; i+=5){
            string val = i.ToString().Replace("0","").Replace("5","");
            if(val.Length == 0){
                answer.Add(i);
            }
        }
        
        if(answer.Count == 0) answer.Add(-1);
        
        return answer.ToArray();
    }
}