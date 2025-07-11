using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        char[] arr = my_string.ToCharArray();
        while(s < e){
            char temp = arr[s];
            arr[s] = arr[e];
            arr[e] = temp;
            
            s++;
            e--;
        }
        
        return new string(arr);
    }
}