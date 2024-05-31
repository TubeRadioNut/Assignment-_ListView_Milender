//Charles Milender
//5-30-2024
//Programming 122
//Assignment - ListView
using System.Collections.Generic;
using System.Diagnostics;
using System.Printing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment__ListView_Milender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create List of Students named studentNames
        List<Student> studentNames = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this and keep at the top of MainWindow()

            //Add 5 students' info to List of Student
            studentNames.Add(new Student("Mike Johnson", 95.4, 98.2));
            studentNames.Add(new Student("Jim Dandy", 92.6, 90.4));
            studentNames.Add(new Student("Richard Walker", 88.9, 85));
            studentNames.Add(new Student("Chez Wheeler", 82, 95));
            studentNames.Add(new Student("Brad Holman", 75, 80.7));
            lvStudentGrades.ItemsSource = studentNames;
        }//end MainWindow()

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtStudentName.Text;
            double quizGrade = ParseGrade(txtQuizGrade.Text);
            double examGrade = ParseGrade(txtExamGrade.Text);
            if(studentName.Length > 0 && quizGrade > 0 && quizGrade <= 100 && examGrade > 0 && examGrade <= 100)
            {
                studentNames.Add(new Student(studentName, quizGrade, examGrade));
                lvStudentGrades.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Enter a student name, grade between 0 and 100");
            }
            
        }

        public double ParseGrade(string grade)
        {
            double parseGrade = -1;
            try
            {
                parseGrade = double.Parse(grade);
                return parseGrade;
            }
            catch
            {
                return parseGrade;
            }

            return parseGrade;
        }

        private void btnEditGrades_Click(object sender, RoutedEventArgs e)
        {
            double quizGrade = ParseGrade(txtQuizGrade.Text);
            double examGrade = ParseGrade(txtExamGrade.Text);
            
            if(quizGrade > 0 && quizGrade <= 100 && examGrade > 0 && examGrade <= 100)
            {

            }
        }
    }//end class
}//end namespace

//Requirements:
//User Interface:
//Design a user interface using WPF (Windows Presentation Foundation) forms.
//The interface should include:
//Textboxes for inputting student names, first grade, and second grade.
//Buttons for adding, editing, and deleting student records.
//A ListView to display the list of students, their grades, and average grade.
//Data Handling:
//Create a Student class with properties for Name, Grade1, Grade2, and a method GetAverageGrade().
//Use a list to store student objects.
//Implement methods to add, edit, and delete student records in the list.
//Functionality:
//Add Student:
//Allow users to input a student's name, first grade, and second grade and add this information to the list.
//Update the ListView to reflect the new entry.
//Edit Student:
//Allow users to select a student from the ListView, edit their information, and save the changes.
//Update the ListView to reflect the edited entry.
//Delete Student:
//Allow users to select a student from the ListView and remove them from the list.
//Update the ListView to reflect the deletion.
//Data Validation:
//Ensure that the input for student names is not empty.
//Validate that the grade inputs are numbers between 0 and 100.
//Display:
//Use a ListView to display the list of students, their grades, and average grade in a tabular format.
//Ensure that at least five student names are displayed in the ListView.
//The ListView should update automatically when new data is added, edited, or deleted.