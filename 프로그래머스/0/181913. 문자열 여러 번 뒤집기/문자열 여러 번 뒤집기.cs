using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = "";
        
        char[] _answer = my_string.ToCharArray();
        for(int i = 0; i < queries.GetLength(0); i++){
            int start = queries[i,0];
            int end = queries[i,1];
            
            while(start < end){
                char temp = _answer[start]; 
                _answer[start] = _answer[end]; 
                _answer[end] = temp;
                
                start++;
                end--;
            }
        }
        
        return new string(_answer);
    }
}