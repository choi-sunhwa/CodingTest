using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        
        double[] average_ori = new double[score.GetLength(0)];
        double[] average_arr = new double[score.GetLength(0)];
        int[] rank_arr = new int[score.GetLength(0)];
        for(int i = 0; i < score.GetLength(0); i++){
            average_arr[i] = Convert.ToDouble(score[i,0]+score[i,1]) / 2;
            average_ori[i] = average_arr[i];
        }
        
        Array.Sort(average_arr);
        Array.Reverse(average_arr);
        
        for(int i = 0; i < average_arr.Length; i++){
            rank_arr[i] = (i + 1);
            if(i > 0 && average_arr[i] == average_arr[i - 1]) rank_arr[i] = rank_arr[i - 1];
        }
        
        for(int i = 0; i < average_arr.Length; i++){
            double val = average_ori[i];
            for(int j = 0; j < average_arr.Length; j++){
                if(val == average_arr[j]){
                    answer[i] = rank_arr[j];
                    break;
                }
            }
        }
        
        return answer;
    }
}