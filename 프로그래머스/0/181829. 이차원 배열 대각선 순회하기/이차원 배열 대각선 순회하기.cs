using System;

public class Solution {
    public int solution(int[,] board, int k) {
        int answer = 0;
        
        for(int i = 0; i < board.GetLength(0); i++){
            if(i > k) break;
            
            for(int j = 0; j < board.GetLength(1); j++){
                if(j > k) break;
                if(i + j <= k) answer += board[i,j];
            }
        }
        
        return answer;
    }
}