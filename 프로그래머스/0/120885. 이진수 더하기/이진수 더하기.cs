using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = Convert.ToString(Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2), 2);
        return answer;
    }
}