using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        
        int[] val = new int[]{0, 0};
        foreach(string str in polynomial.Split(' ')){
            if(str != "+"){
                if(str.IndexOf('x') > -1){
                    val[0] += 
                        (str == "x" ? 1 : Convert.ToInt32(str.Replace("x","")));
                }
                else val[1] += Convert.ToInt32(str);
            }
        }
        
        if(val[0] > 0){
            if(val[0] > 1) answer += val[0];
            answer += "x";
            if(val[1] > 0) answer += " + " + val[1];
        }
        else{
            if(val[1] > 0) answer += val[1];
        }
        
        return answer;
    }
}