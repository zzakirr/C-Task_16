using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        static int _no = 0;
        public Student()
        {
            _no++;
            No = _no;
        }
        public int No { get; set; }
        public string Fullname { get; set; }
        public Dictionary<string, int> Exams { get; set; } = new Dictionary<string, int>();
        public void AddExam(string name,int point)
        {
            Exams.Add(name, point);
        }
        public int GetExamResult(string name)
        {
            foreach (var item in Exams)
            {
                if(item.Key == name)
                {
                    return item.Value;
                }
            }
            return 0;
        }
        public double GetExamAvg()
        {
            int totalPoint = 0;
            int count = 0;
            foreach (var item in Exams)
            {
                totalPoint += item.Value ;
                count++;
            }
            double avgPoint = totalPoint / count;
            return avgPoint;
        }
    }
}
