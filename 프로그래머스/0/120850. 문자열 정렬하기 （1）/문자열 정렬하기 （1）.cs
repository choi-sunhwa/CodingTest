using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> answer = new List<int>();
        
        foreach(char c in my_string){
            if(char.IsDigit(c)){
                answer.Add(Convert.ToInt32(c.ToString()));
            }
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}