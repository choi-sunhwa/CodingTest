using System;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        
        int x = lines[0,0], y = lines[0,1];
        
        for(int i = 0; i < lines.GetLength(0); i++){
            if(x < lines[i,0]) x = lines[i,0];
            if(y > lines[i,1]) y = lines[i,1];
            
            for(int j = (i + 1); j < lines.GetLength(0); j++){
                int start = lines[i,0], end = lines[i,1];
                if(lines[i,0] < lines[j,0]) start = lines[j,0];
                if(lines[i,1] > lines[j,1]) end = lines[j,1];
                
                if(end > start) answer += Math.Abs(end - start);
            }
        }
        
        if(y > x) answer -= (Math.Abs(y - x) * 2);
        
        return answer;
    }
}