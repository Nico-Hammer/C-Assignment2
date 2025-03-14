namespace MaintainStudentScores;

public partial class UpdateStudent : Form
{
    private Student selectedStudent { get; set;  }

    // constructor that initialize the form and get the current instance of Student object
    public UpdateStudent(Student student)
    {
        InitializeComponent();
        selectedStudent = student; // this statement access the instance of the student object so it can be used in this form
        LoadStudentData(); // Function to load all the data from the selected student passed to the form
    }

    // Function to load and display all the information from the selected student
    private void LoadStudentData()
    {
        txtUpdateName.Text = selectedStudent.firstName + " " + selectedStudent.lastName;
        lstUpdateScores.Items.Clear();
        
        // loop to display all the scores that a student can have
        foreach (decimal score in selectedStudent.score)
        {
            lstUpdateScores.Items.Add(score.ToString());
        }
    }
    
    //function to close the UpdateStudent modal when clicking Cancel button
    private void btnUpdateCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    // function to add a new score to the student
    private void btnUpdateAdd_Click(object sender, EventArgs e)
    {
        AddScore addScore = new AddScore(); //creating a new instance of the AddScore Form
        if (addScore.ShowDialog() != DialogResult.OK) return; // if statement to check the return of the AddScore form
        // when returned from AddScore form, the new score will be added to the instance of the student object
        selectedStudent.score.Add(decimal.Parse(addScore.AddStudentScore));
        lstUpdateScores.Items.Add(addScore.AddStudentScore); // this statement adds the returned score in the listBox component
    }

    // function to update a score based on the selction
    private void btnUpdateScore_Click(object sender, EventArgs e)
    {
        if (lstUpdateScores.SelectedIndex != -1) // check that the selected score is in the list i.e. exists
        {
            int index = lstUpdateScores.SelectedIndex;
            string selectedScore = lstUpdateScores.SelectedItem.ToString(); // storing the selected value to the selectedScore variable
            UpdateScore updateScoreForm = new UpdateScore(selectedScore);  //creating a new instance of the AddScore Form
                if (updateScoreForm.ShowDialog() != DialogResult.OK) return; // if statement to check the return of the UpdateScore form
                // when returned from UpdateScore form, the new score will replace the selected score
                selectedStudent.score[index] = decimal.Parse(updateScoreForm.UpdatedStudentScore);
                // this statement replace the returned score in the listBox component
                lstUpdateScores.Items[lstUpdateScores.SelectedIndex] = updateScoreForm.UpdatedStudentScore; 
        }
        else
        {
            /* if no score is selected show a messagebox informing to select a score */
            RenderMessage("update");
        }
    }

    // function to remove a score based on the selection made on the listBox
    private void btnUpdateRemove_Click(object sender, EventArgs e)
    {
        if (lstUpdateScores.SelectedIndex != -1) // check that the selected score is in the list i.e. exists
        {
            int index = lstUpdateScores.SelectedIndex; // save the inddex of the selected score
            selectedStudent.score.RemoveAt(index); // remove the selected score from the  list
            lstUpdateScores.Items.RemoveAt(index); // remove the selected score from the listbox
            lstUpdateScores.SelectedIndex = -1; // make the selected index invalid since the score no longer exists and cant be accessed
        }
        /* if no score is selected or the selected score is deleted show a messagebox informing to select a score */
        else
        {
            RenderMessage("delete");
        }
    }

    // function that clears all scores from the listbox component
    private void btnUpdateClear_Click(object sender, EventArgs e)
    {
        lstUpdateScores.Items.Clear(); //clear all scores in the listBox component
        selectedStudent.score.Clear(); // clear all scores from the selectedStudent object
    }

    // function that updates the current instance of the selected student object
    private void btnUpdateOk_Click(object sender, EventArgs e)
    {
        // create the new student object with the new data
        selectedStudent = new Student(selectedStudent.firstName, selectedStudent.lastName, selectedStudent.score);
        DialogResult = DialogResult.OK; // set the return of the value to true
        Close(); // close the form
    }
    
    // helper function to reduce some lines of code and show a message according to the action performed by the user (update or add score)
    private static void RenderMessage(string action)
    {
        MessageBox.Show($"Select a score to {action}.", 
            "Score not selected", 
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}