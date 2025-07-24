using System;

public class Solution {
    public int solution(int a, int b) {
        int part = a;
        int total = b;
        
        for(int i = part; i > 1; i--){
            if(part % i == 0 && total % i == 0){
                part = part / i;
                total = total / i;
            }
        }
        
        bool _continue = true;
        while(_continue){
            if(total % 5 == 0) total = total / 5;
            else _continue = false;
        }
        
        
        _continue = true;
        while(_continue){
            if(total % 2 == 0) total = total / 2;
            else _continue = false;
        }
        
        return total == 1 ? 1 : 2;
    }
}