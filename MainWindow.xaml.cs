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
using static System.Net.Mime.MediaTypeNames;

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
            studentNames.Add(new Student("Jan Dandy", 92.6, 90.4));
            studentNames.Add(new Student("Richard Walker", 88.9, 85));
            studentNames.Add(new Student("Jill Wheeler", 93.5, 95));
            studentNames.Add(new Student("Brad Holman", 75, 80.7));
            lvStudentGrades.ItemsSource = studentNames;
        }//end MainWindow()

        //Create method for add student button
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //Create variable for user input of student name
            string studentName = txtStudentName.Text;
            //Create variables for user input of grades, parse user input by calling the ParseGarde() method passing user input to it
            double quizGrade = ParseGrade(txtQuizGrade.Text);
            double examGrade = ParseGrade(txtExamGrade.Text);
            //Test user input for student name is not blank, test user input for grades is between 0 and 100
            if(studentName.Length > 0 && quizGrade >= 0 && quizGrade <= 100 && examGrade >= 0 && examGrade <= 100)
            {
                studentNames.Add(new Student(studentName, quizGrade, examGrade));
                lvStudentGrades.Items.Refresh();
                txtStudentName.Text = "";
                txtQuizGrade.Text = "";
                txtExamGrade.Text = "";

            }
            //Inform user of invalid input with MessageBox
            else
            {
                MessageBox.Show($"Enter a Student name & \nQuiz grade & \nExam Grade between 0 and 100");
            }
            
        }

        //Create method for edit grade button
        private void btnEditGrades_Click(object sender, RoutedEventArgs e)
        {
            //Create variables for user input of grades, parse user input by calling the ParseGarde() method passing user input to it
            double quizGrade = ParseGrade(txtQuizGrade.Text);
            double examGrade = ParseGrade(txtExamGrade.Text);
            //Create variable for selected index of list view item
            int selectedIndex = lvStudentGrades.SelectedIndex;
            //Test user selected a student from the list view
            if(lvStudentGrades.SelectedIndex != -1)
            {
                //Test user input for grades is between 0 and 100
                if (quizGrade >= 0 && quizGrade <= 100 || examGrade >= 0 && examGrade <= 100)
                {
                    //Test user input for quiz grade is between 0 and 100
                    if (quizGrade > 0 && quizGrade <= 100)
                    {
                        //Use selected index variable for List studentNames index and assign user input to quiz grade
                        studentNames[selectedIndex].QuizGrade = quizGrade;
                    }
                    //test user input for exam grade is between 0 and 100
                    if (examGrade > 0 && examGrade <= 100)
                    {
                        //Use selected index variable for List studentNames index and assign uer input to exam grade
                        studentNames[selectedIndex].ExamGrade = examGrade;
                    }
                    //Update list view with updated List studentGrades
                    lvStudentGrades.Items.Refresh();
                    //Clear user input fields
                    txtStudentName.Text = "";
                    txtQuizGrade.Text = "";
                    txtExamGrade.Text = "";
                }
                //inform user of invaid input with message box
                else
                {
                    MessageBox.Show("Enter a grade between 0 and 100 in Quiz or Exam Grade or both");
                }
            }
            //Inform user no student is selected in the list view
            else
            {
                MessageBox.Show("Highlight a student first");
            }
            
        }

        //Create method for remove student button
        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            //Create variable for selected index of list view item
            int selectedIndex = lvStudentGrades.SelectedIndex;
            //Test user selected a student from the list view
            if (lvStudentGrades.SelectedIndex != -1)
            {
                //Use selected index variable for List studentNames index and remove that index
                studentNames.Remove(studentNames[selectedIndex]);
                //Update list view with updated List studentGrades
                lvStudentGrades.Items.Refresh();
            }
            //Inform user no student is selected in the list view
            else
            {
                MessageBox.Show("Highlight a Student First");
            }
        }

        //Create method for parse user input to a double tht takes a string in its parameters and returns a double
        public double ParseGrade(string grade)
        {
            //Create variable for parsed string to a double and assign it the value of negative one
            double parseGrade = -1;
            //Use try/catch to parse string to a double and return that double
            try
            {
                parseGrade = double.Parse(grade);
                return parseGrade;
            }
            catch
            {
                return parseGrade;
            }
            //don't believe we will ever get here, but need a return for the method
            return parseGrade;
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