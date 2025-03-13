namespace MaintainStudentScores;
public partial class Form1 : Form
{
    private List<Student> students = new List<Student>();
    public Form1()
    {
        InitializeComponent();
    }

    /* function to load the sample students into the student object */
    private void LoadSample()
    {
        /* the 3 sample students */
        students.Add(new Student("Joel", "Murach", [ 97, 91, 83 ]));
        students.Add(new Student("Doug", "Lowe", [ 99, 93, 97 ]));
        students.Add(new Student("Anne", "Boehm", [ 100, 100, 100 ]));
        PrintStudents(students); // call the PrintStudents function with the student object to print all the students to the list box
    }
    /* function that takes a student object as an argument and prints all the students to the listbox */
    private void PrintStudents(List<Student> students)
    {
        /* loop through every student in the list */
        foreach (Student s in students)
        {
            string studentscoreinfo = ""; // initialize a string to hold the student scores
            /* loop through the score list of every student */
            foreach (Decimal score in s.score)
            {
                studentscoreinfo += $"{score}|"; // add the scores to the string for the respective student
            }
            string fullstudentinfo = $"{s.firstName} {s.lastName}|{studentscoreinfo}"; // coalate all of the student information into a single string
            lstStudents.Items.Add(fullstudentinfo); // add the student info to the listbox
        }
    }
    /* function thats called when the Add New button is clicked on the form */
    private void btnAddNew_Click(object sender, EventArgs e)
    {
        AddNewStudent newStudentForm = new AddNewStudent(); // create a new AddNewStudent form window
        /*****************************
         * if AddNewStudent form is closed
         * clear the current listbox,
         * create a new student list,
         * add that list to the student object
         * print the new list to the listbox
         ******************************/
        if (newStudentForm.ShowDialog() == DialogResult.OK)
        {
            lstStudents.Items.Clear();
            Student newStudent = newStudentForm.NewStudent;
            students.Add(newStudent);
            PrintStudents(students);
        }
    }
    
    private void btnUpdateStudent_Click(object sender, EventArgs e)
    {
        if (lstStudents.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a student to update.", 
                "Student not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string selectedStudent = lstStudents.SelectedItem.ToString();
        var parts = selectedStudent.Split("|");

        if (parts.Length < 2) return;

        string[] nameParts = parts[0].Split(" ");
        string firstName = nameParts[0];
        string lastName = nameParts[1];
    
        var scores = parts.Skip(1)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(decimal.Parse)
            .ToList();

        Student studentToUpdate = new Student(firstName, lastName, scores);
    
        UpdateStudent updateStudent = new UpdateStudent(studentToUpdate);
        updateStudent.ShowDialog();
    }
    
    private void btnDeleteStudent_Click(object sender, EventArgs e)
    {
        if (lstStudents.SelectedIndex != -1) // check that the selected student is in the list i.e. exists
        {
            int index = lstStudents.SelectedIndex; // save the inddex of the selected student
            students.RemoveAt(index); // remove the selected student from the student list
            lstStudents.Items.RemoveAt(index); // remove the selected student from the listbox
            lstStudents.SelectedIndex = -1; // make the selected index invalid since the student no longer exists and cant be accessed
        }
        /* if no student is selected or the selected student is deleted show a messagebox informing to select a student */
        else
        {
            MessageBox.Show("Select a student to delete");
        }
    }
    
    private void btnExit_Click(object sender, EventArgs e)
    {
        Close(); // close the program when the exit button is clicked
    }

    private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstStudents.SelectedIndex != -1) // check that the selected student is in the list i.e. exists
        {
            string selectedStudent = lstStudents.SelectedItem.ToString(); // get the selected students information as a string
            var scores = selectedStudent.Split("|") // separate each score by a "|"
                .Skip(1) // skip 1st part, in this case the name
                .Where(s => !string.IsNullOrWhiteSpace(s)) // only care about the characters that aren't whitespace or null
                .Select(decimal.Parse).ToList(); // make sure the score is a number then add it to a list
        
            txtScoreTotal.Text = Math.Round(scores.Sum(), 2).ToString(); // print the sum of the selected students scores to the ScoreTotal textbox rounded to 2 places
            txtCount.Text = scores.Count.ToString(); // print the selected students score count to the Count textbox
            txtStudentAVG.Text = Math.Round(scores.Average(), 2).ToString(); // print the selected students average score to the StudentAVG textbox rounded to 2 places
        }
        /* if no student is selected or the selected student is deleted clear all the score information textboxes */
        else
        {
            txtCount.Clear();
            txtScoreTotal.Clear();
            txtStudentAVG.Clear();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadSample(); // load the sample students into the object when the form is loaded i.e. starting the program
    }
}