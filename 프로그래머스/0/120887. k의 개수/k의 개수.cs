using System;
using System.Linq;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        for(int z = i; z <= j; z++){
            answer += z.ToString().Count(x => x.ToString() == k.ToString());
        }
        
        return answer;
    }
}