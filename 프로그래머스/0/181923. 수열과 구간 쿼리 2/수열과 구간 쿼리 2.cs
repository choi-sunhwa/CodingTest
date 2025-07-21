using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        List<int> answer = new List<int>();
        for(int i = 0; i < queries.GetLength(0); i++){
            var val = arr.ToList().Skip(queries[i,0]).Take((queries[i,1] - queries[i,0]) + 1).Where(x => x > queries[i,2]);
            if(val.Any()) answer.Add(val.Min());
            else answer.Add(-1);
        }
        
        return answer.ToArray();
    }
}