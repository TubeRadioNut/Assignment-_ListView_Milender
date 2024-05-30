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
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this and keep at the top of MainWindow()
        }//end MainWindow()
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