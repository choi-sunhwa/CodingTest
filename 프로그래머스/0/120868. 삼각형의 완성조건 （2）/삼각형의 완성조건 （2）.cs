using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        
        Array.Sort(sides);

        //가장 긴 변이 배열 안에 있을때
        for(int i = (sides[1]-sides[0]); i < sides[1]; i++) answer++;
        //가장 긴 변이 배열에 없을때
        for(int i = (sides[0]+sides[1]-1); i > sides[1]; i--) answer++;
        
        return answer;
    }
}