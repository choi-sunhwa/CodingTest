using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        TimeSpan video_len_ts = new TimeSpan(0, int.Parse(video_len.Split(':')[0]), int.Parse(video_len.Split(':')[1]));
        TimeSpan pos_ts = new TimeSpan(0, int.Parse(pos.Split(':')[0]), int.Parse(pos.Split(':')[1]));
        TimeSpan op_start_ts = new TimeSpan(0, int.Parse(op_start.Split(':')[0]), int.Parse(op_start.Split(':')[1]));
        TimeSpan op_end_ts = new TimeSpan(0, int.Parse(op_end.Split(':')[0]), int.Parse(op_end.Split(':')[1]));
        
        pos_ts = pos_ts_cal(video_len_ts, pos_ts, op_start_ts, op_end_ts);
        
        foreach(string command in commands){
            if(command == "prev"){
                pos_ts = new TimeSpan(0, pos_ts.Minutes, pos_ts.Seconds - 10);
            }
            else{
                pos_ts = new TimeSpan(0, pos_ts.Minutes, pos_ts.Seconds + 10);
            }
            
            pos_ts = pos_ts_cal(video_len_ts, pos_ts, op_start_ts, op_end_ts);
        }
        
        return pos_ts.Minutes.ToString("0#") + ":" + pos_ts.Seconds.ToString("0#");
    }
    
    public TimeSpan pos_ts_cal(TimeSpan video_len_ts, TimeSpan pos_ts, TimeSpan op_start_ts, TimeSpan op_end_ts){
        TimeSpan retVal = pos_ts;
        if(pos_ts.Minutes == 0 && pos_ts.Seconds < 10) retVal = new TimeSpan(0, 0, 0);
        else if(video_len_ts - pos_ts < TimeSpan.Zero || video_len_ts - pos_ts < TimeSpan.FromSeconds(10)) retVal = video_len_ts;
        
        if(pos_ts - op_start_ts >= TimeSpan.Zero && op_end_ts - pos_ts >= TimeSpan.Zero) retVal = op_end_ts;
        
        return retVal;
    }
}