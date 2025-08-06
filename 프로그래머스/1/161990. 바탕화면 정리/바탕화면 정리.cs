using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {wallpaper.Length, wallpaper[0].Length, 0, 0};
        
        for(int i = 0; i < wallpaper.Length; i++){
            for(int j = 0; j < wallpaper[i].Length; j++){
                if(wallpaper[i][j] == '#'){
                    if(i < answer[0]) answer[0] = i;
                    if((i + 1) > answer[2]) answer[2] = (i + 1);
                    
                    if(j < answer[1]) answer[1] = j;
                    if((j + 1) > answer[3]) answer[3] = (j + 1);
                }
            }
        }
        
        return answer;
    }
}