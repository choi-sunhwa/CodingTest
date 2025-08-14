using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        var dic = id_list.ToDictionary(key => key, value => new Info());
        for(int i = 0; i < report.Length; i++){
            string[] val = report[i].Split(' ');
            if(dic[val[0]].Report.Where(x => x == val[1]).Count() == 0) {
                dic[val[0]].Report.Add(val[1]);
                dic[val[1]].warningCnt++;
            }
        }        
        
        var warning_p = dic.Where(x => x.Value.warningCnt >= k).Select(x => x.Key).ToList();
        
        for(int i = 0; i < id_list.Length; i++){
            answer[i] = dic[id_list[i]].Report.Count(x => warning_p.Contains(x));
        }
        
        return answer;
    }
    
    public class Info{
        public int warningCnt {get; set;}
        private List<string> _report = null;
        public List<string> Report
        {
            get
            {
                if (_report == null)
                {
                    _report = new List<string>();
                }
                return _report;
            }
            set
            {
                _report = value;
            }
        }
    }
}