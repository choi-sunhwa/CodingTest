using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string a, string b) {
        string answer = "";
        
        int maxLength = a.Length;
        if(maxLength < b.Length) maxLength = b.Length;
        
        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');
        
        int[] a_arr = a.Select(x => x - '0').ToArray();
        int[] b_arr = b.Select(x => x - '0').ToArray();
         
        int q = 0; //몫
        for(int i = (maxLength - 1); i >= 0; i--){
            answer += (a_arr[i] + b_arr[i] + q) % 10;
            q = (a_arr[i] + b_arr[i] + q) / 10;
        }
        
        if(q > 0) answer += q;
        
        return string.Concat(answer.Reverse());
    }
}