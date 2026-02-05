using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[]{0, 0};

        int first_dup_idx = -1;
        HashSet<string> wordSet = new HashSet<string>();
        for(int i = 0; i < words.Length; i++){
            if(!wordSet.Add(words[i])) {
                first_dup_idx = i;
                break;
            }
        }
        
        string lastWord = "";
        for(int i = 0; i < words.Length; i++){
            if(i > 0){
                if(lastWord != words[i].Substring(0,1)){
                    answer[0] = (i % n) + 1;
                    answer[1] = (i / n) + 1;
                    break;
                }
            }
            
            if(i == first_dup_idx){
                answer[0] = (i % n) + 1;
                answer[1] = (i / n) + 1;
                break;
            }
            
           lastWord = words[i].Substring(words[i].Length - 1);
        }
        
        return answer;
    }
}