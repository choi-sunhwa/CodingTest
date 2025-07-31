using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        var strList = strArr.GroupBy(x => x.Length).Select(x => new {val = x.Key, Count = x.Count()}).OrderByDescending(x => x.Count).ToList();
        
        return strList[0].Count;
    }
}