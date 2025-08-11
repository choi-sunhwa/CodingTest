using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        while(n >= a){
            int val = (n / a) * b;
            answer += val;
            n = val + (n % a);
        }
        
        return answer;
    }
}