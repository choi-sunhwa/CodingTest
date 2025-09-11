using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        Dictionary<string, int> dic = new Dictionary<string, int>{
            {"R", 4000}, {"T", 4000},
            {"C", 3000}, {"F", 3000},
            {"J", 2000}, {"M", 2000},
            {"A", 1000}, {"N", 1000}
        };
        
        Dictionary<int, int> conversion = new Dictionary<int, int>{
            {1, 3}, {2, 2},
            {3, 1}, {4, 0},
            {5, 1}, {6, 2}, {7, 3}
        };
        
        for(int i = 0; i < choices.Length; i++){
            string type = survey[i].Substring(0,1);
            if(choices[i] > 4){
                type = survey[i].Substring(1,1);
            }
            
            dic[type] += conversion[choices[i]];
        }
        
        var sorted = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
        
        for(int i = 0; i < sorted.Count; i+=2){
            answer += sorted[i].Key;
        }
        
        return answer;
    }
}