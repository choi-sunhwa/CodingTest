using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        
        string direction = "R";
        int[] points = new int[]{0, 0};
        
        for(int i = 1; i <= n*n; i++){
            answer[points[0],points[1]] = i;
            if(direction == "R"){
                points[1]++;
                if(points[1] == n || answer[points[0],points[1]] > 0){
                    direction = "D";
                    points[0]++;
                    points[1]--;
                }
            }
            else if(direction == "D"){
                points[0]++;
                if(points[0] == n || answer[points[0],points[1]] > 0){
                    direction = "L";
                    points[0]--; points[1]--;
                }
            }
            else if(direction == "L"){
                points[1]--;
                if(points[1] < 0 || answer[points[0],points[1]] > 0){
                    direction = "U";
                    points[0]--; points[1]++;
                }
            }
            else
            {
                points[0]--;
                if(answer[points[0],points[1]] > 0){ 
                    direction = "R";
                    points[0]++; points[1]++;
                }
            }
        }
        
        return answer;
    }
}