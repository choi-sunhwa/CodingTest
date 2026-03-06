using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        Array.Fill(answer, -1);
        Stack<int> num = new Stack<int>();
        
        for(int i = 0; i < numbers.Length; i++){
            while(num.Count > 0 && numbers[i] > numbers[num.Peek()]){
                answer[num.Pop()] = numbers[i];
            }

            num.Push(i);
        }
        
        return answer;
    }
}