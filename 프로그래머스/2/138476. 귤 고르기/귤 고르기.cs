using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        int[] tangerine_distinct = tangerine.Distinct().ToArray();
        for(int i = 0; i < tangerine_distinct.Length; i++){
            dic.Add(tangerine_distinct[i], 0);
        }
        
        for(int i = 0; i < tangerine.Length; i++){
            dic[tangerine[i]]++;
        }
        
        var _list = dic.OrderByDescending(x => x.Value).ToList();

        for(int i = 0; i < _list.Count; i++){
            k -= _list[i].Value;
            answer++;
            
            if(k <= 0) break;
        }
        
        return answer;
    }
}