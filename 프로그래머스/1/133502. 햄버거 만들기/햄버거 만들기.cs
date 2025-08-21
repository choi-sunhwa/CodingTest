using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        
        List<int> _ingredient = ingredient.ToList();
        int idx = 0;
        
        while(idx <= _ingredient.Count - 4){
            if(_ingredient[idx] == 1 && _ingredient[idx + 1] == 2 && _ingredient[idx + 2] == 3 && _ingredient[idx + 3] == 1){
                _ingredient.RemoveRange(idx, 4);
                answer++;
                idx = Math.Max(idx - 4, 0);
            }
            else idx += 1;
        }

        return answer;
    }
}