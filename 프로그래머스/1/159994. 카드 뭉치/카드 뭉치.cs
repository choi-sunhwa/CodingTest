using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        
        List<string> _cards1 = cards1.ToList();
        List<string> _cards2 = cards2.ToList();
        
        for(int i = 0; i < goal.Length; i++){
            if(_cards1.Count > 0 && _cards1[0] == goal[i]){
                _cards1.RemoveAt(0);
            }
            else if(_cards2.Count > 0 && _cards2[0] == goal[i]){
                _cards2.RemoveAt(0);
            }
            else{ 
                answer = "No";
                break;
            }
        }
        
        return answer;
    }
}