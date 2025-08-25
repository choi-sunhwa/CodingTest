using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = (A == B) ? 0 : -1;
        
        char[] str;
        int cnt = 1;
        while(cnt < A.Length){
            str = new char[A.Length];
            for(int i = 0; i < A.Length; i++){
                str[(i + cnt >= A.Length) ? (i + cnt - A.Length) : (i + cnt)] = A[i];
            }

            if(String.Concat(str) == B) {
                answer = cnt;
                break;
            }
            else cnt++;            
        }
        
        return answer;
    }
}