using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        List<int> list = numlist.ToList()
                         .Select(x => new {key = x, distance = Math.Abs(x - n)})
                         .OrderBy(x => x.distance)
                         .ThenByDescending(x => x.key)
                         .Select(x => x.key)
                         .ToList();
        
        return list.ToArray();
    }
}