using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        
        int b = (numer1 * denom2) + (numer2 * denom1);
        int a = denom1 * denom2;
        
        for(int i = 2; i <= (a > b ? b : a); i++){
            bool _continue = true;
            while(_continue){
                if(b % i == 0 && a % i == 0){
                    b = b / i;
                    a = a / i;
                }
                else _continue = false;
            }
        }
        
        answer[0] = b; answer[1] = a;
        
        return answer;
    }
}