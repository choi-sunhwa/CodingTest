using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        for(int i = 0; i < targets.Length; i++){
            var charDic = targets[i].GroupBy(x => x).ToDictionary(x => x.Key.ToString(), x => x.Count());
            foreach(string key in charDic.Keys){
                int min_idx = -1;
                for(int z = 0; z < keymap.Length; z++){
                    int idx = keymap[z].IndexOf(key);
                    if(z == 0) min_idx = idx;
                    
                    if(min_idx == -1 && idx > -1) min_idx = idx;
                    else if(min_idx > -1 && idx == -1) min_idx = min_idx;
                    else min_idx = Math.Min(min_idx, idx);
                }
                
                if(min_idx == -1) { 
                    answer[i] = -1;
                    break;
                }
                else answer[i] += charDic[key] * (min_idx + 1);
            }
        }
        
        return answer;
    }
}