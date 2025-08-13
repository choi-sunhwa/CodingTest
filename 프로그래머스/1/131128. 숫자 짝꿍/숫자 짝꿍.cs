using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int cnt1 = 0, cnt2 = 0;
        List<int> num = new List<int>();
        
        for(int i = 9; i >= 0; i--){
            cnt1 = X.Where(x => x.ToString() == i.ToString()).Count();
            cnt2 = Y.Where(x => x.ToString() == i.ToString()).Count();
            
            if(cnt1 > 0 && cnt2 > 0){
                num.AddRange(Enumerable.Repeat(i, Math.Min(cnt1,cnt2)).ToList());
            }
        }
        
        if(num.Count() == 0) answer = "-1";
        else{
            answer = String.Concat(num);
            if(answer.Replace("0","").Length == 0) answer = "0";
        }
        
        return answer;
    }
}