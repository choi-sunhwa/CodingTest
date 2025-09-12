using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        
        int _startday = startday;
        for(int i = 0; i < schedules.Length; i++){
            bool isPrize = true; 
            _startday = startday;
            int time = (schedules[i] + 10);
            if((time % 100) > 59){
                time = ((time / 100 + 1) * 100) + ((time % 100) - 60); 
            }
            
            for(int j = 0; j < timelogs.GetLength(1); j++){
                if(_startday < 6) {
                    if(timelogs[i,j] > time){
                        isPrize = false;
                        break;
                    }
                }
                
                _startday++;
                if(_startday > 7) _startday -= 7;
            }
            
            if(isPrize) answer++;
        }
        
        return answer;
    }
}