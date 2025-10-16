using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] players, int m, int k) {
        int[] servers = new int[2]; //증설된 서버 수, 증설 횟수
        List<int> time = new List<int>(); //증설된 서버 시간
            
        for(int i = 0; i < players.Length; i++){
            time = time.Where(x => x > i - k).ToList();
            servers[0] = time.Count();
            
            int requiredServerNum = (players[i] / m);
            if(requiredServerNum > servers[0]){
                int _add = requiredServerNum - servers[0];
                servers[0] += _add;
                servers[1] += _add;
                time.AddRange(Enumerable.Repeat(i, _add));
            }
        }
        
        return servers[1];
    }
}