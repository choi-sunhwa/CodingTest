using System;
using System.Linq;

public class Solution {
    public int solution(int number, int limit, int power) {
        int[] arr = Enumerable.Repeat(1, (number + 1)).ToArray();
        arr[0] = 0;
        
        for(int j = 2; j <= number; j++){
            int val = j;
            while(val <= number){
                arr[val]++;
                val += j;
            }
        }
        
        return arr.Select(x => ((x > limit) ? power : x)).Sum();
    }
}