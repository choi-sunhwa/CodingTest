using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[]{-1, -1};
        int start = 0, end = 0;
        int sum = sequence[start];
        
        while(start < sequence.Length && end < sequence.Length){
            if(sum > k) {
                sum -= sequence[start];
                start++;
            }
            else if(sum < k) {
                end++;
                if(end < sequence.Length) sum += sequence[end];
            }
            else{
                sum -= sequence[start];
                if(answer[0] == -1 || (answer[1] - answer[0] > end - start)){
                    answer[0] = start; answer[1] = end;
                }
                start++;
            }
        }

        return answer;
    }
}