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
        //Create property for Average grade and calling the GetAverageGrade method and passing quizGrade and examGrade to it
        public double AverageGrade { get => GetAverageGrade(_quizGrade, _examGrade); }

        //Method
        //Create method for calculating the average grade that takes two doubles in its parameters
        public double GetAverageGrade(double examGrade, double quizGade)
        {
            //Create variable for average grade and assign it the result of adding two doubles and dividing them by 2
            double averageGrade = (examGrade + quizGade)/2;
            //Limit the number of digits after decimal to two places with Math round method
            averageGrade = Math.Round(averageGrade, 2);
            return averageGrade;
        }

    }//end class
}//end namespace
