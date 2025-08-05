using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Array.Fill(answer, -1);
        
        char[] s_arr = s.ToCharArray();
        
        int idx = -1;
        for(int i = 1; i < s_arr.Length; i++){
            idx = Array.LastIndexOf(s_arr, s_arr[i], i - 1);
            if(idx > -1){
                answer[i] = i - idx;
            }
        }
        
        return answer;
    }
}