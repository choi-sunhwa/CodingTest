using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);

        if(row == col) return arr;
        
        int[,] answer = new int[row,row];
        if(row < col) answer = new int[col,col];
        
        for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
                answer[i,j] = arr[i,j];
            }
        }
        
        return answer;
    }
}