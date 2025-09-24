using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int[] my_info = new int[2];
        my_info[0] = (num / w) + (num % w > 0 ? 1 : 0); //몇번째 줄에 있는지
        my_info[1] = (num % w == 0) ? w : (num % w); //몇번째 자리에 있는지
        if(my_info[0] % 2 == 0) my_info[1] = w - my_info[1] + 1;
        
        int[] total_info = new int[2];
        total_info[0] = (n / w) + (n % w > 0 ? 1 : 0);
        total_info[1] = (n % w == 0) ? w : (n % w);
        if(total_info[0] % 2 == 0) total_info[1] = w - total_info[1] + 1;
        
        bool isAdd = false;
        if(total_info[0] % 2 == 0){
            if(my_info[1] >= total_info[1]) isAdd = true;
        }else{
            if(total_info[1] >= my_info[1]) isAdd = true;
        }
        
        return (total_info[0] - my_info[0]) + (isAdd ? 1 : 0);
    }
}