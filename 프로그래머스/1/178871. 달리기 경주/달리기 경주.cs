using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for(int i = 0; i < players.Length; i++){
            dic[players[i]] = i;
        }
        
        foreach(string calling in callings){
            int rank = dic[calling];
            
            string _temp = players[rank - 1];
            players[rank - 1] = calling;
            players[rank] = _temp;
            
            dic[_temp]++;
            dic[calling]--;
        }

        return players;
    }
}