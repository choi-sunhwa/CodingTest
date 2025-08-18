using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        
        string[] values = {"aya", "ye", "woo", "ma"};
        
        foreach(string str in babbling){
            bool isOverlap = false; string rep_str = str;
            for(int i = 0; i < values.Length; i++){
                rep_str = rep_str.Replace(values[i], $"{i}{values[i]}{i}");
                if(rep_str.Split(values[i]).Where(x => x == i.ToString() + i).Count() > 0) {
                    isOverlap = true;
                    break;
                }
                else{
                    rep_str = rep_str.Replace(values[i], "");
                }
            }
            
            if(!isOverlap){
                for(int i = 0; i < values.Length; i++){
                    rep_str = rep_str.Replace(i.ToString(), "");
                }
                
                if(string.IsNullOrEmpty(rep_str)) answer++;
            }
        }
        
        return answer;
    }
}