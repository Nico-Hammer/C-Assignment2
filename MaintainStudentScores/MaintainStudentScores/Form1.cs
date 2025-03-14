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
        lstStudents.Items.Clear();
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
    
    // function that updates the Studen
    private void btnUpdateStudent_Click(object sender, EventArgs e)
    {
        // message that is displayed if click in the update button without selecting a student
        if (lstStudents.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a student to update.", 
                "Student not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        // store all the information from the selected student
        string selectedStudent = lstStudents.SelectedItem.ToString();
        var parts = selectedStudent.Split("|"); // split the information by using the | as separator

        if (parts.Length < 2) return;

        string[] nameParts = parts[0].Split(" "); // split the name into first name and last name using a blank space as separator
        string firstName = nameParts[0]; // nameParts[0] is stored in the first name
        string lastName = nameParts[1]; // nameParts[1] is stored in the last name
    
        // linq function to get all scores that a student has, skipping par 1 that is the name of the student
        var scores = parts.Skip(1)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(decimal.Parse)
            .ToList();

        // creating a new instance of the student object
        Student studentToUpdate = new Student(firstName, lastName, scores);
        //passing the instance of the object to the UpdateStudent form
        UpdateStudent updateStudent = new UpdateStudent(studentToUpdate);
        int index = lstStudents.SelectedIndex; // get the index of the selected item in the listBox
        // if the result of the form is different from OK, this will prevent any changes to be saved if the "Cancel" button is clicked.
        if (updateStudent.ShowDialog() != DialogResult.OK) return;
        students.RemoveAt(index); // we remove the out of date student based on the index
        students.Insert(index,studentToUpdate); // and replace it with the new information
        PrintStudents(students); // print the student list with the new information
        // clearing all the fields after updating the student since the selected item is no longer selected
        txtCount.Clear();
        txtScoreTotal.Clear();
        txtStudentAVG.Clear();
        
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
            MessageBox.Show("Please select a student to delete.", 
                "Student not selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (scores.Any())
            {
                txtStudentAVG.Text = Math.Round(scores.Average(), 2).ToString(); // print the selected students average score to the StudentAVG textbox rounded to 2 places
                txtScoreTotal.Text = Math.Round(scores.Sum(), 2).ToString(); // print the sum of the selected students scores to the ScoreTotal textbox rounded to 2 places
                txtCount.Text = scores.Count.ToString(); // print the selected students score count to the Count textbox
            }
            /* clear the score information textboxes if the student has no scores */
            else if (!scores.Any())
            {
                txtCount.Clear();
                txtScoreTotal.Clear();
                txtStudentAVG.Clear();
            }
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