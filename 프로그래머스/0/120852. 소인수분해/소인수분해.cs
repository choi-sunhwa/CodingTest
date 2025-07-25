using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();

        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                answer.Add(i);
                while (n % i == 0) {
                    n /= i;
                }
            }
        }

        // 마지막으로 남은 수가 1보다 크면 그것도 소인수
        if (n > 1) {
            answer.Add(n);
        }

        return answer.ToArray();
    }
}