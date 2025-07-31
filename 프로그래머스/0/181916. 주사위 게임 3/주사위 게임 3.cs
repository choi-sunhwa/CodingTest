using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
       
        List<int> val = new List<int>{a, b, c, d};
        var distinctList = val.GroupBy(x => x).Select(x => new {key = x.Key, Count = x.Count()}).OrderBy(x => x.Count).ToList();

        if(distinctList.Count == 4){
            answer = distinctList.Select(x => x.key).Min();
        }
        else if(distinctList.Count == 3){
            answer = distinctList[0].key * distinctList[1].key;
        }
        else if(distinctList.Count == 2){ //count가 [3,1], [2,2] 2개
            if(distinctList[0].Count == 1){
                answer = (int)Math.Pow((10 * distinctList[1].key + distinctList[0].key), 2);
            }
            else{
                answer = (distinctList[0].key + distinctList[1].key) * (Math.Abs(distinctList[0].key - distinctList[1].key));
            }
        }
        else{
            answer = 1111 * distinctList[0].key;
        }
        
        return answer;
    }
}