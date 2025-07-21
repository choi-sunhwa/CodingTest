using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        
        int f_idx = arr.ToList().IndexOf(2);
        int l_idx = arr.ToList().LastIndexOf(2);
        
        if(f_idx == -1) answer.Add(-1);
        else if(f_idx == l_idx) answer.Add(2);
        else{
            answer = arr.Skip(f_idx).Take(l_idx - f_idx + 1).ToList();
        }
        
        return answer.ToArray();
    }
}