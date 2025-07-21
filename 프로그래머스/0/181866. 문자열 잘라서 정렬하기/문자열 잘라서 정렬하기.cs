using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x').ToList().Where(x => !String.IsNullOrEmpty(x)).OrderBy(x => x).ToArray();
        return answer;
    }
}