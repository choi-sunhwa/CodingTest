using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        List<int> list = new List<int>();
        
        for(int i = 1; i <= rank.Length; i++){
            int idx = rank.Select((val,index) => new{val,index}).FirstOrDefault(x => x.val == i).index;
            if(attendance[idx] == true){
                list.Add(idx);
                if(list.Count == 3) break;
            }
        }
        
        answer = list[0] * 10000 + list[1] * 100 + list[2];
        
        return answer;
    }
}