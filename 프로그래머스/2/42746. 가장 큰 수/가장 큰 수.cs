using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(int[] numbers) {
        string answer = "";
        
        List<string> numbersList = numbers.Select(x => x.ToString()).ToList();
        numbersList.Sort((a,b) => (b + a).CompareTo(a + b));

        return numbersList[0] == "0" ? "0" : string.Concat(numbersList);
    }
}