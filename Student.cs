using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__ListView_Milender
{
    public class Student
    {
        //Fields
        string _studentName;
        double _quizGrade;
        double _examGrade;
        //Constructor
        public Student(string studentName, double quizGrade, double examGrade)
        {
            _studentName = studentName;
            _quizGrade = quizGrade;
            _examGrade = examGrade;
        }
        //Properties
        public string StudentName { get => _studentName; set => _studentName = value; }
        public double QuizGrade { get => _quizGrade; set => _quizGrade = value; }
        public double ExamGrade { get => _examGrade; set => _examGrade = value; }
        public double AverageGrade { get => GetAverageGrade(_quizGrade, _examGrade); }

        //Method
        public double GetAverageGrade(double examGrade, double quizGade)
        {
            double averageGrade = (examGrade + quizGade)/2;
            averageGrade = Math.Round(averageGrade, 2);
            return averageGrade;
        }

    }//end class
}//end namespace
