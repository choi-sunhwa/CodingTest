using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>{};    
        
        int[] _today = Array.ConvertAll(today.Split('.'), int.Parse);
        int _todayCnt = ((_today[0] - 1) * 28 * 12) + ((_today[1] - 1) * 28) + _today[2];
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string _type = privacies[i].Split(' ')[1];
            int[] _date = Array.ConvertAll(privacies[i].Split(' ')[0].Split('.'), int.Parse);
            
            if(expireDateCompare(_todayCnt, Convert.ToInt32(terms.Where(x => x.IndexOf(_type) > -1).FirstOrDefault().Split(' ')[1]), _date)) answer.Add(i + 1);;
            
        }
        
        return answer.ToArray();
    }
    
    public bool expireDateCompare(int _todayCnt, int term, int[] _date){
        bool isExpire = false;
        
        int _expireDateCnt = ((_date[0] - 1) * 28 * 12) + ((_date[1] - 1) * 28) + (_date[2] + (28 * term));
        if(_todayCnt >= _expireDateCnt) isExpire = true;
        
        return isExpire;
    }
}